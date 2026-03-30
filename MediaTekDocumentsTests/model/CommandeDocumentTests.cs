using System;
using MediaTekDocuments.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MediaTekDocumentsTests.model
{
    /// <summary>
    /// Tests unitaires pour la classe métier <see cref="CommandeDocument"/>.
    /// </summary>
    [TestClass]
    public class CommandeDocumentTests
    {
        /// <summary>
        /// Vérifie le constructeur paramétré utilisé lors de la création d'une commande livre/DVD.
        /// </summary>
        [TestMethod]
        public void ConstructeurCommandeDocumentAvecParametresTest()
        {
            // Arrange
            DateTime dateCommande = new DateTime(2026, 3, 27);
            const double montant = 42.5;
            const int nbExemplaire = 3;
            const string idLivreDvd = "L100";
            const string idSuivi = "00001";

            // Act
            CommandeDocument commande = new CommandeDocument(dateCommande, montant, nbExemplaire, idLivreDvd, idSuivi);

            // Assert
            Assert.AreEqual(dateCommande, commande.DateCommande, "DateCommande incorrecte");
            Assert.AreEqual(montant, commande.Montant, "Montant incorrect");
            Assert.AreEqual(nbExemplaire, commande.NbExemplaire, "NbExemplaire incorrect");
            Assert.AreEqual(idLivreDvd, commande.IdLivreDvd, "IdLivreDvd incorrect");
            Assert.AreEqual(idSuivi, commande.IdSuivi, "IdSuivi incorrect");
        }
    }
}
