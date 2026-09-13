using Restaurant.Domaine;

namespace Restaurant.Application;

public sealed class CreerCommande
{
    private readonly IDepotCommandes _depotCommandes;
    private readonly INotificationCommande _notificationCommande;

    public CreerCommande(IDepotCommandes depotCommandes, INotificationCommande notificationCommande)
    {
        _depotCommandes = depotCommandes ?? throw new ArgumentNullException("depotCommandes ne peut pas être null");
        _notificationCommande = notificationCommande ?? throw new ArgumentNullException("notificationCommande ne peut pas être null");
    }

    public void Executer(int numeroCommande)
    {
        Commande commande = new Commande(numeroCommande);

        _depotCommandes.Ajouter(commande);

        _notificationCommande.NotifierCreation(numeroCommande);
    }
}

    
    

