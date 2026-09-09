namespace Restaurant.Livraison;

public class CalculateurFraisGratuit : CalculateurFrais
{
    public override decimal Calculer(decimal sousTotal, double distanceKm)
    {
        return sousTotal >= 50m ? 0m : base.Calculer(sousTotal, distanceKm);
    }
}
