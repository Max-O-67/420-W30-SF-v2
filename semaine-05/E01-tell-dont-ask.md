# Exercice 1

## Mission et durée

En 45 minutes, retirez du service la décision concernant l'admissibilité à la
livraison prioritaire.

Créez `fonctionnalite/tell-dont-ask` depuis `dev`.

## Travail demandé

1. Repérez le code qui demande le statut et les points du client avant de décider.
2. Ajoutez à `Client` un message qui exprime la décision utile.
3. Rendez les données publiques inutiles inaccessibles de l'extérieur.
4. Modifiez le service afin qu'il dise à l'objet quoi faire ou lui demande une
   réponse métier directe, sans reconstruire sa règle.
5. Écrivez **une seule méthode de test paramétrée** avec `[Theory]` pour couvrir
   un client admissible et deux clients non admissibles.

Il n'est pas nécessaire de tester de nouveau le calcul complet des frais dans
cet exercice.

Dans `DECISIONS.md`, expliquez en deux ou trois phrases la différence entre
Tell, Don't Ask et une simple multiplication des getters.

Fusionnez la fonctionnalité dans `dev`, testez, puis fusionnez `dev` dans `main`.
