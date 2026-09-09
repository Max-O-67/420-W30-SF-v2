namespace Restaurant.Livraison;

public class CalculateurFrais
{
    public virtual decimal Calculer(decimal sousTotal, double distanceKm)
    {
        return 4m + (decimal)distanceKm * 0.75m;
    }

    public virtual string ObtenirDescription()
    {
        return "Tarification standard";
    }
}
