using Moq;
using Restaurant;

namespace Restaurant.Tests;

public sealed class ServiceDisponibilitePlatTests
{
    [Fact]
    public void PeutCommander_PlatDisponible_RetourneVrai()
    {
        // Arranger
        Mock<IDisponibilitePlat> mockDisponibilite =
            new Mock<IDisponibilitePlat>();
        mockDisponibilite
            .Setup(disponibilite =>
                disponibilite.EstDisponible("POU-01"))
            .Returns(true);

        ServiceDisponibilitePlat service =
            new ServiceDisponibilitePlat(mockDisponibilite.Object);

        // Agir
        bool peutCommander = service.PeutCommander("POU-01");

        // Auditer
        Assert.True(peutCommander);
        mockDisponibilite.Verify(
            disponibilite => disponibilite.EstDisponible("POU-01"),
            Times.Once);
        mockDisponibilite.VerifyNoOtherCalls();
    }
}
