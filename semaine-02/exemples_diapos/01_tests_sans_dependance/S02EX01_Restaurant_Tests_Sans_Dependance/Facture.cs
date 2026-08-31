namespace Restaurant;

public sealed class Facture
{
    private readonly List<LigneCommande> m_lignes =
        new List<LigneCommande>();

    public void Ajouter(LigneCommande ligne)
    {
        ArgumentNullException.ThrowIfNull(ligne);
        m_lignes.Add(ligne);
    }

    public decimal SousTotal
    {
        get
        {
            return m_lignes.Sum(ligne => ligne.Total);
        }
    }
}
