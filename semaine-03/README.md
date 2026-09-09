# Semaine 3 — Injection et branches Git

Cette semaine rend d'abord l'injection visible avec du code C# ordinaire,
puis automatise l'assemblage avec le conteneur .NET. Les branches Git sont
utilisées comme méthode normale de travail.

| Étape | Activité |
|---|---|
| [Exercice 1](./E01-branches-git.md) | Manipuler des branches avec Git et GitHub |
| [Exercice 2](./E02-injection-manuelle.md) | Injecter manuellement une notification en travaillant sur la branche `dev` |
| [Exercice 3](./E03-conteneur-di.md) | Ajouter le conteneur en travaillant sur une branche fonctionnelle |
| [Exercice 4](./E04-injection-composition.md) | Réinvestir l'injection, les tests et Git |

E02 et E03 utilisent la même
[solution Restaurant](./S03E02E03_Restaurant_Notification/). E04 possède un
départ distinct.

Consultez la [liste des exercices ramassés](../exercices_ramassés.md).
Les échéances et les modalités de remise sont indiquées sur la plateforme d'enseignement.

## Progression Git

```text
E01 : commandes guidées
          ↓
E02 : dev → main
          ↓
E03 : fonctionnalite/conteneur-di → dev → main
          ↓
E04 : parcours réalisé de façon autonome
```

Avant une fusion, vérifiez toujours la branche active avec `git status` et
exécutez les tests. Une fusion réussie n'est terminée que lorsque le projet
fonctionne encore sur la branche de destination.
