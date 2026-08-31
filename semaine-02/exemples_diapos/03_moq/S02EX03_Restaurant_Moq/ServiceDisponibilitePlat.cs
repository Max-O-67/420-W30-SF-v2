namespace Restaurant;

public sealed class ServiceDisponibilitePlat
{
    private readonly IDisponibilitePlat m_disponibilite;

    public ServiceDisponibilitePlat(IDisponibilitePlat disponibilite)
    {
        ArgumentNullException.ThrowIfNull(disponibilite);
        m_disponibilite = disponibilite;
    }

    public bool PeutCommander(string codePlat)
    {
        if (string.IsNullOrWhiteSpace(codePlat))
        {
            throw new ArgumentException(
                "Le code du plat est obligatoire.",
                nameof(codePlat));
        }

        return m_disponibilite.EstDisponible(codePlat);
    }
}
