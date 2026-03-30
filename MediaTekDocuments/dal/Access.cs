using System;
using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.manager;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Linq;
using Serilog;

namespace MediaTekDocuments.dal
{
    /// <summary>
    /// Classe d'accès aux données
    /// </summary>
    public class Access
    {
        /// <summary>
        /// adresse de l'API
        /// </summary>
        private static readonly string uriApi = ConfigurationManager.AppSettings["uriApi"];
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static Access instance = null;
        /// <summary>
        /// instance de ApiRest pour envoyer des demandes vers l'api et recevoir la réponse
        /// </summary>
        private readonly ApiRest api = null;
        /// <summary>
        /// méthode HTTP pour select
        /// </summary>
        private const string GET = "GET";
        /// <summary>
        /// méthode HTTP pour insert
        /// </summary>
        private const string POST = "POST";
        /// <summary>
        /// méthode HTTP pour update
        /// </summary>
        private const string PUT = "PUT";
        /// <summary>
        /// méthode HTTP pour delete
        /// </summary>
        private const string DELETE = "DELETE";
        /// <summary>
        /// préfixe des paramètres POST/PUT pour l'API
        /// </summary>
        private const string CHAMPS = "champs=";

        /// <summary>
        /// Méthode privée pour créer un singleton
        /// initialise l'accès à l'API
        /// </summary>
        private Access()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.Console()
                .WriteTo.File("logs/log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            String authenticationString;
            try
            {
                authenticationString = ConfigurationManager.AppSettings["apiAuthenticationString"];
                api = ApiRest.GetInstance(uriApi, authenticationString);
            }
            catch (Exception e)
            {
                Log.Error(e, "Erreur configuration API : {Message}", e.Message);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Création et retour de l'instance unique de la classe
        /// </summary>
        /// <returns>instance unique de la classe</returns>
        public static Access GetInstance()
        {
            if(instance == null)
            {
                instance = new Access();
            }
            return instance;
        }

		/// <summary>
		/// Authentifie un utilisateur par login et mot de passe.
		/// Appelle l'API en GET et retourne le premier utilisateur trouvé.
		/// </summary>
		/// <param name="login">Login de l'utilisateur</param>
		/// <param name="motDePasse">Mot de passe en clair</param>
		/// <returns>Utilisateur avec droits, ou null si authentification échouée</returns>
		public Utilisateur AuthentifierUtilisateur(string login, string motDePasse)
		{
			try
			{
				var obj = new { login = login, motDePasse = motDePasse };
				string jsonChamps = JsonConvert.SerializeObject(obj);
				List<Utilisateur> utilisateurs = TraitementRecup<Utilisateur>(
					GET,
					"authentification/" + jsonChamps,
					null
				);
				return (utilisateurs != null && utilisateurs.Count > 0) ? utilisateurs[0] : null;
			}
			catch (Exception ex)
			{
				Log.Error(ex, "Erreur authentification : {Message}", ex.Message);
				return null;
			}
		}

		/// <summary>
		/// Retourne tous les genres à partir de la BDD
		/// </summary>
		/// <returns>Liste d'objets Genre</returns>
		public List<Categorie> GetAllGenres()
        {
            IEnumerable<Genre> lesGenres = TraitementRecup<Genre>(GET, "genre", null);
            return new List<Categorie>(lesGenres);
        }

        /// <summary>
        /// Retourne tous les rayons à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            IEnumerable<Rayon> lesRayons = TraitementRecup<Rayon>(GET, "rayon", null);
            return new List<Categorie>(lesRayons);
        }

        /// <summary>
        /// Retourne toutes les catégories de public à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            IEnumerable<Public> lesPublics = TraitementRecup<Public>(GET, "public", null);
            return new List<Categorie>(lesPublics);
        }

        /// <summary>
        /// Retourne tous les états à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Etat</returns>
        public List<Etat> GetAllEtats()
        {
            List<Etat> lesEtats = TraitementRecup<Etat>(GET, "etat", null);
            return lesEtats ?? new List<Etat>();
        }

        /// <summary>
        /// Retourne toutes les livres à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            List<Livre> lesLivres = TraitementRecup<Livre>(GET, "livre", null);
            return lesLivres;
        }

        /// <summary>
        /// Retourne toutes les dvd à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            List<Dvd> lesDvd = TraitementRecup<Dvd>(GET, "dvd", null);
            return lesDvd;
        }

        /// <summary>
        /// Retourne toutes les revues à partir de la BDD
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            List<Revue> lesRevues = TraitementRecup<Revue>(GET, "revue", null);
            return lesRevues;
        }


        /// <summary>
        /// Retourne les exemplaires d'une revue
        /// </summary>
        /// <param name="idDocument">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocument)
        {
            return GetExemplairesDocument(idDocument);
        }

        /// <summary>
        /// Retourne les exemplaires d'un document (livre, DVD ou revue)
        /// </summary>
        /// <param name="idDocument">id du document concerné</param>
        /// <returns>Liste d'objets Exemplaire triée par dateAchat DESC</returns>
        public List<Exemplaire> GetExemplairesDocument(string idDocument)
        {
            String jsonIdDocument = convertToJson("id", idDocument);
            List<Exemplaire> lesExemplaires = TraitementRecup<Exemplaire>(GET, "exemplaire/" + jsonIdDocument, null);
            return lesExemplaires ?? new List<Exemplaire>();
        }

        /// <summary>
        /// Modifie l'état d'un exemplaire
        /// </summary>
        /// <param name="idDocument">id du document</param>
        /// <param name="numero">numéro de l'exemplaire</param>
        /// <param name="idEtat">nouvel id d'état</param>
        /// <returns>true si la modification a pu se faire</returns>
        public bool ModifierEtatExemplaire(string idDocument, int numero, string idEtat)
        {
            var obj = new { numero = numero, idEtat = idEtat };
            String jsonChamps = JsonConvert.SerializeObject(obj);
            try
            {
                String parametres = CHAMPS + Uri.EscapeDataString(jsonChamps);
                return TraitementEcrire(PUT, "exemplaire/" + Uri.EscapeDataString(idDocument), parametres);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur ModifierEtatExemplaire : {Message}", ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Retourne les commandes d'un document (livre ou DVD)
        /// </summary>
        /// <param name="idLivreDvd">id du livre ou DVD concerné</param>
        /// <returns>Liste d'objets CommandeDocument triée par date DESC</returns>
        public List<CommandeDocument> GetCommandesDocument(string idLivreDvd)
        {
            String jsonIdLivreDvd = convertToJson("idLivreDvd", idLivreDvd);
            List<CommandeDocument> lesCommandes = TraitementRecup<CommandeDocument>(GET, "commandesdocument/" + jsonIdLivreDvd, null);
            return lesCommandes ?? new List<CommandeDocument>();
        }

        /// <summary>
        /// Crée une commande de document (livre ou DVD) en base de données.
        /// Insère dans commande et commandedocument avec suivi "en cours" (00001).
        /// </summary>
        /// <param name="commande">CommandeDocument à insérer (dateCommande, montant, nbExemplaire, idLivreDvd, idSuivi)</param>
        /// <returns>true si l'insertion a pu se faire</returns>
        public bool CreerCommandeDocument(CommandeDocument commande)
        {
            String jsonChamps = CommandeDocumentToChampsJson(commande);
            try
            {
                String parametres = CHAMPS + Uri.EscapeDataString(jsonChamps);
                return TraitementEcrire(POST, "commandedocument", parametres);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur CreerCommandeDocument : {Message}", ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Modifie le suivi d'une commande document (PUT - uniquement idSuivi).
        /// </summary>
        /// <param name="idCommande">Id de la commande</param>
        /// <param name="idSuivi">Nouveau suivi (00001, 00002, 00003, 00004)</param>
        /// <returns>true si la modification a pu se faire</returns>
        public bool ModifierSuiviCommandeDocument(string idCommande, string idSuivi)
        {
            var obj = new { idSuivi = idSuivi };
            String jsonChamps = JsonConvert.SerializeObject(obj);
            try
            {
                String parametres = CHAMPS + Uri.EscapeDataString(jsonChamps);
                return TraitementEcrire(PUT, "commandedocument/" + Uri.EscapeDataString(idCommande), parametres);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur ModifierSuiviCommandeDocument : {Message}", ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Supprime une commande document (DELETE).
        /// Règle métier côté API : refus si suivi = livrée (00003) ou réglée (00004).
        /// </summary>
        /// <param name="idCommande">Id de la commande à supprimer</param>
        /// <returns>ResultatSuppression : Succes, RefuseCommande, ou Erreur</returns>
        public ResultatSuppression SupprimerCommandeDocument(string idCommande)
        {
            try
            {
                String jsonChamps = convertToJson("id", idCommande);
                String message = "commandedocument/" + Uri.EscapeDataString(jsonChamps);
                return TraitementSupprimer(DELETE, message);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur SupprimerCommandeDocument : {Message}", ex.Message);
                return ResultatSuppression.Erreur;
            }
        }

        /// <summary>
        /// Retourne les commandes / abonnements d'une revue
        /// </summary>
        /// <param name="idRevue">id de la revue concernée</param>
        /// <returns>Liste d'objets AbonnementRevue</returns>
        public List<AbonnementRevue> GetCommandesRevue(string idRevue)
        {
            String jsonIdRevue = convertToJson("idRevue", idRevue);
            List<AbonnementRevue> lesCommandes = TraitementRecup<AbonnementRevue>(GET, "commandesrevue/" + jsonIdRevue, null);
            return lesCommandes ?? new List<AbonnementRevue>();
        }

        /// <summary>
        /// Retourne les revues dont l'abonnement se termine dans les 30 prochains jours (titre + date de fin).
        /// </summary>
        /// <returns>Liste d'AlerteAbonnementRevue, ou liste vide si aucun résultat</returns>
        public List<AlerteAbonnementRevue> GetAbonnementsRevuesFinProche()
        {
            List<AlerteAbonnementRevue> alertes = TraitementRecup<AlerteAbonnementRevue>(GET, "abonnementsrevuesfinproche", null);
            return alertes ?? new List<AlerteAbonnementRevue>();
        }

        /// <summary>
        /// Crée une commande / abonnement de revue en base de données.
        /// </summary>
        /// <param name="abonnement">AbonnementRevue à insérer</param>
        /// <returns>true si l'insertion a pu se faire</returns>
        public bool CreerCommandeRevue(AbonnementRevue abonnement)
        {
            String jsonChamps = AbonnementRevueToChampsJson(abonnement);
            try
            {
                String parametres = CHAMPS + Uri.EscapeDataString(jsonChamps);
                return TraitementEcrire(POST, "commandesrevue", parametres);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur CreerCommandeRevue : {Message}", ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Supprime une commande / abonnement de revue (DELETE).
        /// Règles métier à appliquer côté API si besoin.
        /// </summary>
        /// <param name="idCommande">Id de la commande à supprimer</param>
        /// <returns>ResultatSuppression : Succes, RefuseCommande, ou Erreur</returns>
        public ResultatSuppression SupprimerCommandeRevue(string idCommande)
        {
            try
            {
                String jsonChamps = convertToJson("id", idCommande);
                String message = "commandesrevue/" + Uri.EscapeDataString(jsonChamps);
                return TraitementSupprimer(DELETE, message);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur SupprimerCommandeRevue : {Message}", ex.Message);
                return ResultatSuppression.Erreur;
            }
        }

        /// <summary>
        /// Sérialise une <see cref="AbonnementRevue"/> en JSON pour l'API PHP (insertion).
        /// </summary>
        /// <param name="abonnement">Abonnement à sérialiser.</param>
        /// <returns>Chaîne JSON des champs attendus par l'API.</returns>
        private String AbonnementRevueToChampsJson(AbonnementRevue abonnement)
        {
            var obj = new
            {
                dateCommande = abonnement.DateCommande,
                montant = abonnement.Montant,
                dateFinAbonnement = abonnement.DateFinAbonnement,
                idRevue = abonnement.IdRevue
            };
            return JsonConvert.SerializeObject(obj, new CustomDateTimeConverter());
        }

        /// <summary>
        /// Sérialise une <see cref="CommandeDocument"/> en JSON pour l'API PHP (insertion).
        /// </summary>
        /// <param name="commande">Commande à sérialiser.</param>
        /// <returns>Chaîne JSON des champs attendus par l'API.</returns>
        private String CommandeDocumentToChampsJson(CommandeDocument commande)
        {
            var obj = new
            {
                dateCommande = commande.DateCommande,
                montant = commande.Montant,
                nbExemplaire = commande.NbExemplaire,
                idLivreDvd = commande.IdLivreDvd,
                idSuivi = commande.IdSuivi
            };
            return JsonConvert.SerializeObject(obj, new CustomDateTimeConverter());
        }

        /// <summary>
        /// Écriture d'une revue en base de données
        /// </summary>
        /// <param name="revue">Revue à insérer</param>
        /// <returns>true si l'insertion a pu se faire</returns>
        public bool CreerRevue(Revue revue)
        {
            String jsonRevue = RevueToChampsJson(revue);
            try
            {
                String parametres = CHAMPS + Uri.EscapeDataString(jsonRevue);
                return TraitementEcrire(POST, "revue", parametres);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur CreerRevue : {Message}", ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Modification d'une revue en base de données
        /// </summary>
        /// <param name="revue">Revue à modifier</param>
        /// <returns>true si la modification a pu se faire</returns>
        public bool ModifierRevue(Revue revue)
        {
            String jsonRevue = RevueToChampsJson(revue);
            try
            {
                String parametres = CHAMPS + Uri.EscapeDataString(jsonRevue);
                return TraitementEcrire(PUT, "revue/" + Uri.EscapeDataString(revue.Id), parametres);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur ModifierRevue : {Message}", ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Sérialise une <see cref="Revue"/> en JSON avec les noms de champs attendus par l'API PHP.
        /// </summary>
        /// <param name="revue">Revue à sérialiser.</param>
        /// <returns>Chaîne JSON des champs.</returns>
        private String RevueToChampsJson(Revue revue)
        {
            var obj = new
            {
                id = revue.Id,
                titre = revue.Titre,
                image = revue.Image,
                idRayon = revue.IdRayon,
                idPublic = revue.IdPublic,
                idGenre = revue.IdGenre,
                periodicite = revue.Periodicite,
                delaiMiseADispo = revue.DelaiMiseADispo
            };
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// Écriture d'un DVD en base de données
        /// </summary>
        /// <param name="dvd">DVD à insérer</param>
        /// <returns>true si l'insertion a pu se faire</returns>
        public bool CreerDvd(Dvd dvd)
        {
            String jsonDvd = DvdToChampsJson(dvd);
            try
            {
                String parametres = CHAMPS + Uri.EscapeDataString(jsonDvd);
                return TraitementEcrire(POST, "dvd", parametres);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur CreerDvd : {Message}", ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Modification d'un DVD en base de données
        /// </summary>
        /// <param name="dvd">DVD à modifier</param>
        /// <returns>true si la modification a pu se faire</returns>
        public bool ModifierDvd(Dvd dvd)
        {
            String jsonDvd = DvdToChampsJson(dvd);
            try
            {
                String parametres = CHAMPS + Uri.EscapeDataString(jsonDvd);
                return TraitementEcrire(PUT, "dvd/" + Uri.EscapeDataString(dvd.Id), parametres);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur ModifierDvd : {Message}", ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Sérialise un <see cref="Dvd"/> en JSON avec les noms de champs attendus par l'API PHP.
        /// </summary>
        /// <param name="dvd">DVD à sérialiser.</param>
        /// <returns>Chaîne JSON des champs.</returns>
        private String DvdToChampsJson(Dvd dvd)
        {
            var obj = new
            {
                id = dvd.Id,
                titre = dvd.Titre,
                image = dvd.Image,
                idRayon = dvd.IdRayon,
                idPublic = dvd.IdPublic,
                idGenre = dvd.IdGenre,
                duree = dvd.Duree,
                realisateur = dvd.Realisateur,
                synopsis = dvd.Synopsis
            };
            return JsonConvert.SerializeObject(obj);
        }

        /// <summary>
        /// Écriture d'un livre en base de données
        /// </summary>
        /// <param name="livre">Livre à insérer</param>
        /// <returns>true si l'insertion a pu se faire</returns>
        public bool CreerLivre(Livre livre)
        {
            String jsonLivre = LivreToChampsJson(livre);
            try
            {
                String parametres = CHAMPS + Uri.EscapeDataString(jsonLivre);
                return TraitementEcrire(POST, "livre", parametres);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur CreerLivre : {Message}", ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Modification d'un livre en base de données
        /// </summary>
        /// <param name="livre">Livre à modifier</param>
        /// <returns>true si la modification a pu se faire (code==200 et result>0)</returns>
        public bool ModifierLivre(Livre livre)
        {
            String jsonLivre = LivreToChampsJson(livre);
            try
            {
                String parametres = CHAMPS + Uri.EscapeDataString(jsonLivre);
                return TraitementEcrire(PUT, "livre/" + Uri.EscapeDataString(livre.Id), parametres);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur ModifierLivre : {Message}", ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Résultat d'une tentative de suppression (pour adapter les messages utilisateur).
        /// </summary>
        public enum ResultatSuppression
        {
            /// <summary>
            /// Erreur technique ou réponse API inattendue.
            /// </summary>
            Erreur = -1,
            /// <summary>
            /// Refus métier : aucune ligne supprimée (<c>result</c> nul).
            /// </summary>
            RefuseCommande = 0,
            /// <summary>
            /// Au moins une ligne a été supprimée.
            /// </summary>
            Succes = 1
        }

        /// <summary>
        /// Supprime une revue en base de données
        /// </summary>
        /// <param name="id">Id de la revue à supprimer</param>
        /// <returns>ResultatSuppression : Succes, RefuseCommande (règle métier), ou Erreur</returns>
        public ResultatSuppression SupprimerRevue(string id)
        {
            try
            {
                String jsonChamps = convertToJson("id", id);
                String message = "revue/" + Uri.EscapeDataString(jsonChamps);
                return TraitementSupprimer(DELETE, message);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur SupprimerRevue : {Message}", ex.Message);
                return ResultatSuppression.Erreur;
            }
        }

        /// <summary>
        /// Supprime un DVD en base de données
        /// </summary>
        /// <param name="id">Id du DVD à supprimer</param>
        /// <returns>ResultatSuppression : Succes, RefuseCommande (règle métier), ou Erreur</returns>
        public ResultatSuppression SupprimerDvd(string id)
        {
            try
            {
                String jsonChamps = convertToJson("id", id);
                String message = "dvd/" + Uri.EscapeDataString(jsonChamps);
                return TraitementSupprimer(DELETE, message);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur SupprimerDvd : {Message}", ex.Message);
                return ResultatSuppression.Erreur;
            }
        }

        /// <summary>
        /// Supprime un livre en base de données
        /// </summary>
        /// <param name="id">Id du livre à supprimer</param>
        /// <returns>ResultatSuppression : Succes, RefuseCommande (règle métier), ou Erreur</returns>
        public ResultatSuppression SupprimerLivre(string id)
        {
            try
            {
                String jsonChamps = convertToJson("id", id);
                String message = "livre/" + Uri.EscapeDataString(jsonChamps);
                return TraitementSupprimer(DELETE, message);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur SupprimerLivre : {Message}", ex.Message);
                return ResultatSuppression.Erreur;
            }
        }

        /// <summary>
        /// Supprime un exemplaire en base de données (clé composite : id + numero).
        /// </summary>
        /// <param name="idDocument">Id du document (livre, DVD ou revue)</param>
        /// <param name="numero">Numéro de l'exemplaire</param>
        /// <returns>ResultatSuppression : Succes, RefuseCommande, ou Erreur</returns>
        public ResultatSuppression SupprimerExemplaire(string idDocument, int numero)
        {
            try
            {
                var obj = new { id = idDocument, numero = numero };
                String jsonChamps = JsonConvert.SerializeObject(obj);
                String message = "exemplaire/" + Uri.EscapeDataString(jsonChamps);
                return TraitementSupprimer(DELETE, message);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur SupprimerExemplaire : {Message}", ex.Message);
                return ResultatSuppression.Erreur;
            }
        }

        /// <summary>
        /// Traite une requête DELETE et interprète la réponse : succès, refus métier (<c>result</c> nul) ou erreur.
        /// </summary>
        /// <param name="methode">Verbe HTTP (attendu : DELETE).</param>
        /// <param name="message">Chemin relatif et paramètres d'URL.</param>
        /// <returns>Statut de la suppression.</returns>
        private ResultatSuppression TraitementSupprimer(String methode, String message)
        {
            try
            {
                JObject retour = api.RecupDistant(methode, message, null);
                var codeToken = retour["code"];
                if (codeToken == null) return ResultatSuppression.Erreur;
                int codeValue;
                if (!int.TryParse(codeToken.ToString(), System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out codeValue) || codeValue != 200)
                {
                    Log.Error("TraitementSupprimer - code erreur = {Code} message = {Message}", codeToken?.ToString(), retour["message"]?.ToString());
                    return ResultatSuppression.Erreur;
                }
                var resultToken = retour["result"];
                if (resultToken == null) return ResultatSuppression.Erreur;
                double resultValue;
                if (!double.TryParse(resultToken.ToString(), System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out resultValue))
                    return ResultatSuppression.Erreur;
                return resultValue > 0 ? ResultatSuppression.Succes : ResultatSuppression.RefuseCommande;
            }
            catch (Exception e)
            {
                Log.Error(e, "Erreur lors de l'accès à l'API (TraitementSupprimer) : {Message}", e.Message);
                return ResultatSuppression.Erreur;
            }
        }

        /// <summary>
        /// Sérialise un <see cref="Livre"/> en JSON avec les noms de champs attendus par l'API PHP.
        /// </summary>
        /// <param name="livre">Livre à sérialiser.</param>
        /// <returns>Chaîne JSON des champs.</returns>
        private String LivreToChampsJson(Livre livre)
        {
            var obj = new
            {
                id = livre.Id,
                titre = livre.Titre,
                image = livre.Image,
                idRayon = livre.IdRayon,
                idPublic = livre.IdPublic,
                idGenre = livre.IdGenre,
                ISBN = livre.Isbn,
                auteur = livre.Auteur,
                collection = livre.Collection
            };
            return JsonConvert.SerializeObject(obj, new CustomDateTimeConverter());
        }

        /// <summary>
        /// Traite une écriture POST ou PUT : succès si le code HTTP retourné par l'API est 200 et <c>result</c> &gt; 0.
        /// </summary>
        /// <param name="methode">Verbe HTTP (POST ou PUT).</param>
        /// <param name="message">Chemin relatif de la ressource.</param>
        /// <param name="parametres">Corps de la requête (souvent préfixé par <c>champs=</c>).</param>
        /// <returns><c>true</c> si l'opération a réussi selon les critères de l'API.</returns>
        private bool TraitementEcrire(String methode, String message, String parametres)
        {
            try
            {
                JObject retour = api.RecupDistant(methode, message, parametres);
                var codeToken = retour["code"];
                if (codeToken == null) return false;
                int codeValue;
                if (!int.TryParse(codeToken.ToString(), System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture, out codeValue) || codeValue != 200)
                {
                    Log.Error("TraitementEcrire - code erreur = {Code} message = {Message}", codeToken?.ToString(), retour["message"]?.ToString());
                    return false;
                }
                var resultToken = retour["result"];
                if (resultToken == null) return false;
                double resultValue;
                if (!double.TryParse(resultToken.ToString(), System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out resultValue))
                    return false;
                return resultValue > 0;
            }
            catch (Exception e)
            {
                Log.Error(e, "Erreur lors de l'accès à l'API (TraitementEcrire) : {Message}", e.Message);
                return false;
            }
        }

        /// <summary>
        /// ecriture d'un exemplaire en base de données
        /// </summary>
        /// <param name="exemplaire">exemplaire à insérer</param>
        /// <returns>true si l'insertion a pu se faire (retour != null)</returns>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            String jsonExemplaire = JsonConvert.SerializeObject(exemplaire, new CustomDateTimeConverter());
            try
            {
                List<Exemplaire> liste = TraitementRecup<Exemplaire>(POST, "exemplaire", CHAMPS + jsonExemplaire);
                return (liste != null);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Erreur CreerExemplaire : {Message}", ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Appelle l'API et désérialise le résultat en liste d'objets pour les requêtes GET réussies (code 200).
        /// </summary>
        /// <typeparam name="T">Type des éléments attendus dans <c>result</c>.</typeparam>
        /// <param name="methode">Verbe HTTP (GET, POST, PUT ou DELETE).</param>
        /// <param name="message">Segment d'URL et filtres.</param>
        /// <param name="parametres">Corps de la requête pour POST/PUT, ou <c>null</c>.</param>
        /// <returns>Liste d'objets ; liste vide en cas d'échec ou d'absence de données.</returns>
        private List<T> TraitementRecup<T> (String methode, String message, String parametres)
        {
            List<T> liste = new List<T>();
            try
            {
                JObject retour = api.RecupDistant(methode, message, parametres);
                // extraction du code retourné
                String code = (String)retour["code"];
                if (code.Equals("200"))
                {
                    // dans le cas du GET (select), récupération de la liste d'objets
                    if (methode.Equals(GET))
                    {
                        String resultString = JsonConvert.SerializeObject(retour["result"]);
                        // construction de la liste d'objets à partir du retour de l'api
                        liste = JsonConvert.DeserializeObject<List<T>>(resultString, new CustomBooleanJsonConverter());
                    }
                }
                else
                {
                    Log.Error("TraitementRecup - code erreur = {Code} message = {Message}", code, (String)retour["message"]);
                }
            }catch(Exception e)
            {
                Log.Error(e, "Erreur lors de l'accès à l'API (TraitementRecup) : {Message}", e.Message);
                Environment.Exit(0);
            }
            return liste;
        }

        /// <summary>
        /// Construit un objet JSON à une propriété (nom/valeur) pour les filtres d'URL.
        /// </summary>
        /// <param name="nom">Nom de la propriété JSON.</param>
        /// <param name="valeur">Valeur associée.</param>
        /// <returns>Chaîne JSON représentant l'objet.</returns>
        private static String convertToJson(Object nom, Object valeur)
        {
            Dictionary<Object, Object> dictionary = new Dictionary<Object, Object>();
            dictionary.Add(nom, valeur);
            return JsonConvert.SerializeObject(dictionary);
        }

        /// <summary>
        /// Convertisseur JSON pour sérialiser les dates au format <c>yyyy-MM-dd</c> attendu par l'API.
        /// </summary>
        private sealed class CustomDateTimeConverter : IsoDateTimeConverter
        {
            /// <summary>
            /// Initialise le convertisseur avec le format de date court ISO.
            /// </summary>
            public CustomDateTimeConverter()
            {
                base.DateTimeFormat = "yyyy-MM-dd";
            }
        }

        /// <summary>
        /// Convertisseur JSON pour accepter les booléens renvoyés sous forme de chaîne ou de nombre par l'API.
        /// Voir : https://www.thecodebuzz.com/newtonsoft-jsonreaderexception-could-not-convert-string-to-boolean/
        /// </summary>
        private sealed class CustomBooleanJsonConverter : JsonConverter<bool>
        {
            /// <summary>
            /// Lit une valeur JSON et la convertit en booléen.
            /// </summary>
            /// <param name="reader">Lecteur JSON.</param>
            /// <param name="objectType">Type cible.</param>
            /// <param name="existingValue">Valeur existante.</param>
            /// <param name="hasExistingValue">Indique si une valeur existe déjà.</param>
            /// <param name="serializer">Sérialiseur appelant.</param>
            /// <returns>Valeur booléenne interprétée.</returns>
            public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                return Convert.ToBoolean(reader.ValueType == typeof(string) ? Convert.ToByte(reader.Value) : reader.Value);
            }

            /// <summary>
            /// Écrit une valeur booléenne en JSON.
            /// </summary>
            /// <param name="writer">Écrivain JSON.</param>
            /// <param name="value">Valeur à écrire.</param>
            /// <param name="serializer">Sérialiseur appelant.</param>
            public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }
        }

    }
}
