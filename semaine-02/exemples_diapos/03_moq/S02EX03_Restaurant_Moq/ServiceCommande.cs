namespace Restaurant;

public sealed class ServiceCommande
{
    private readonly IExpediteurCuisine m_expediteur;

    public ServiceCommande(IExpediteurCuisine expediteur)
    {
        ArgumentNullException.ThrowIfNull(expediteur);
        m_expediteur = expediteur;
    }

    public void Confirmer(Commande commande)
    {
        ArgumentNullException.ThrowIfNull(commande);

        commande.Confirmer();
        m_expediteur.Envoyer(commande);
    }
}
