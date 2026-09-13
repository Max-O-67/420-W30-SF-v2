using Restaurant.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Tests
{
    internal class FausseNotificationCommande : INotificationCommande
    {
        public int? NumeroNotifie { get; private set; }

        public void NotifierCreation(int numeroCommande)
        {
            NumeroNotifie = numeroCommande;
        }
    }
}
