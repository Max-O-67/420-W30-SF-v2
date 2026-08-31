# E02 — Préparer un environnement de tests

## Votre mission technique

Créer dans Visual Studio une mini-solution qui confirme que votre environnement
peut compiler un projet, découvrir un test xUnit et utiliser un paquet NuGet.

> [!IMPORTANT]
> Cette activité est une **vérification de plomberie** : recopiez, exécutez et
> constatez le résultat. Il n'est pas encore demandé de comprendre ou d'écrire
> seul un simulacre avec Moq, ni d'expliquer `Verify`. Vous ouvrirez cette boîte
> noire progressivement dans E04 et E05.

**Livrable :** une mini-solution locale fonctionnelle, sans commit ni remise.

**Première action :** ouvrez Visual Studio et choisissez **Créer un projet**.

## 1. Créer la solution et les projets

Dans Visual Studio uniquement :

1. Créez une **solution vide** nommée
   `S02E02_Restaurant_Commande`.
2. Ajoutez une **Bibliothèque de classes** nommée
   `S02E02_Restaurant_Commande`, ciblant **.NET 10.0**.
3. Ajoutez une **Application console** nommée
   `S02E02_Restaurant_Commande.Terminal`, ciblant **.NET 10.0**.
4. Ajoutez un **Projet de test xUnit** nommé
   `S02E02_Restaurant_Commande.Tests`, ciblant **.NET 10.0**.
5. Supprimez les classes produites automatiquement dont vous n'avez pas besoin.

Vous devez voir exactement trois projets dans l'Explorateur de solutions.

## 2. Relier les projets et installer Moq

Dans `S02E02_Restaurant_Commande.Terminal`, puis dans
`S02E02_Restaurant_Commande.Tests` :

1. cliquez avec le bouton droit sur **Dépendances**;
2. choisissez **Ajouter une référence de projet**;
3. cochez `S02E02_Restaurant_Commande`.

Dans `S02E02_Restaurant_Commande.Tests` seulement :

1. ouvrez **Gérer les packages NuGet**;
2. recherchez et installez le paquet nommé exactement `Moq`.

Ouvrez les trois fichiers `.csproj`. Repérez :

- un `ProjectReference` vers le projet principal dans Terminal et Tests;
- un `PackageReference` vers Moq uniquement dans Tests.

Le projet principal ne doit référencer ni Terminal, ni Tests, ni Moq.

## 3. Exécuter un test de raccordement

Dans `S02E02_Restaurant_Commande`, créez `IExpediteurMessage.cs` :

```csharp
namespace Restaurant;

public interface IExpediteurMessage
{
    void Envoyer(string message);
}
```

Créez `AvertisseurCuisine.cs` :

```csharp
namespace Restaurant;

public sealed class AvertisseurCuisine
{
    private readonly IExpediteurMessage m_expediteurMessage;

    public AvertisseurCuisine(IExpediteurMessage expediteurMessage)
    {
        ArgumentNullException.ThrowIfNull(expediteurMessage);
        m_expediteurMessage = expediteurMessage;
    }

    public void AvertirCommandePrete(string numeroCommande)
    {
        m_expediteurMessage.Envoyer(
            $"La commande {numeroCommande} est prête.");
    }
}
```

Dans `S02E02_Restaurant_Commande.Terminal`, remplacez `Program.cs` par ce test
de raccordement très simple :

```csharp
using Restaurant;

namespace Restaurant.Terminal;

internal static class Program
{
    private sealed class ExpediteurMessageConsole : IExpediteurMessage
    {
        public void Envoyer(string message)
        {
            Console.Out.WriteLine(message);
        }
    }

    private static void Main()
    {
        AvertisseurCuisine avertisseur = new AvertisseurCuisine(
            new ExpediteurMessageConsole());

        avertisseur.AvertirCommandePrete("C-1042");
    }
}
```

Exécutez Terminal et observez le message. Dans
`S02E02_Restaurant_Commande.Tests`, utilisez ensuite ce test :

```csharp
using Moq;
using Restaurant;

namespace Restaurant.Tests;

public sealed class AvertisseurCuisineTests
{
    [Fact]
    public void AvertirCommandePrete_NumeroValide_EnvoieLeMessageUneFois()
    {
        Mock<IExpediteurMessage> expediteur =
            new Mock<IExpediteurMessage>();
        AvertisseurCuisine avertisseur =
            new AvertisseurCuisine(expediteur.Object);

        avertisseur.AvertirCommandePrete("C-1042");

        expediteur.Verify(
            objet => objet.Envoyer("La commande C-1042 est prête."),
            Times.Once);
    }
}
```

Ouvrez l'**Explorateur de tests** et exécutez le test. Modifiez temporairement
le message attendu pour observer un échec, puis remettez le message exact.

## Terminé lorsque

- [ ] les trois projets ciblent `net10.0`;
- [ ] Terminal et Tests référencent le projet principal;
- [ ] Terminal affiche le message attendu;
- [ ] le test utilise un type provenant du projet de production;
- [ ] Moq est installé seulement dans le projet de tests;
- [ ] le test est découvert et réussit;
- [ ] vous pouvez montrer où se trouvent `ProjectReference` et
  `PackageReference`.

Conservez cette mini-solution comme référence locale, puis passez à
[E03 — Tests sans dépendance](./E03-tests-sans-dependance.md).
