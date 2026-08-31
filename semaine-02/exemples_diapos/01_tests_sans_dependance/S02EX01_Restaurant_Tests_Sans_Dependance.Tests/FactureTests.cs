using Restaurant;

namespace Restaurant.Tests;

public sealed class FactureTests
{
    [Fact]
    public void SousTotal_DeuxLignes_RetourneSomme()
    {
        // Arranger
        Facture facture = new Facture();
        facture.Ajouter(new LigneCommande("Soupe", 6.00m, 2));
        facture.Ajouter(new LigneCommande("Dessert", 5.00m, 1));

        // Agir
        decimal resultat = facture.SousTotal;

        // Auditer
        Assert.Equal(17.00m, resultat);
    }
}
