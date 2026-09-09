namespace Restaurant.Livraison;

public class Client
{
    public string Statut { get; }
    public int PointsFidelite { get; }

    public Client(string statut, int pointsFidelite)
    {
        Statut = statut;
        PointsFidelite = pointsFidelite;
    }
}
