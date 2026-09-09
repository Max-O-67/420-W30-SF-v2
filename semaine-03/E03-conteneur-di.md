# Exercice 3

## Mission et durée

En 60 minutes, partez de la solution réussie en E02 et remplacez l'assemblage
manuel de la racine de composition par le moteur d'injection de dépendances.

## 1. Créer la branche fonctionnelle

Revoyez [les commandes de E01](./E01-branches-git.md) au besoin.

```bash
git switch dev
git pull
git switch -c fonctionnalite/conteneur-di
git push -u origin fonctionnalite/conteneur-di
```

## 2. Configurer le conteneur

Le paquet `Microsoft.Extensions.Hosting` est déjà référencé par le projet
Terminal.

Dans `Program.cs` :

1. créez un `HostApplicationBuilder` avec
   `Host.CreateApplicationBuilder(args)`;
2. enregistrez `INotificationCommande`, `NotificationConsole` et
   `ServiceCommandes` avec un cycle de vie `Scoped`;
3. appelez `Build()`;
4. créez une portée avec `CreateScope()`;
5. obtenez `ServiceCommandes` avec `GetRequiredService<ServiceCommandes>()`;
6. créez la commande `1001`.

Le conteneur reste dans `Program.cs`. Il ne doit pas être transmis au service.
Les tests de E02 doivent continuer à construire directement le service avec
leur doublure mémoire.

## 3. Intégrer sans conflit attendu

```bash
dotnet test
git add .
git commit -m "Assemble les services avec le conteneur .NET"
git push
git switch dev
git merge fonctionnalite/conteneur-di
dotnet test
git push
git switch main
git merge dev
dotnet test
git push
```

Aucun conflit n'est attendu. Si Git en signale un, vérifiez la branche de
départ, les modifications locales et les changements distants avant de le
résoudre.

Terminé lorsque l'application fonctionne avec le conteneur, les tests unitaires
n'utilisent pas le conteneur et `main` contient la fonctionnalité validée.
