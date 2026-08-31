using Moq;
using Restaurant;

namespace Restaurant.Tests;

public sealed class ServiceCommandeTests
{
    [Fact]
    public void Confirmer_CommandeValide_ConfirmeEtEnvoie()
    {
        // Arranger
        Mock<IExpediteurCuisine> mockExpediteur =
            new Mock<IExpediteurCuisine>();
        ServiceCommande service =
            new ServiceCommande(mockExpediteur.Object);
        Commande commande = new Commande();
        commande.AjouterLigne(
            new LigneCommande("Poutine", 14.95m, 1));

        // Agir
        service.Confirmer(commande);

        // Auditer
        Assert.True(commande.EstConfirmee);
        mockExpediteur.Verify(
            expediteur => expediteur.Envoyer(commande),
            Times.Once);
        mockExpediteur.VerifyNoOtherCalls();
    }

    [Fact]
    public void Confirmer_CommandeVide_NEnvoiePas()
    {
        // Arranger
        Mock<IExpediteurCuisine> mockExpediteur =
            new Mock<IExpediteurCuisine>();
        ServiceCommande service =
            new ServiceCommande(mockExpediteur.Object);
        Commande commande = new Commande();

        // Agir
        Action action = () => service.Confirmer(commande);

        // Auditer
        Assert.Throws<InvalidOperationException>(action);
        mockExpediteur.Verify(
            expediteur => expediteur.Envoyer(It.IsAny<Commande>()),
            Times.Never);
        mockExpediteur.VerifyNoOtherCalls();
    }
}
