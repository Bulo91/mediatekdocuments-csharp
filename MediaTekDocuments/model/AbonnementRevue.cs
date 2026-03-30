using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Représente un abonnement ou une commande liée à une revue (montant et dates de validité).
    /// </summary>
    public class AbonnementRevue
    {
        /// <summary>
        /// Obtient ou définit l'identifiant de la commande d'abonnement.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Obtient ou définit la date de commande.
        /// </summary>
        public DateTime DateCommande { get; set; }
        /// <summary>
        /// Obtient ou définit le montant de l'abonnement.
        /// </summary>
        public double Montant { get; set; }
        /// <summary>
        /// Obtient ou définit la date de fin d'abonnement.
        /// </summary>
        public DateTime DateFinAbonnement { get; set; }

        /// <summary>
        /// Obtient ou définit l'identifiant de la revue concernée.
        /// </summary>
        public string IdRevue { get; set; }

        /// <summary>
        /// Initialise une instance vide pour la lecture ou la liaison de données.
        /// </summary>
        public AbonnementRevue() { }

        /// <summary>
        /// Initialise un nouvel abonnement de revue à enregistrer.
        /// </summary>
        /// <param name="dateCommande">Date de la commande.</param>
        /// <param name="montant">Montant payé.</param>
        /// <param name="dateFinAbonnement">Date de fin d'abonnement.</param>
        /// <param name="idRevue">Identifiant de la revue.</param>
        public AbonnementRevue(DateTime dateCommande, double montant, DateTime dateFinAbonnement, string idRevue)
        {
            DateCommande = dateCommande;
            Montant = montant;
            DateFinAbonnement = dateFinAbonnement;
            IdRevue = idRevue;
        }
    }
}
