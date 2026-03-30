
namespace MediaTekDocuments.model
{
    /// <summary>
    /// Classe de base abstraite pour les documents de type livre ou DVD, dérivée de <see cref="Document"/>.
    /// </summary>
    public abstract class LivreDvd : Document
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="LivreDvd"/> avec les données communes d'un document.
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
        protected LivreDvd(string id, string titre, string image, string idGenre, string genre,
            string idPublic, string lePublic, string idRayon, string rayon)
            : base(id, titre, image, idGenre, genre, idPublic, lePublic, idRayon, rayon)
        {
        }

    }
}
