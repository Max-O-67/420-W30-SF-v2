# Exercice 2

## Mission et durée

En 60 minutes, remplacez une hiérarchie fragile et une interface trop large par
des contrats honnêtes et de la composition.

Créez `fonctionnalite/solid-composition` depuis `dev`.

## Travail demandé

1. Séparez la capacité de calculer des frais de celle d'afficher une description.
2. Aucun calculateur ne doit être forcé d'implanter une opération inutile.
3. Retirez l'héritage qui permet à une classe fille de briser les attentes sur
   le calcul des frais.
4. Composez plutôt le service avec une abstraction de calcul.
5. Ajoutez un nouveau calculateur sans modifier les calculateurs existants.
6. Écrivez **une seule méthode de test paramétrée** qui reçoit successivement
   les implantations compatibles et leur résultat attendu.

Limitez-vous aux trois calculateurs demandés. Le but est de vérifier leur
substitution, pas de couvrir toutes les distances possibles.

Justifiez brièvement OCP, LSP et ISP dans `DECISIONS.md`, puis réalisez le
parcours `fonctionnalite/solid-composition` → `dev` → `main`.
