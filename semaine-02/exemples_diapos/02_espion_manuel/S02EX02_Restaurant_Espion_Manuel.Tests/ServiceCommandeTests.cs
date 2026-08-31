using Restaurant;

namespace Restaurant.Tests;

public sealed class ServiceCommandeTests
{
    [Fact]
    public void Confirmer_CommandeValide_EnvoieUneFois()
    {
        // Arranger
        ExpediteurCuisineEspion espion = new ExpediteurCuisineEspion();
        ServiceCommande service = new ServiceCommande(espion);
        Commande commande = new Commande();
        commande.AjouterLigne(
            new LigneCommande("Poutine", 14.95m, 1));

        // Agir
        service.Confirmer(commande);

        // Auditer
        Assert.Equal(1, espion.NombreAppels);
        Assert.Same(commande, espion.DerniereCommande);
    }

    [Fact]
    public void Confirmer_CommandeVide_NEnvoiePas()
    {
        // Arranger
        ExpediteurCuisineEspion espion = new ExpediteurCuisineEspion();
        ServiceCommande service = new ServiceCommande(espion);
        Commande commande = new Commande();

        // Agir
        Action action = () => service.Confirmer(commande);

        // Auditer
        Assert.Throws<InvalidOperationException>(action);
        Assert.Equal(0, espion.NombreAppels);
        Assert.Null(espion.DerniereCommande);
    }
}
