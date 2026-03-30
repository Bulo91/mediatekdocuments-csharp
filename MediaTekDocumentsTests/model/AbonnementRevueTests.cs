using System;
using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocumentsTests.model
{
    /// <summary>
    /// Tests unitaires pour la classe métier <see cref="AbonnementRevue"/>.
    /// </summary>
    [TestClass]
    public class AbonnementRevueTests
    {
        /// <summary>
        /// Vérifie le constructeur paramétré d'un abonnement de revue.
        /// </summary>
        [TestMethod]
        public void ConstructeurAbonnementRevueAvecParametresTest()
        {
            // Arrange
            DateTime dateCommande = new DateTime(2026, 3, 1);
            const double montant = 99.9;
            DateTime dateFinAbonnement = new DateTime(2027, 3, 1);
            const string idRevue = "RV1";

            // Act
            AbonnementRevue abonnement = new AbonnementRevue(dateCommande, montant, dateFinAbonnement, idRevue);

            // Assert
            Assert.AreEqual(dateCommande, abonnement.DateCommande, "DateCommande incorrecte");
            Assert.AreEqual(montant, abonnement.Montant, "Montant incorrect");
            Assert.AreEqual(dateFinAbonnement, abonnement.DateFinAbonnement, "DateFinAbonnement incorrecte");
            Assert.AreEqual(idRevue, abonnement.IdRevue, "IdRevue incorrect");
        }
    }
}
