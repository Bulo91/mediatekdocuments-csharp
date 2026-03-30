
namespace MediaTekDocuments.model
{
    /// <summary>
    /// Représente un document média : propriétés communes aux livres, aux DVD et aux revues.
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Obtient l'identifiant unique du document.
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// Obtient le titre du document.
        /// </summary>
        public string Titre { get; }
        /// <summary>
        /// Obtient le chemin ou l'URL de l'image de couverture.
        /// </summary>
        public string Image { get; }
        /// <summary>
        /// Obtient l'identifiant du genre.
        /// </summary>
        public string IdGenre { get; }
        /// <summary>
        /// Obtient le libellé du genre.
        /// </summary>
        public string Genre { get; }
        /// <summary>
        /// Obtient l'identifiant du public cible.
        /// </summary>
        public string IdPublic { get; }
        /// <summary>
        /// Obtient le libellé du public cible.
        /// </summary>
        public string Public { get; }
        /// <summary>
        /// Obtient l'identifiant du rayon de classement.
        /// </summary>
        public string IdRayon { get; }
        /// <summary>
        /// Obtient le libellé du rayon de classement.
        /// </summary>
        public string Rayon { get; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Document"/> avec les informations communes.
        /// </summary>
        /// <param name="id">Identifiant du document.</param>
        /// <param name="titre">Titre du document.</param>
        /// <param name="image">Chemin ou URL de l'image.</param>
        /// <param name="idGenre">Identifiant du genre.</param>
        /// <param name="genre">Libellé du genre.</param>
        /// <param name="idPublic">Identifiant du public.</param>
        /// <param name="lePublic">Libellé du public.</param>
        /// <param name="idRayon">Identifiant du rayon.</param>
        /// <param name="rayon">Libellé du rayon.</param>
        public Document(string id, string titre, string image, string idGenre, string genre, string idPublic, string lePublic, string idRayon, string rayon)
        {
            Id = id;
            Titre = titre;
            Image = image;
            IdGenre = idGenre;
            Genre = genre;
            IdPublic = idPublic;
            Public = lePublic;
            IdRayon = idRayon;
            Rayon = rayon;
        }
    }
}
