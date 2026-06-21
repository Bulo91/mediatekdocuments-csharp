using System;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Newtonsoft.Json.Linq;
using Serilog;

namespace MediaTekDocuments.manager
{
    /// <summary>
    /// Client HTTP singleton pour appeler l'API REST distante, avec authentification Basic optionnelle.
    /// </summary>
    class ApiRest
    {
        /// <summary>
        /// Certificat auto-signé par défaut d'AwardSpace (thumbprint observé sur mediatekdocuments.myartsonline.com).
        /// Permet de valider explicitement ce certificat sans désactiver la validation SSL globalement.
        /// </summary>
        private const string AwardSpaceDefaultCertThumbprint = "32F0B54A0889997F8DFBC7F968FB50682301BC53";

        /// <summary>
        /// unique instance de la classe
        /// </summary>
        private static ApiRest instance = null;

        private static readonly object TlsLock = new object();
        private static bool tlsConfigured = false;
        private static string apiHost;

        /// <summary>
        /// Objet de connexion à l'api
        /// </summary>
        private readonly HttpClient httpClient;

        /// <summary>
        /// Adresse de base de l'API (pour les logs d'erreur).
        /// </summary>
        private readonly string baseUri;

        /// <summary>
        /// Constructeur privé pour préparer la connexion à l'API distante.
        /// </summary>
        /// <param name="uriApi">Adresse de base de l'API.</param>
        /// <param name="username">Identifiant d'authentification API.</param>
        /// <param name="password">Mot de passe d'authentification API.</param>
        private ApiRest(string uriApi, string username, string password)
        {
            ConfigureTlsAndCertificateValidation(uriApi);
            baseUri = uriApi;
            httpClient = new HttpClient() { BaseAddress = new Uri(uriApi) };
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                string credentials = Convert.ToBase64String(
                    Encoding.ASCII.GetBytes(username + ":" + password));
                httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + credentials);
            }
        }

        /// <summary>
        /// Force TLS 1.2 et enregistre la validation de certificat pour l'hôte de l'API.
        /// </summary>
        private static void ConfigureTlsAndCertificateValidation(string uriApi)
        {
            lock (TlsLock)
            {
                if (tlsConfigured)
                {
                    return;
                }

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                apiHost = new Uri(uriApi).Host;
                ServicePointManager.ServerCertificateValidationCallback += ValidateServerCertificate;
                tlsConfigured = true;
                Log.Information("ApiRest - TLS 1.2 activé pour l'hôte API : {ApiHost}", apiHost);
            }
        }

        /// <summary>
        /// Valide le certificat SSL du serveur API.
        /// Accepte le certificat auto-signé AwardSpace connu pour l'hôte configuré uniquement.
        /// </summary>
        private static bool ValidateServerCertificate(
            object sender,
            X509Certificate certificate,
            X509Chain chain,
            SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
            {
                return true;
            }

            var request = sender as HttpWebRequest;
            string host = request?.RequestUri?.Host ?? "?";
            X509Certificate2 cert2 = certificate != null ? new X509Certificate2(certificate) : null;

            Log.Warning(
                "Validation SSL échouée - Hôte={Host}, Erreurs={SslErrors}, Subject={Subject}, Issuer={Issuer}, Thumbprint={Thumbprint}",
                host,
                sslPolicyErrors,
                cert2?.Subject,
                cert2?.Issuer,
                cert2?.Thumbprint);

            if (host.Equals(apiHost, StringComparison.OrdinalIgnoreCase)
                && cert2 != null
                && cert2.Thumbprint.Equals(AwardSpaceDefaultCertThumbprint, StringComparison.OrdinalIgnoreCase))
            {
                Log.Information(
                    "Certificat AwardSpace auto-signé accepté pour {Host} (thumbprint={Thumbprint})",
                    host,
                    cert2.Thumbprint);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Retourne l'instance unique du client HTTP configuré pour l'API REST.
        /// </summary>
        /// <param name="uriApi">Adresse de base de l'API.</param>
        /// <param name="username">Identifiant d'authentification API.</param>
        /// <param name="password">Mot de passe d'authentification API.</param>
        /// <returns>L'instance singleton de <see cref="ApiRest"/>.</returns>
        public static ApiRest GetInstance(string uriApi, string username, string password)
        {
            if (instance == null)
            {
                instance = new ApiRest(uriApi, username, password);
            }
            return instance;
        }

        /// <summary>
        /// Envoi une demande à l'API et récupère la réponse
        /// </summary>
        /// <param name="methode">verbe http (GET, POST, PUT, DELETE)</param>
        /// <param name="message">message à envoyer dans l'URL</param>
        /// <param name="parametres">contenu de variables à mettre dans body</param>
        /// <returns>liste d'objets (select) ou liste vide (ok) ou null si erreur</returns>
        public JObject RecupDistant(string methode, string message, String parametres)
        {
            string requestUrl = new Uri(httpClient.BaseAddress, message).ToString();
            try
            {
                StringContent content = null;
                if (!(parametres is null))
                {
                    content = new StringContent(parametres, Encoding.UTF8, "application/x-www-form-urlencoded");
                }

                HttpResponseMessage httpResponse;
                switch (methode)
                {
                    case "GET":
                        httpResponse = httpClient.GetAsync(message).Result;
                        break;
                    case "POST":
                        httpResponse = httpClient.PostAsync(message, content).Result;
                        break;
                    case "PUT":
                        httpResponse = httpClient.PutAsync(message, content).Result;
                        break;
                    case "DELETE":
                        httpResponse = httpClient.DeleteAsync(message).Result;
                        break;
                    default:
                        Log.Error("ApiRest - Méthode HTTP non supportée : {Methode}, URL={Url}", methode, requestUrl);
                        return new JObject();
                }

                var json = httpResponse.Content.ReadAsStringAsync().Result;
                return JObject.Parse(json);
            }
            catch (Exception ex)
            {
                Log.Error(
                    ex,
                    "ApiRest - Erreur HTTP {Methode} {Url}{NewLine}{ExceptionChain}",
                    methode,
                    requestUrl,
                    Environment.NewLine,
                    FormatExceptionChain(ex));
                throw;
            }
        }

        /// <summary>
        /// Formate la chaîne complète d'exceptions (AggregateException incluse).
        /// </summary>
        private static string FormatExceptionChain(Exception ex)
        {
            var sb = new StringBuilder();
            AppendException(sb, ex, 0);
            return sb.ToString();
        }

        private static void AppendException(StringBuilder sb, Exception ex, int depth)
        {
            if (ex == null)
            {
                return;
            }

            if (ex is AggregateException aggregateException)
            {
                foreach (Exception inner in aggregateException.Flatten().InnerExceptions)
                {
                    AppendException(sb, inner, depth);
                }
                return;
            }

            sb.Append(' ', depth * 2);
            sb.Append(ex.GetType().FullName);
            sb.Append(": ");
            sb.AppendLine(ex.Message);
            if (!string.IsNullOrEmpty(ex.StackTrace))
            {
                sb.Append(' ', depth * 2);
                sb.AppendLine(ex.StackTrace);
            }
            AppendException(sb, ex.InnerException, depth + 1);
        }
    }
}
