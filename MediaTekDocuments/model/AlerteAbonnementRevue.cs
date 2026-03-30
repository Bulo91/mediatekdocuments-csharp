using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Représente une alerte : revue dont l'abonnement se termine prochainement (données renvoyées par l'API).
    /// </summary>
    public class AlerteAbonnementRevue
    {
        /// <summary>
        /// Obtient ou définit le titre de la revue.
        /// </summary>
        public string Titre { get; set; }
        /// <summary>
        /// Obtient ou définit la date de fin d'abonnement.
        /// </summary>
        public DateTime DateFinAbonnement { get; set; }
    }
}
