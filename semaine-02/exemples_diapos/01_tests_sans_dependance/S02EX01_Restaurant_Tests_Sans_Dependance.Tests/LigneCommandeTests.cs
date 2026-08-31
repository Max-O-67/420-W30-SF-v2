using Restaurant;

namespace Restaurant.Tests;

public sealed class LigneCommandeTests
{
    public static IEnumerable<object[]> CasTotal
    {
        get
        {
            yield return new object[] { 10.00m, 1, 10.00m };
            yield return new object[] { 12.50m, 2, 25.00m };
            yield return new object[] { 3.25m, 4, 13.00m };
        }
    }

    [Fact]
    public void Total_DeuxPlats_Calcule24Dollars()
    {
        // Arranger
        LigneCommande ligne = new LigneCommande(
            "Poutine",
            12.00m,
            2);

        // Agir
        decimal total = ligne.Total;

        // Auditer
        Assert.Equal(24.00m, total);
    }

    [Theory]
    [InlineData(10.00, 1, 10.00)]
    [InlineData(12.50, 2, 25.00)]
    [InlineData(3.25, 4, 13.00)]
    public void Total_DonneesValides_CalculeProduit(
        double prixUnitaire,
        int quantite,
        double totalAttendu)
    {
        // Arranger
        LigneCommande ligne = new LigneCommande(
            "Plat",
            (decimal)prixUnitaire,
            quantite);

        // Agir
        decimal total = ligne.Total;

        // Auditer
        Assert.Equal((decimal)totalAttendu, total);
    }

    [Theory]
    [MemberData(nameof(CasTotal))]
    public void Total_DonneesDecimal_CalculeProduit(
        decimal prixUnitaire,
        int quantite,
        decimal totalAttendu)
    {
        // Arranger
        LigneCommande ligne = new LigneCommande(
            "Plat",
            prixUnitaire,
            quantite);

        // Agir
        decimal total = ligne.Total;

        // Auditer
        Assert.Equal(totalAttendu, total);
    }

    [Fact]
    public void Constructeur_QuantiteNulle_LanceArgumentOutOfRangeException()
    {
        // Arranger
        Action action = () => new LigneCommande(
            "Poutine",
            12.00m,
            0);

        // Agir et auditer
        ArgumentOutOfRangeException exception =
            Assert.Throws<ArgumentOutOfRangeException>(action);

        Assert.Equal("quantite", exception.ParamName);
    }
}
