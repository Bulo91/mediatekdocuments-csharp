using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier AbonnementRevue (commande / abonnement d'une revue)
    /// </summary>
    public class AbonnementRevue
    {
        public string Id { get; set; }
        public DateTime DateCommande { get; set; }
        public double Montant { get; set; }
        public DateTime DateFinAbonnement { get; set; }

        /// <summary>
        /// Id de la revue (document) concernée
        /// </summary>
        public string IdRevue { get; set; }

        /// <summary>
        /// Constructeur pour l'affichage (lecture)
        /// </summary>
        public AbonnementRevue() { }

        /// <summary>
        /// Constructeur pour l'ajout d'un abonnement
        /// </summary>
        public AbonnementRevue(DateTime dateCommande, double montant, DateTime dateFinAbonnement, string idRevue)
        {
            DateCommande = dateCommande;
            Montant = montant;
            DateFinAbonnement = dateFinAbonnement;
            IdRevue = idRevue;
        }
    }
}
