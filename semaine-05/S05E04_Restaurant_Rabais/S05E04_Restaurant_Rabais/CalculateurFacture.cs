namespace Restaurant.Rabais;
using System;
using System.Collections.Generic;
using System.Text;
public class CalculateurFacture
{
    private readonly IStrategieRabais strategieRabais;

    public CalculateurFacture(IStrategieRabais strategieRabais)
    {
        if (strategieRabais == null)
        {
            throw new ArgumentNullException(nameof(strategieRabais));
        }

        this.strategieRabais = strategieRabais;
    }
}