using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocumentsTests.model
{
    /// <summary>
    /// Tests unitaires pour la classe métier <see cref="Document"/>.
    /// </summary>
    [TestClass]
    public class DocumentTests
    {
        /// <summary>
        /// Vérifie que le constructeur initialise correctement toutes les propriétés d'un document.
        /// </summary>
        [TestMethod]
        public void ConstructeurDocumentTest()
        {
            // Arrange
            const string id = "D1";
            const string titre = "Un titre";
            const string image = "img.png";
            const string idGenre = "G1";
            const string genre = "Genre";
            const string idPublic = "P1";
            const string lePublic = "Public";
            const string idRayon = "R1";
            const string rayon = "Rayon";

            // Act
            Document document = new Document(id, titre, image, idGenre, genre, idPublic, lePublic, idRayon, rayon);

            // Assert
            Assert.AreEqual(id, document.Id, "Id incorrect");
            Assert.AreEqual(titre, document.Titre, "Titre incorrect");
            Assert.AreEqual(image, document.Image, "Image incorrecte");
            Assert.AreEqual(idGenre, document.IdGenre, "IdGenre incorrect");
            Assert.AreEqual(genre, document.Genre, "Genre incorrect");
            Assert.AreEqual(idPublic, document.IdPublic, "IdPublic incorrect");
            Assert.AreEqual(lePublic, document.Public, "Public incorrect");
            Assert.AreEqual(idRayon, document.IdRayon, "IdRayon incorrect");
            Assert.AreEqual(rayon, document.Rayon, "Rayon incorrect");
        }
    }
}
