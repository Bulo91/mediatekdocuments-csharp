using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocumentsTests.model
{
    /// <summary>
    /// Tests unitaires pour la classe statique <see cref="UtilisateurConnecte"/>.
    /// </summary>
    [TestClass]
    public class UtilisateurConnecteTests
    {
        /// <summary>
        /// Vérifie l'accesseur statique <see cref="UtilisateurConnecte.Instance"/> (affectation et lecture, puis remise à zéro).
        /// </summary>
        [TestMethod]
        public void Instance_SetEtGetTest()
        {
            // Arrange
            UtilisateurConnecte.Instance = null;
            Utilisateur utilisateur = new Utilisateur
            {
                Login = "login",
                IdService = "S1",
                LibelleService = "Service"
            };

            // Act
            UtilisateurConnecte.Instance = utilisateur;
            Utilisateur instance = UtilisateurConnecte.Instance;

            // Assert
            Assert.IsNotNull(instance, "Instance ne doit pas être null après affectation");
            Assert.AreEqual(utilisateur, instance, "Instance doit référencer l'utilisateur affecté");

            // Nettoyage (important : ne pas impacter les autres tests)
            UtilisateurConnecte.Instance = null;
        }
    }
}
