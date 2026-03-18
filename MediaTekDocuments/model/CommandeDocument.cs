using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe métier CommandeDocument (commande d'un livre ou DVD)
    /// </summary>
    public class CommandeDocument
    {
        /// <summary>
        /// Id de la commande (table commande) - utilisé pour le PUT
        /// </summary>
        public string Id { get; set; }
        public DateTime DateCommande { get; set; }
        public double Montant { get; set; }
        public int NbExemplaire { get; set; }
        public string Suivi { get; set; }

        /// <summary>
        /// Constructeur pour l'affichage (lecture)
        /// </summary>
        public CommandeDocument() { }

        /// <summary>
        /// Constructeur pour l'ajout d'une commande
        /// </summary>
        public CommandeDocument(DateTime dateCommande, double montant, int nbExemplaire, string idLivreDvd, string idSuivi)
        {
            DateCommande = dateCommande;
            Montant = montant;
            NbExemplaire = nbExemplaire;
            IdLivreDvd = idLivreDvd;
            IdSuivi = idSuivi;
        }

        /// <summary>
        /// Id du livre ou DVD concerné (utilisé à l'insertion)
        /// </summary>
        public string IdLivreDvd { get; set; }

        /// <summary>
        /// Id du suivi (00001 = en cours)
        /// </summary>
        public string IdSuivi { get; set; }
    }
}
