# Exercice 3

## Mission et durée

En 55 minutes, rendez explicite le patron Strategy pour choisir la règle de
tarification d'une livraison.

Créez `fonctionnalite/strategy-livraison` depuis `dev`.

## Travail demandé

1. Créez `ITarificationLivraison` avec une seule opération de calcul.
2. Implantez les stratégies `TarificationStandard` et
   `TarificationPrioritaire`.
3. Injectez la stratégie dans `ServiceLivraisons`.
4. Retirez la sélection par chaîne de caractères et la cascade conditionnelle.
5. Écrivez exactement deux méthodes de test :
   - un test du contexte avec une stratégie contrôlée;
   - un `[Theory]` qui vérifie les deux stratégies fournies pour une même livraison.
6. Représentez dans `DECISIONS.md` les rôles contexte, stratégie et stratégies
   concrètes.

Le choix de la stratégie appartient au point de composition. Après les tests,
fusionnez la fonctionnalité dans `dev`, puis `dev` dans `main`.
