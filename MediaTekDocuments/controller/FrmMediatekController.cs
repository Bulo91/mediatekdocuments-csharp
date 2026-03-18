using System.Collections.Generic;
using MediaTekDocuments.model;
using MediaTekDocuments.dal;

namespace MediaTekDocuments.controller
{
    /// <summary>
    /// Contrôleur lié à FrmMediatek
    /// </summary>
    class FrmMediatekController
    {
        /// <summary>
        /// Objet d'accès aux données
        /// </summary>
        private readonly Access access;

        /// <summary>
        /// Récupération de l'instance unique d'accès aux données
        /// </summary>
        public FrmMediatekController()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// getter sur la liste des genres
        /// </summary>
        /// <returns>Liste d'objets Genre</returns>
        public List<Categorie> GetAllGenres()
        {
            return access.GetAllGenres();
        }

        /// <summary>
        /// getter sur la liste des livres
        /// </summary>
        /// <returns>Liste d'objets Livre</returns>
        public List<Livre> GetAllLivres()
        {
            return access.GetAllLivres();
        }

        /// <summary>
        /// getter sur la liste des Dvd
        /// </summary>
        /// <returns>Liste d'objets dvd</returns>
        public List<Dvd> GetAllDvd()
        {
            return access.GetAllDvd();
        }

        /// <summary>
        /// getter sur la liste des revues
        /// </summary>
        /// <returns>Liste d'objets Revue</returns>
        public List<Revue> GetAllRevues()
        {
            return access.GetAllRevues();
        }

        /// <summary>
        /// getter sur les rayons
        /// </summary>
        /// <returns>Liste d'objets Rayon</returns>
        public List<Categorie> GetAllRayons()
        {
            return access.GetAllRayons();
        }

        /// <summary>
        /// getter sur les publics
        /// </summary>
        /// <returns>Liste d'objets Public</returns>
        public List<Categorie> GetAllPublics()
        {
            return access.GetAllPublics();
        }


        /// <summary>
        /// récupère les exemplaires d'une revue
        /// </summary>
        /// <param name="idDocuement">id de la revue concernée</param>
        /// <returns>Liste d'objets Exemplaire</returns>
        public List<Exemplaire> GetExemplairesRevue(string idDocuement)
        {
            return access.GetExemplairesRevue(idDocuement);
        }

        /// <summary>
        /// Récupère les commandes d'un document (livre ou DVD)
        /// </summary>
        /// <param name="idLivreDvd">id du livre ou DVD concerné</param>
        /// <returns>Liste de CommandeDocument triée par date DESC</returns>
        public List<CommandeDocument> GetCommandesDocument(string idLivreDvd)
        {
            return access.GetCommandesDocument(idLivreDvd);
        }

        /// <summary>
        /// Crée une commande de document (livre ou DVD)
        /// </summary>
        /// <param name="commande">Commande à créer</param>
        /// <returns>true si la création a pu se faire</returns>
        public bool CreerCommandeDocument(CommandeDocument commande)
        {
            return access.CreerCommandeDocument(commande);
        }

        /// <summary>
        /// Modifie le suivi d'une commande document
        /// </summary>
        /// <param name="idCommande">Id de la commande</param>
        /// <param name="idSuivi">Nouveau suivi (00001, 00002, 00003, 00004)</param>
        /// <returns>true si la modification a pu se faire</returns>
        public bool ModifierSuiviCommandeDocument(string idCommande, string idSuivi)
        {
            return access.ModifierSuiviCommandeDocument(idCommande, idSuivi);
        }

        /// <summary>
        /// Supprime une commande document (uniquement si suivi = en cours ou relancée).
        /// </summary>
        /// <param name="idCommande">Id de la commande à supprimer</param>
        /// <returns>ResultatSuppression : Succes, RefuseCommande (livrée/réglée), ou Erreur</returns>
        public Access.ResultatSuppression SupprimerCommandeDocument(string idCommande)
        {
            return access.SupprimerCommandeDocument(idCommande);
        }

        /// <summary>
        /// Récupère les commandes / abonnements d'une revue
        /// </summary>
        /// <param name="idRevue">id de la revue concernée</param>
        /// <returns>Liste d'AbonnementRevue</returns>
        public List<AbonnementRevue> GetCommandesRevue(string idRevue)
        {
            return access.GetCommandesRevue(idRevue);
        }

        /// <summary>
        /// Revues dont l'abonnement expire dans les 30 prochains jours.
        /// </summary>
        public List<AlerteAbonnementRevue> GetAbonnementsRevuesFinProche()
        {
            return access.GetAbonnementsRevuesFinProche();
        }

        /// <summary>
        /// Crée une commande / abonnement de revue
        /// </summary>
        /// <param name="abonnement">Abonnement à créer</param>
        /// <returns>true si la création a pu se faire</returns>
        public bool CreerCommandeRevue(AbonnementRevue abonnement)
        {
            return access.CreerCommandeRevue(abonnement);
        }

        /// <summary>
        /// Supprime une commande / abonnement de revue
        /// </summary>
        /// <param name="idCommande">Id de la commande à supprimer</param>
        /// <returns>ResultatSuppression : Succes, RefuseCommande, ou Erreur</returns>
        public Access.ResultatSuppression SupprimerCommandeRevue(string idCommande)
        {
            return access.SupprimerCommandeRevue(idCommande);
        }

        /// <summary>
        /// Crée un exemplaire d'une revue dans la bdd
        /// </summary>
        /// <param name="exemplaire">L'objet Exemplaire concerné</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerExemplaire(Exemplaire exemplaire)
        {
            return access.CreerExemplaire(exemplaire);
        }

        /// <summary>
        /// Crée une revue dans la bdd
        /// </summary>
        /// <param name="revue">L'objet Revue à créer</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerRevue(Revue revue)
        {
            return access.CreerRevue(revue);
        }

        /// <summary>
        /// Modifie une revue dans la bdd
        /// </summary>
        /// <param name="revue">L'objet Revue à modifier</param>
        /// <returns>True si la modification a pu se faire</returns>
        public bool ModifierRevue(Revue revue)
        {
            return access.ModifierRevue(revue);
        }

        /// <summary>
        /// Supprime une revue dans la bdd
        /// </summary>
        /// <param name="id">Id de la revue à supprimer</param>
        /// <returns>ResultatSuppression : Succes, RefuseCommande, ou Erreur</returns>
        public Access.ResultatSuppression SupprimerRevue(string id)
        {
            return access.SupprimerRevue(id);
        }

        /// <summary>
        /// Crée un DVD dans la bdd
        /// </summary>
        /// <param name="dvd">L'objet Dvd à créer</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerDvd(Dvd dvd)
        {
            return access.CreerDvd(dvd);
        }

        /// <summary>
        /// Modifie un DVD dans la bdd
        /// </summary>
        /// <param name="dvd">L'objet Dvd à modifier</param>
        /// <returns>True si la modification a pu se faire</returns>
        public bool ModifierDvd(Dvd dvd)
        {
            return access.ModifierDvd(dvd);
        }

        /// <summary>
        /// Supprime un DVD dans la bdd
        /// </summary>
        /// <param name="id">Id du DVD à supprimer</param>
        /// <returns>ResultatSuppression : Succes, RefuseCommande, ou Erreur</returns>
        public Access.ResultatSuppression SupprimerDvd(string id)
        {
            return access.SupprimerDvd(id);
        }

        /// <summary>
        /// Crée un livre dans la bdd
        /// </summary>
        /// <param name="livre">L'objet Livre à créer</param>
        /// <returns>True si la création a pu se faire</returns>
        public bool CreerLivre(Livre livre)
        {
            return access.CreerLivre(livre);
        }

        /// <summary>
        /// Modifie un livre dans la bdd
        /// </summary>
        /// <param name="livre">L'objet Livre à modifier</param>
        /// <returns>True si la modification a pu se faire</returns>
        public bool ModifierLivre(Livre livre)
        {
            return access.ModifierLivre(livre);
        }

        /// <summary>
        /// Supprime un livre dans la bdd
        /// </summary>
        /// <param name="id">Id du livre à supprimer</param>
        /// <returns>ResultatSuppression : Succes, RefuseCommande, ou Erreur</returns>
        public Access.ResultatSuppression SupprimerLivre(string id)
        {
            return access.SupprimerLivre(id);
        }

    }
}
