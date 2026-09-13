using Restaurant.Application;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Restaurant.Tests
{
    public class CreerCommandeTests
    {
        [Fact]
        public void Executer_CreeCommandeEtNotifieCorrectement()
        {
            // Arrange
            var depot = new FauxDepotCommandes();
            var notification = new FausseNotificationCommande();
            var creerCommande = new CreerCommande(depot, notification);

            // Act
            creerCommande.Executer(123);

            // Assert
            Assert.NotNull(depot.CommandeAjoutee);
            Assert.Equal(123, depot.CommandeAjoutee.Numero);
            Assert.Equal(123, notification.NumeroNotifie);
        }
    }
}