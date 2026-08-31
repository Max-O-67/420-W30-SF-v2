# Semaine 2 — Tests unitaires, doublures et Moq

## Parcours de la semaine

N'essayez pas de lire tous les exercices d'un seul coup. Ouvrez uniquement la
fiche de l'étape en cours, repérez sa **mission**, son **livrable**, sa
**première action** et ses critères **Terminé lorsque**, puis commencez.

| Étape | Activité |
|---|---|
| [E02](./E02-preparer-environnement.md) | Préparer l'environnement de tests |
| [E03](./E03-tests-sans-dependance.md) | Tester sans dépendance |
| [E04](./E04-simulacre-manuel.md) | Construire un simulacre manuel |
| [E05](./E05-moq.md) | Tester un cas intégrateur avec Moq |

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

E02 utilise une mini-solution indépendante. À partir de E03, les trois
exercices utilisent la même
[solution Restaurant](./S02E03E05_Restaurant_Commande/).

## Règles communes à E03, E04 et E05

- Écrivez les tests uniquement dans
  `S02E03E05_Restaurant_Commande.Tests`.
- Ne modifiez pas le projet `S02E03E05_Restaurant_Commande` pour faciliter un
  test.
- Ne testez pas directement les membres `private`.
- Utilisez AAA et la convention `Methode_Cas_ResultatAttendu`.
- E03 et E04 sont réalisés sans Moq ni autre bibliothèque de doublures.
- Ajoutez Moq à `S02E03E05_Restaurant_Commande.Tests` seulement au début
  de E05.
- Exécutez tous les tests avant chaque commit et chaque poussée.

## Avant de demander de l'aide

Préparez ces trois informations :

1. le résultat que vous cherchez à obtenir;
2. la consigne ou le critère d'acceptation concerné;
3. ce que vous avez essayé et le résultat observé.

Ce court diagnostic permet à une autre personne de comprendre rapidement le
blocage et vous aide souvent à repérer vous-même la prochaine action.

## Validation finale

Depuis `S02E03E05_Restaurant_Commande` :

```bash
dotnet test
git status
git log --oneline -4
```

- [ ] tous les tests réussissent sur `net10.0`;
- [ ] E03 ne contient aucune doublure;
- [ ] E04 utilise uniquement le simulacre manuel;
- [ ] E05 utilise Moq pour les trois interfaces;
- [ ] trois commits cohérents distinguent E03, E04 et E05;
