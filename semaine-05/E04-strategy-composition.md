# Exercice 4

> [!IMPORTANT]
> **Évaluation individuelle — 2,5 %. Niveau 0 : zéro IA.** La génération de
> code, de tests ou de documentation par une IA est interdite.

Consultez la plateforme d'enseignement pour l'échéance et les modalités de remise.

## Mission et durée

Prévoyez de 90 à 100 minutes. Remplacez le calcul conditionnel des rabais par
des stratégies composables, puis démontrez le comportement avec des tests.

Le départ se trouve dans `S05E04_Restaurant_Rabais`.

## Parcours Git obligatoire

1. Créez et publiez `dev` depuis `main`.
2. Créez `fonctionnalite/exercice-4-strategy` depuis `dev`.
3. Réalisez au moins deux commits cohérents.
4. Fusionnez dans `dev`, exécutez les tests et publiez.
5. Fusionnez `dev` dans `main`, exécutez les tests et publiez.

Revoyez les commandes Git de la semaine 3 au besoin.

## Travail demandé

1. Créez une interface étroite `IStrategieRabais`.
2. Implantez un rabais nul, un rabais fidélité de 10 % et un rabais fixe de 5 $.
3. Un rabais ne peut jamais rendre le total négatif.
4. Injectez la stratégie dans `CalculateurFacture` et refusez `null`.
5. Ajoutez une nouvelle stratégie composée qui applique successivement deux
   stratégies sans modifier celles qui existent.
6. Écrivez exactement deux méthodes de test :
   - un `[Theory]` pour les valeurs limites du rabais fixe;
   - un test du calculateur avec une stratégie contrôlée.
7. Complétez `DECISIONS.md` : rôles Strategy, OCP, préférence pour la composition
   et résultat de `git log --oneline --graph --decorate --all`.

## Critères observables

- aucune sélection par chaîne de caractères dans `CalculateurFacture`;
- interfaces étroites et substituables;
- normes C# du cours respectées;
- tests structurés avec Arranger, Agir et Auditer;
- branches `dev` et `main` testées après les fusions.
