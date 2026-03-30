using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Représente une commande de document (livre ou DVD) : montant, quantité et suivi de livraison.
    /// </summary>
    public class CommandeDocument
    {
        /// <summary>
        /// Obtient ou définit l'identifiant de la commande (clé primaire, utilisé pour les mises à jour).
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Obtient ou définit la date de la commande.
        /// </summary>
        public DateTime DateCommande { get; set; }
        /// <summary>
        /// Obtient ou définit le montant total de la commande.
        /// </summary>
        public double Montant { get; set; }
        /// <summary>
        /// Obtient ou définit le nombre d'exemplaires commandés.
        /// </summary>
        public int NbExemplaire { get; set; }
        /// <summary>
        /// Obtient ou définit le libellé du suivi (affichage).
        /// </summary>
        public string Suivi { get; set; }

        /// <summary>
        /// Initialise une instance vide pour la lecture ou la liaison de données.
        /// </summary>
        public CommandeDocument() { }

        /// <summary>
        /// Initialise une nouvelle commande de document (création côté application).
        /// </summary>
        /// <param name="dateCommande">Date de la commande.</param>
        /// <param name="montant">Montant total.</param>
        /// <param name="nbExemplaire">Nombre d'exemplaires.</param>
        /// <param name="idLivreDvd">Identifiant du livre ou du DVD concerné.</param>
        /// <param name="idSuivi">Code de suivi (ex. 00001 pour « en cours »).</param>
        public CommandeDocument(DateTime dateCommande, double montant, int nbExemplaire, string idLivreDvd, string idSuivi)
        {
            DateCommande = dateCommande;
            Montant = montant;
            NbExemplaire = nbExemplaire;
            IdLivreDvd = idLivreDvd;
            IdSuivi = idSuivi;
        }

        /// <summary>
        /// Obtient ou définit l'identifiant du livre ou du DVD concerné (insertion).
        /// </summary>
        public string IdLivreDvd { get; set; }

        /// <summary>
        /// Obtient ou définit l'identifiant du code de suivi (00001 à 00004 selon le métier).
        /// </summary>
        public string IdSuivi { get; set; }
    }
}
