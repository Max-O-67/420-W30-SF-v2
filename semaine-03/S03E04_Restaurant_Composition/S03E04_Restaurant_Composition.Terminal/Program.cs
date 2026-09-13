using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.Application;
using Restaurant.Infrastructure;

if (args.Contains("--manuel"))
{
    AssemblageManuel();
}
else
{
    AssemblageAutomatique(args);
}

static void AssemblageManuel()
{
    IDepotCommandes depot = new DepotCommandesMemoire();
    INotificationCommande notification = new NotificationConsole();

    CreerCommande creerCommande = new CreerCommande(depot, notification);

    creerCommande.Executer(123);
}

static void AssemblageAutomatique(string[] args)
{
    var builder = Host.CreateApplicationBuilder(args);

    builder.Services.AddScoped<IDepotCommandes, DepotCommandesMemoire>();
    builder.Services.AddScoped<INotificationCommande, NotificationConsole>();
    builder.Services.AddScoped<CreerCommande>();

    var app = builder.Build();

    using var scope = app.Services.CreateScope();

    CreerCommande creerCommande =
        scope.ServiceProvider.GetRequiredService<CreerCommande>();

    creerCommande.Executer(123);
}