using System;
using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocumentsTests.model
{
    /// <summary>
    /// Tests unitaires pour la classe métier <see cref="Exemplaire"/>.
    /// </summary>
    [TestClass]
    public class ExemplaireTests
    {
        /// <summary>
        /// Vérifie le constructeur et l'affectation du libellé d'état pour l'affichage.
        /// </summary>
        [TestMethod]
        public void ConstructeurExemplaireEtLibelleEtatTest()
        {
            // Arrange
            const int numero = 12;
            DateTime dateAchat = new DateTime(2026, 1, 15);
            const string photo = "photo.jpg";
            const string idEtat = "E1";
            const string idDocument = "RV1";
            const string libelleEtat = "Neuf";

            // Act
            Exemplaire exemplaire = new Exemplaire(numero, dateAchat, photo, idEtat, idDocument);
            exemplaire.LibelleEtat = libelleEtat;

            // Assert
            Assert.AreEqual(numero, exemplaire.Numero, "Numero incorrect");
            Assert.AreEqual(dateAchat, exemplaire.DateAchat, "DateAchat incorrecte");
            Assert.AreEqual(photo, exemplaire.Photo, "Photo incorrecte");
            Assert.AreEqual(idEtat, exemplaire.IdEtat, "IdEtat incorrect");
            Assert.AreEqual(idDocument, exemplaire.Id, "IdDocument incorrect");
            Assert.AreEqual(libelleEtat, exemplaire.LibelleEtat, "LibelleEtat incorrect");
        }
    }
}
