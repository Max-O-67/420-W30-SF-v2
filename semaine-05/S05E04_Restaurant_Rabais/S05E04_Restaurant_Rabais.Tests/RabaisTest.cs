using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Restaurant.Rabais.Tests
{
    public class RabaisTest
    {
        [Theory]
        [InlineData(-10, 0)]
        [InlineData(0, 0)]
        [InlineData(10, 10)]
        public void LimiterTotalAZero(decimal total, decimal resultatAttendu)
        {
            Assert.Equal(resultatAttendu, RegleRabais.LimiterTotalAZero(total));
        }

        [Theory]
        [InlineData(5, 0)]
        [InlineData(4, 0)]
        [InlineData(10, 5)]
        public void RabaisFixeValeursLimites(decimal total, decimal resultatAttendu)
        {
            var strategie = new RabaisFixe();

            Assert.Equal(resultatAttendu, strategie.CalculerRabais(total));
        }

        [Fact]
        public void CalculateurUtiliseLaStrategie()
        {
            var strategie = new StrategieControlee();
            var calculateur = new CalculateurFacture(strategie);

            decimal resultat = calculateur.CalculerTotal(100);

            Assert.Equal(42, resultat);
        }

        [Fact]
        public void CalculerTotalRefuseSousTotalNegatif()
        {
            var calculateur = new CalculateurFacture(new RabaisNul());

            // J'ai du faire des recherches ici pour savoir comment faire un assert.throws en xunit, je ne connaissais pas cette syntaxe vu que
            //j'ai fait du java et du php avant, mais j'ai trouvé la syntaxe sur le site officiel de xunit
            Assert.Throws<ArgumentOutOfRangeException>(
                () => calculateur.CalculerTotal(-1)
            );
        }

        [Fact]
        public void CalculateurRefuseStrategieNull()
        {
            Assert.Throws<ArgumentNullException>(
                () => new CalculateurFacture(null)
            );
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void StrategieComposeeRefuseStrategieNull(bool premiereEstNull)
        {
            IStrategieRabais premiere = premiereEstNull
                ? null
                : new RabaisNul();

            IStrategieRabais deuxieme = premiereEstNull
                ? new RabaisNul()
                : null;

            Assert.Throws<ArgumentNullException>(
                () => new StrategieRabaisComposee(premiere, deuxieme)
            );
        }

        [Theory]
        [InlineData(true, 13)]
        [InlineData(false, 13.5)]
        public void StrategieComposeeRespecteOrdre(
            bool fideliteEnPremier,
            decimal resultatAttendu)
        {
            IStrategieRabais premiere;
            IStrategieRabais deuxieme;

            if (fideliteEnPremier)
            {
                premiere = new RabaisFidelite();
                deuxieme = new RabaisFixe();
            }
            else
            {
                premiere = new RabaisFixe();
                deuxieme = new RabaisFidelite();
            }

            var strategie = new StrategieRabaisComposee(premiere, deuxieme);

            Assert.Equal(resultatAttendu, strategie.CalculerRabais(20));
        }

        private class StrategieControlee : IStrategieRabais
        {
            public decimal CalculerRabais(decimal total)
            {
                return 42;
            }
        }
    }
}
