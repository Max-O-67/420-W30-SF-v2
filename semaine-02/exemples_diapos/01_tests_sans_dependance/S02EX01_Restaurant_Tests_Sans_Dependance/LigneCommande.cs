namespace Restaurant;

public sealed class LigneCommande
{
    public LigneCommande(
        string description,
        decimal prixUnitaire,
        int quantite)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new ArgumentException(
                "La description est obligatoire.",
                nameof(description));
        }

        if (prixUnitaire < 0m)
        {
            throw new ArgumentOutOfRangeException(nameof(prixUnitaire));
        }

        if (quantite <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(quantite));
        }

        Description = description;
        PrixUnitaire = prixUnitaire;
        Quantite = quantite;
    }

    public string Description { get; }

    public decimal PrixUnitaire { get; }

    public int Quantite { get; }

    public decimal Total
    {
        get
        {
            return PrixUnitaire * Quantite;
        }
    }
}
