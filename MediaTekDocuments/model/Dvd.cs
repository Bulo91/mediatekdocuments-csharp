
namespace MediaTekDocuments.model
{
    /// <summary>
    /// Représente un DVD : document de type <see cref="LivreDvd"/> avec durée, réalisateur et synopsis.
    /// </summary>
    public class Dvd : LivreDvd
    {
        /// <summary>
        /// Obtient la durée du film en minutes.
        /// </summary>
        public int Duree { get; }
        /// <summary>
        /// Obtient le nom du réalisateur.
        /// </summary>
        public string Realisateur { get; }
        /// <summary>
        /// Obtient le résumé (synopsis) du film.
        /// </summary>
        public string Synopsis { get; }

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Dvd"/>.
        /// </summary>
        /// <param name="id">Identifiant du DVD.</param>
        /// <param name="titre">Titre du DVD.</param>
        /// <param name="image">Chemin ou URL de l'image.</param>
        /// <param name="duree">Durée en minutes.</param>
        /// <param name="realisateur">Réalisateur.</param>
        /// <param name="synopsis">Synopsis.</param>
        /// <param name="idGenre">Identifiant du genre.</param>
        /// <param name="genre">Libellé du genre.</param>
        /// <param name="idPublic">Identifiant du public.</param>
        /// <param name="lePublic">Libellé du public.</param>
        /// <param name="idRayon">Identifiant du rayon.</param>
        /// <param name="rayon">Libellé du rayon.</param>
        public Dvd(string id, string titre, string image, int duree, string realisateur, string synopsis,
            string idGenre, string genre, string idPublic, string lePublic, string idRayon, string rayon)
            : base(id, titre, image, idGenre, genre, idPublic, lePublic, idRayon, rayon)
        {
            this.Duree = duree;
            this.Realisateur = realisateur;
            this.Synopsis = synopsis;
        }

    }
}
