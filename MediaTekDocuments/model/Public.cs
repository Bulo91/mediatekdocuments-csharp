
namespace MediaTekDocuments.model
{
    /// <summary>
    /// Représente un public cible (tranche d'âge ou type de lecteur), dérivé de <see cref="Categorie"/>.
    /// </summary>
    public class Public : Categorie
    {
        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Public"/>.
        /// </summary>
        /// <param name="id">Identifiant du public.</param>
        /// <param name="libelle">Libellé du public.</param>
        public Public(string id, string libelle) : base(id, libelle)
        {
        }

    }
}
