# Exercice 2

## Mission et durée

En 55 minutes, séparez le calcul de la taxe du cas d'utilisation et rendez
visibles les commandes et les requêtes.

Créez `fonctionnalite/srp-cqs` depuis `dev`.

## Travail demandé

1. Extrayez le calcul de taxe dans `CalculateurTaxe`.
2. Injectez ce collaborateur dans `ServiceCommandes`.
3. Gardez `Creer` comme commande qui modifie l'état et retourne la commande créée.
4. Ajoutez la requête `ObtenirDerniereCommande()` sans modification d'état.
5. Écrivez exactement deux tests :
   - un test du calcul de taxe pour un sous-total de 40 $;
   - un test prouvant que la requête retourne la dernière commande créée.
6. Expliquez dans `DECISIONS.md` pourquoi les deux classes ont des raisons de
   modification différentes et en quoi la requête respecte CQS.

Fusionnez vers `dev`, testez, puis fusionnez `dev` vers `main` et testez encore.

Ne retestez pas la notification de l'exercice 1 : ce comportement est déjà
couvert.
