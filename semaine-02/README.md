# Semaine 2 — Tests unitaires, doublures et Moq

Consultez la [liste des exercices ramassés](../exercices_ramassés.md).
Les échéances et modalités de remise sont indiquées sur la plateforme d'enseignement.

## Parcours de la semaine

N'essayez pas de lire tous les exercices d'un seul coup. Ouvrez uniquement la
fiche de l'étape en cours, repérez sa **mission**, son **livrable**, sa
**première action** et ses critères **Terminé lorsque**, puis commencez.

| Étape | Activité |
|---|---|
| [Exercice 1](./E01-preparer-environnement.md) | Préparer l'environnement de tests |
| [Exercice 2](./E02-tests-sans-dependance.md) | Tester sans dépendance |
| [Exercice 3](./E03-simulacre-manuel.md) | Construire un simulacre manuel |
| [Exercice 4](./E04-moq.md) | Tester un cas intégrateur avec Moq |

## Progression

```text
Valider l'environnement
        ↓
Tester du code déterministe
        ↓
Construire une doublure à la main
        ↓
Automatiser ce mécanisme avec Moq
```

E01 utilise une mini-solution indépendante. À partir de E02, les trois
exercices utilisent la même
[solution Restaurant](./S02E02E04_Restaurant_Commande/).

## Règles communes à E02, E03 et E04

- Écrivez les tests uniquement dans
  `S02E02E04_Restaurant_Commande.Tests`.
- Ne modifiez pas le projet `S02E02E04_Restaurant_Commande` pour faciliter un
  test.
- Ne testez pas directement les membres `private`.
- Utilisez AAA et la convention `Methode_Cas_ResultatAttendu`.
- E02 et E03 sont réalisés sans Moq ni autre bibliothèque de doublures.
- Ajoutez Moq à `S02E02E04_Restaurant_Commande.Tests` seulement au début
  de E04.
- Exécutez tous les tests avant chaque commit et chaque poussée.

## Avant de demander de l'aide

Préparez ces trois informations :

1. le résultat que vous cherchez à obtenir;
2. la consigne ou le critère d'acceptation concerné;
3. ce que vous avez essayé et le résultat observé.

Ce court diagnostic permet à une autre personne de comprendre rapidement le
blocage et vous aide souvent à repérer vous-même la prochaine action.

## Validation finale

Depuis `S02E02E04_Restaurant_Commande` :

```bash
dotnet test
git status
git log --oneline -4
```

- [ ] tous les tests réussissent sur `net10.0`;
- [ ] E02 ne contient aucune doublure;
- [ ] E03 utilise uniquement le simulacre manuel;
- [ ] E04 utilise Moq pour les trois interfaces;
- [ ] trois commits cohérents distinguent E02, E03 et E04;
