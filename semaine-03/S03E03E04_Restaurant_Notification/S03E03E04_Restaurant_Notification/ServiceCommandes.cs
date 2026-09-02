namespace Restaurant;

public sealed class ServiceCommandes
{
    public Commande Creer(int numeroCommande)
    {
        Commande commande = new(numeroCommande);
        NotificationConsole notification = new();
        notification.NotifierCreation(commande.Numero);
        return commande;
    }
}
