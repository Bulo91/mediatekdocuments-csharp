using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocumentsTests.model
{
    /// <summary>
    /// Tests unitaires pour la classe métier <see cref="Revue"/>.
    /// </summary>
    [TestClass]
    public class RevueTests
    {
        /// <summary>
        /// Vérifie que le constructeur initialise la revue, la périodicité et le délai de mise à disposition.
        /// </summary>
        [TestMethod]
        public void ConstructeurRevueTest()
        {
            // Arrange
            const string id = "RV1";
            const string titre = "Magazine";
            const string image = "revue.png";
            const string idGenre = "G2";
            const string genre = "Presse";
            const string idPublic = "P2";
            const string lePublic = "Adulte";
            const string idRayon = "R2";
            const string rayon = "Revues";
            const string periodicite = "Mensuel";
            const int delaiMiseADispo = 7;

            // Act
            Revue revue = new Revue(id, titre, image, idGenre, genre, idPublic, lePublic, idRayon, rayon, periodicite, delaiMiseADispo);

            // Assert
            Assert.AreEqual(id, revue.Id, "Id incorrect");
            Assert.AreEqual(titre, revue.Titre, "Titre incorrect");
            Assert.AreEqual(image, revue.Image, "Image incorrecte");
            Assert.AreEqual(idGenre, revue.IdGenre, "IdGenre incorrect");
            Assert.AreEqual(genre, revue.Genre, "Genre incorrect");
            Assert.AreEqual(idPublic, revue.IdPublic, "IdPublic incorrect");
            Assert.AreEqual(lePublic, revue.Public, "Public incorrect");
            Assert.AreEqual(idRayon, revue.IdRayon, "IdRayon incorrect");
            Assert.AreEqual(rayon, revue.Rayon, "Rayon incorrect");
            Assert.AreEqual(periodicite, revue.Periodicite, "Périodicité incorrecte");
            Assert.AreEqual(delaiMiseADispo, revue.DelaiMiseADispo, "Délai de mise à dispo incorrect");
        }
    }
}
