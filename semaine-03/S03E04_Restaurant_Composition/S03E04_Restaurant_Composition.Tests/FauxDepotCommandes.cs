using Restaurant.Application;
using Restaurant.Domaine;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Tests
{   
    public class FauxDepotCommandes : IDepotCommandes
        {
        public Commande? CommandeAjoutee { get; private set; }

        public void Ajouter(Commande commande)
        {
            CommandeAjoutee = commande;
        }
    }
    
}
