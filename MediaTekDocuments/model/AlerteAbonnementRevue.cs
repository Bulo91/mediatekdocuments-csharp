using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Alerte : revue dont l'abonnement expire bientôt (retour API abonnementsrevuesfinproche).
    /// </summary>
    public class AlerteAbonnementRevue
    {
        public string Titre { get; set; }
        public DateTime DateFinAbonnement { get; set; }
    }
}
