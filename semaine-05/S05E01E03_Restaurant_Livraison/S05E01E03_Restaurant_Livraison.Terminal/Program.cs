using Restaurant.Livraison;

Client client = new("Or", 1200);
ServiceLivraisons service = new();
decimal frais = service.CalculerFrais(client, 35m, 4, "prioritaire");

Console.Out.WriteLine($"Frais : {frais:C}");
