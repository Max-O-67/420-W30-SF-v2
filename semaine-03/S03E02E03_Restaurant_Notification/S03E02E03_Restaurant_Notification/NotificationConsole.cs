namespace Restaurant;

public sealed class NotificationConsole
{
    public void NotifierCreation(int numeroCommande)
    {
        Console.Out.WriteLine($"Commande {numeroCommande} créée.");
    }
}
