using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocumentsTests.model
{
    /// <summary>
    /// Tests unitaires pour la classe métier <see cref="Dvd"/>.
    /// </summary>
    [TestClass]
    public class DvdTests
    {
        /// <summary>
        /// Vérifie que le constructeur initialise correctement les propriétés du DVD et héritées du document.
        /// </summary>
        [TestMethod]
        public void ConstructeurDvdTest()
        {
            // Arrange
            const string id = "DV1";
            const string titre = "Film";
            const string image = "film.jpg";
            const int duree = 120;
            const string realisateur = "Réalisateur";
            const string synopsis = "Synopsis";
            const string idGenre = "G1";
            const string genre = "Action";
            const string idPublic = "P1";
            const string lePublic = "Tout public";
            const string idRayon = "R1";
            const string rayon = "DVD";

            // Act
            Dvd dvd = new Dvd(id, titre, image, duree, realisateur, synopsis, idGenre, genre, idPublic, lePublic, idRayon, rayon);

            // Assert
            Assert.AreEqual(id, dvd.Id, "Id incorrect");
            Assert.AreEqual(titre, dvd.Titre, "Titre incorrect");
            Assert.AreEqual(image, dvd.Image, "Image incorrecte");
            Assert.AreEqual(idGenre, dvd.IdGenre, "IdGenre incorrect");
            Assert.AreEqual(genre, dvd.Genre, "Genre incorrect");
            Assert.AreEqual(idPublic, dvd.IdPublic, "IdPublic incorrect");
            Assert.AreEqual(lePublic, dvd.Public, "Public incorrect");
            Assert.AreEqual(idRayon, dvd.IdRayon, "IdRayon incorrect");
            Assert.AreEqual(rayon, dvd.Rayon, "Rayon incorrect");
            Assert.AreEqual(duree, dvd.Duree, "Durée incorrecte");
            Assert.AreEqual(realisateur, dvd.Realisateur, "Réalisateur incorrect");
            Assert.AreEqual(synopsis, dvd.Synopsis, "Synopsis incorrect");
        }
    }
}
