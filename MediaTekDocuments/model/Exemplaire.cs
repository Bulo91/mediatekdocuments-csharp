using System;

namespace MediaTekDocuments.model
{
    /// <summary>
    /// Représente un exemplaire physique d'un document (notamment d'une revue) : numéro de parution, état, date d'achat.
    /// </summary>
    public class Exemplaire
    {
        /// <summary>
        /// Obtient ou définit le numéro de parution ou de l'exemplaire.
        /// </summary>
        public int Numero { get; set; }
        /// <summary>
        /// Obtient ou définit le chemin de la photo associée à l'exemplaire.
        /// </summary>
        public string Photo { get; set; }
        /// <summary>
        /// Obtient ou définit la date d'achat ou de réception.
        /// </summary>
        public DateTime DateAchat { get; set; }
        /// <summary>
        /// Obtient ou définit l'identifiant de l'état d'usure.
        /// </summary>
        public string IdEtat { get; set; }
        /// <summary>
        /// Obtient ou définit l'identifiant du document auquel l'exemplaire est rattaché.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Obtient ou définit le libellé de l'état (affichage).
        /// </summary>
        public string LibelleEtat { get; set; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Exemplaire"/>.
        /// </summary>
        /// <param name="numero">Numéro de l'exemplaire.</param>
        /// <param name="dateAchat">Date d'achat ou de réception.</param>
        /// <param name="photo">Chemin de la photo.</param>
        /// <param name="idEtat">Identifiant de l'état.</param>
        /// <param name="idDocument">Identifiant du document parent.</param>
        public Exemplaire(int numero, DateTime dateAchat, string photo, string idEtat, string idDocument)
        {
            this.Numero = numero;
            this.DateAchat = dateAchat;
            this.Photo = photo;
            this.IdEtat = idEtat;
            this.Id = idDocument;
        }

    }
}
