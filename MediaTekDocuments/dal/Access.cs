using System;
using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.manager;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Configuration;
using System.Linq;

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
        private static readonly string uriApi = "http://localhost/rest_mediatekdocuments/";
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
        /// Méthode privée pour créer un singleton
        /// initialise l'accès à l'API
        /// </summary>
        private Access()
        {
            String authenticationString;
            try
            {
                authenticationString = "admin:adminpwd";
                api = ApiRest.GetInstance(uriApi, authenticationString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
            String jsonIdDocument = convertToJson("id", idDocument);
            List<Exemplaire> lesExemplaires = TraitementRecup<Exemplaire>(GET, "exemplaire/" + jsonIdDocument, null);
            return lesExemplaires;
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
                String parametres = "champs=" + Uri.EscapeDataString(jsonChamps);
                return TraitementEcrire(POST, "commandedocument", parametres);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                String parametres = "champs=" + Uri.EscapeDataString(jsonChamps);
                return TraitementEcrire(PUT, "commandedocument/" + Uri.EscapeDataString(idCommande), parametres);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
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
                String parametres = "champs=" + Uri.EscapeDataString(jsonChamps);
                return TraitementEcrire(POST, "commandesrevue", parametres);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
                return ResultatSuppression.Erreur;
            }
        }

        /// <summary>
        /// Sérialise une AbonnementRevue en JSON pour l'API PHP (insertion)
        /// </summary>
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
        /// Sérialise une CommandeDocument en JSON pour l'API PHP (insertion)
        /// </summary>
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
                String parametres = "champs=" + Uri.EscapeDataString(jsonRevue);
                return TraitementEcrire(POST, "revue", parametres);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                String parametres = "champs=" + Uri.EscapeDataString(jsonRevue);
                return TraitementEcrire(PUT, "revue/" + Uri.EscapeDataString(revue.Id), parametres);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Sérialise une Revue en JSON avec les noms de champs attendus par l'API PHP
        /// </summary>
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
                String parametres = "champs=" + Uri.EscapeDataString(jsonDvd);
                return TraitementEcrire(POST, "dvd", parametres);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                String parametres = "champs=" + Uri.EscapeDataString(jsonDvd);
                return TraitementEcrire(PUT, "dvd/" + Uri.EscapeDataString(dvd.Id), parametres);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Sérialise un Dvd en JSON avec les noms de champs attendus par l'API PHP
        /// </summary>
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
                String parametres = "champs=" + Uri.EscapeDataString(jsonLivre);
                return TraitementEcrire(POST, "livre", parametres);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
                String parametres = "champs=" + Uri.EscapeDataString(jsonLivre);
                return TraitementEcrire(PUT, "livre/" + Uri.EscapeDataString(livre.Id), parametres);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Résultat d'une tentative de suppression (pour messages utilisateur différenciés)
        /// </summary>
        public enum ResultatSuppression
        {
            Erreur = -1,
            RefuseCommande = 0,
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
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
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
                Console.WriteLine(ex.Message);
                return ResultatSuppression.Erreur;
            }
        }

        /// <summary>
        /// Traitement du DELETE - retourne le statut pour différencier succès, refus métier et erreur
        /// code=200 et result>0 => Succes ; code=200 et result=0 => RefuseCommande ; sinon => Erreur
        /// </summary>
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
                    Console.WriteLine("code erreur = " + codeToken?.ToString() + " message = " + retour["message"]?.ToString());
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
                Console.WriteLine("Erreur lors de l'accès à l'API : " + e.Message);
                return ResultatSuppression.Erreur;
            }
        }

        /// <summary>
        /// Sérialise un Livre en JSON avec les noms de champs attendus par l'API PHP
        /// </summary>
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
        /// Traitement de l'écriture (POST/PUT) - succès si code==200 et result>0 (guide CNED règle 9)
        /// </summary>
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
                    Console.WriteLine("code erreur = " + codeToken?.ToString() + " message = " + retour["message"]?.ToString());
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
                Console.WriteLine("Erreur lors de l'accès à l'API : " + e.Message);
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
                List<Exemplaire> liste = TraitementRecup<Exemplaire>(POST, "exemplaire", "champs=" + jsonExemplaire);
                return (liste != null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Traitement de la récupération du retour de l'api, avec conversion du json en liste pour les select (GET)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="methode">verbe HTTP (GET, POST, PUT, DELETE)</param>
        /// <param name="message">information envoyée dans l'url</param>
        /// <param name="parametres">paramètres à envoyer dans le body, au format "chp1=val1&chp2=val2&..."</param>
        /// <returns>liste d'objets récupérés (ou liste vide)</returns>
        private List<T> TraitementRecup<T> (String methode, String message, String parametres)
        {
            // trans
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
                    Console.WriteLine("code erreur = " + code + " message = " + (String)retour["message"]);
                }
            }catch(Exception e)
            {
                Console.WriteLine("Erreur lors de l'accès à l'API : "+e.Message);
                Environment.Exit(0);
            }
            return liste;
        }

        /// <summary>
        /// Convertit en json un couple nom/valeur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="valeur"></param>
        /// <returns>couple au format json</returns>
        private String convertToJson(Object nom, Object valeur)
        {
            Dictionary<Object, Object> dictionary = new Dictionary<Object, Object>();
            dictionary.Add(nom, valeur);
            return JsonConvert.SerializeObject(dictionary);
        }

        /// <summary>
        /// Modification du convertisseur Json pour gérer le format de date
        /// </summary>
        private sealed class CustomDateTimeConverter : IsoDateTimeConverter
        {
            public CustomDateTimeConverter()
            {
                base.DateTimeFormat = "yyyy-MM-dd";
            }
        }

        /// <summary>
        /// Modification du convertisseur Json pour prendre en compte les booléens
        /// classe trouvée sur le site :
        /// https://www.thecodebuzz.com/newtonsoft-jsonreaderexception-could-not-convert-string-to-boolean/
        /// </summary>
        private sealed class CustomBooleanJsonConverter : JsonConverter<bool>
        {
            public override bool ReadJson(JsonReader reader, Type objectType, bool existingValue, bool hasExistingValue, JsonSerializer serializer)
            {
                return Convert.ToBoolean(reader.ValueType == typeof(string) ? Convert.ToByte(reader.Value) : reader.Value);
            }

            public override void WriteJson(JsonWriter writer, bool value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }
        }

    }
}
