# Semaine 3 — Injection et branches Git

Cette semaine rend d'abord l'injection visible avec du code C# ordinaire,
puis automatise l'assemblage avec le conteneur .NET. Les branches Git sont
utilisées comme méthode normale de travail.

| Étape | Durée | Activité |
|---|---:|---|
| [E13](./E13-branches-git.md) | 30 min | Manipuler des branches avec Git et GitHub |
| [E03](./E03-injection-manuelle.md) | 60 min | Injecter manuellement une notification sur `dev` |
| [E04](./E04-conteneur-di.md) | 60 min | Ajouter le conteneur sur une branche fonctionnelle |
| [EX01](./EX01-injection-composition.md) | 90 à 100 min | Réinvestir l'injection, les tests et Git |

E03 et E04 utilisent la même
[solution Restaurant](./S03E03E04_Restaurant_Notification/). EX01 possède un
départ distinct.

## Progression Git

```text
E13 : commandes guidées
          ↓
E03 : dev → main
          ↓
E04 : fonctionnalite/conteneur-di → dev → main
          ↓
EX01 : parcours réalisé de façon autonome
```

Avant une fusion, vérifiez toujours la branche active avec `git status` et
exécutez les tests. Une fusion réussie n'est terminée que lorsque le projet
fonctionne encore sur la branche de destination.
