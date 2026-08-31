using Restaurant;

namespace Restaurant.Tests;

public sealed class ExpediteurCuisineEspion : IExpediteurCuisine
{
    public int NombreAppels { get; private set; }

    public Commande? DerniereCommande { get; private set; }

    public void Envoyer(Commande commande)
    {
        ArgumentNullException.ThrowIfNull(commande);

        NombreAppels++;
        DerniereCommande = commande;
    }
}
