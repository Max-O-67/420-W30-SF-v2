namespace Restaurant;

public sealed class Commande
{
    private readonly List<LigneCommande> m_lignes =
        new List<LigneCommande>();

    public bool EstConfirmee { get; private set; }

    public void AjouterLigne(LigneCommande ligne)
    {
        ArgumentNullException.ThrowIfNull(ligne);
        m_lignes.Add(ligne);
    }

    public void Confirmer()
    {
        if (m_lignes.Count == 0)
        {
            throw new InvalidOperationException(
                "Une commande vide ne peut pas être confirmée.");
        }

        EstConfirmee = true;
    }
}
