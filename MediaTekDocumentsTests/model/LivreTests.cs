using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocumentsTests.model
{
    /// <summary>
    /// Tests unitaires pour la classe métier <see cref="Livre"/>.
    /// </summary>
    [TestClass]
    public class LivreTests
    {
        /// <summary>
        /// Vérifie que le constructeur initialise correctement les propriétés spécifiques au livre et héritées.
        /// </summary>
        [TestMethod]
        public void ConstructeurLivreTest()
        {
            // Arrange
            const string id = "1000";
            const string titre = "Titre";
            const string image = "image.jpg";
            const string isbn = "9781234567890";
            const string auteur = "Auteur";
            const string collection = "Collection";
            const string idGenre = "G1";
            const string genre = "Roman";
            const string idPublic = "P1";
            const string lePublic = "Adulte";
            const string idRayon = "R1";
            const string rayon = "Litterature";

            // Act
            Livre livre = new Livre(id, titre, image, isbn, auteur, collection, idGenre, genre, idPublic, lePublic, idRayon, rayon);

            // Assert
            Assert.AreEqual(id, livre.Id, "Id incorrect");
            Assert.AreEqual(titre, livre.Titre, "Titre incorrect");
            Assert.AreEqual(image, livre.Image, "Image incorrecte");
            Assert.AreEqual(idGenre, livre.IdGenre, "IdGenre incorrect");
            Assert.AreEqual(genre, livre.Genre, "Genre incorrect");
            Assert.AreEqual(idPublic, livre.IdPublic, "IdPublic incorrect");
            Assert.AreEqual(lePublic, livre.Public, "Public incorrect");
            Assert.AreEqual(idRayon, livre.IdRayon, "IdRayon incorrect");
            Assert.AreEqual(rayon, livre.Rayon, "Rayon incorrect");
            Assert.AreEqual(isbn, livre.Isbn, "Isbn incorrect");
            Assert.AreEqual(auteur, livre.Auteur, "Auteur incorrect");
            Assert.AreEqual(collection, livre.Collection, "Collection incorrecte");
        }
    }
}
