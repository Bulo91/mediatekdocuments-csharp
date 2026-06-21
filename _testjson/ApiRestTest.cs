using System;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class ApiRestTest
{
    private const string AwardSpaceDefaultCertThumbprint = "32F0B54A0889997F8DFBC7F968FB50682301BC53";
    private static string apiHost;

    static void Main()
    {
        string uriApi = "https://mediatekdocuments.myartsonline.com/";
        apiHost = new Uri(uriApi).Host;
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        ServicePointManager.ServerCertificateValidationCallback += ValidateServerCertificate;

        try
        {
            var httpClient = new HttpClient() { BaseAddress = new Uri(uriApi) };
            string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes("mediatkuser:mediatkpwd"));
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + credentials);

            var obj = new { login = "tout", motDePasse = "ToutPwd_1" };
            string jsonChamps = JsonConvert.SerializeObject(obj);
            string message = "authentification/" + Uri.EscapeDataString(jsonChamps);
            string requestUrl = new Uri(httpClient.BaseAddress, message).ToString();
            Console.WriteLine("GET " + requestUrl);

            var httpResponse = httpClient.GetAsync(message).Result;
            var json = httpResponse.Content.ReadAsStringAsync().Result;
            Console.WriteLine("Response: " + json);

            JObject retour = JObject.Parse(json);
            if (retour["code"] != null && retour["code"].ToString() == "200")
            {
                Console.WriteLine("TEST OK");
            }
            else
            {
                Console.WriteLine("TEST FAIL code=" + retour["code"]);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("TEST EXCEPTION");
            PrintEx(ex, 0);
        }
    }

    static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
    {
        if (sslPolicyErrors == SslPolicyErrors.None) return true;
        var request = sender as HttpWebRequest;
        string host = request != null && request.RequestUri != null ? request.RequestUri.Host : "?";
        var cert2 = certificate != null ? new X509Certificate2(certificate) : null;
        Console.WriteLine("SSL errors on " + host + ": " + sslPolicyErrors + " thumb=" + (cert2 != null ? cert2.Thumbprint : "null"));
        if (host.Equals(apiHost, StringComparison.OrdinalIgnoreCase)
            && cert2 != null
            && cert2.Thumbprint.Equals(AwardSpaceDefaultCertThumbprint, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("AwardSpace cert accepted");
            return true;
        }
        return false;
    }

    static void PrintEx(Exception ex, int d)
    {
        var agg = ex as AggregateException;
        if (agg != null)
        {
            foreach (var inner in agg.Flatten().InnerExceptions) PrintEx(inner, d);
            return;
        }
        Console.WriteLine(new string(' ', d*2) + ex.GetType().FullName + ": " + ex.Message);
        PrintEx(ex.InnerException, d+1);
    }
}
