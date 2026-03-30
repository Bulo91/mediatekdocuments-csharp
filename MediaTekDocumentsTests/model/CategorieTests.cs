using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocumentsTests.model
{
    /// <summary>
    /// Tests unitaires pour la classe métier <see cref="Categorie"/>.
    /// </summary>
    [TestClass]
    public class CategorieTests
    {
        /// <summary>
        /// Vérifie que le constructeur renseigne l'identifiant et le libellé.
        /// </summary>
        [TestMethod]
        public void ConstructeurCategorieTest()
        {
            // Arrange
            const string id = "0001";
            const string libelle = "Roman";

            // Act
            Categorie categorie = new Categorie(id, libelle);

            // Assert
            Assert.AreEqual(id, categorie.Id, "Id incorrect");
            Assert.AreEqual(libelle, categorie.Libelle, "Libelle incorrect");
        }

        /// <summary>
        /// Vérifie que <see cref="Categorie.ToString"/> retourne le libellé (affichage dans les combos).
        /// </summary>
        [TestMethod]
        public void ToStringTest()
        {
            // Arrange
            const string libelle = "Documentaire";
            Categorie categorie = new Categorie("0002", libelle);

            // Act
            string resultat = categorie.ToString();

            // Assert
            Assert.AreEqual(libelle, resultat, "ToString doit renvoyer Libelle");
        }
    }
}
