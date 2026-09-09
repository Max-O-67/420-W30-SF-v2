using Restaurant.Qualite;

Client client = new("client@exemple.ca");
ServiceCommandes service = new();
Commande commande = service.Creer(1001, 40m, client);

Console.Out.WriteLine($"Total : {commande.SousTotal + commande.Taxe:C}");
