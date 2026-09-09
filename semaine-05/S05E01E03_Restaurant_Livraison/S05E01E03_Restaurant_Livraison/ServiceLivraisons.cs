namespace Restaurant.Livraison;

public class ServiceLivraisons
{
    public decimal CalculerFrais(
        Client client,
        decimal sousTotal,
        double distanceKm,
        string mode)
    {
        bool estPrioritaire = client.Statut == "Or" && client.PointsFidelite >= 1000;

        if (mode == "gratuit" && sousTotal >= 50m)
        {
            return 0m;
        }

        if (mode == "prioritaire" && estPrioritaire)
        {
            return 2m + (decimal)distanceKm;
        }

        return 4m + (decimal)distanceKm * 0.75m;
    }
}
