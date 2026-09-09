# Exercice 3

## Mission et durée

En 45 minutes, retirez la chaîne d'appels utilisée pour obtenir l'adresse de
notification du client.

Créez `fonctionnalite/demeter` depuis `dev`.

## Travail demandé

Le code de départ permet un appel semblable à
`commande.Client.Profil.Coordonnees.Courriel`. Ajoutez plutôt un message utile
sur l'objet connu directement par le service.

1. Ajoutez le comportement nécessaire à `Client`.
2. Rendez les objets intermédiaires non accessibles publiquement lorsqu'ils ne
   sont plus utiles au client de la classe.
3. Modifiez le service pour ne parler qu'à ses collaborateurs directs.
4. Écrivez **un seul test** qui vérifie le courriel transmis à la notification,
   sans tester directement la structure interne de `Client`.
5. Ajoutez dans `DECISIONS.md` la chaîne supprimée et le message qui la remplace.

Terminez le parcours `fonctionnalite/demeter` → `dev` → `main`, avec
`dotnet test` après chaque fusion.
