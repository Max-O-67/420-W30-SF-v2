# E13 — Manipuler des branches avec Git et GitHub

## Mission et durée

En 30 minutes maximum, pratiquez les commandes essentielles dans un dépôt
jouet indépendant des exercices C#. Vous travaillerez individuellement et
utiliserez l'interface Web de GitHub pour simuler une modification distante.

Copiez d'abord le contenu de `S03E13_Depot_Jouet` dans un nouveau dépôt GitHub
privé, puis clonez ce dépôt. Remplacez `<URL>` et `<dossier>` dans les commandes.

## 1. Préparer le dépôt — 5 minutes

```bash
git clone <URL> <dossier>
cd <dossier>
git switch main
git status
git pull
```

`git status` affiche notamment la branche active. Ne commencez pas une fusion
tant que vous ne savez pas dans quelle branche vous vous trouvez.

## 2. Créer et pousser une branche — 5 minutes

```bash
git switch -c exercice/premiere-branche
git status
```

Ajoutez votre prénom à `presentation.txt`, puis publiez le changement.

```bash
git diff
git add presentation.txt
git commit -m "Ajoute mon prénom à la présentation"
git push -u origin exercice/premiere-branche
```

L'option `-u` associe la branche locale à la branche distante. Les poussées
suivantes pourront utiliser simplement `git push`.

## 3. Récupérer une branche distante — 5 minutes

Dans GitHub, créez `exercice/distance` à partir de `main`. Modifiez
`distance.txt`, inscrivez votre ville et créez le commit dans cette branche.

Dans le terminal :

```bash
git fetch origin
git branch --all
git switch --track origin/exercice/distance
git pull
```

`git fetch` découvre les références distantes. `git switch --track` crée la
branche locale correspondante. `git pull` met ensuite à jour la branche active
depuis la branche distante qu'elle suit.

## 4. Fusionner sans conflit — 5 minutes

```bash
git switch main
git pull
git merge exercice/premiere-branche
git status
git push
```

La commande `git merge X` intègre `X` dans la branche actuellement active.

## 5. Provoquer et résoudre un conflit — 8 minutes

Créez deux branches à partir du même état de `main` :

```bash
git switch main
git switch -c exercice/conflit-a
```

Dans `message.txt`, remplacez la ligne par `Message choisi dans A`, puis :

```bash
git add message.txt
git commit -m "Modifie le message dans la branche A"
git switch main
git switch -c exercice/conflit-b
```

Remplacez plutôt la même ligne par `Message choisi dans B`, puis :

```bash
git add message.txt
git commit -m "Modifie le message dans la branche B"
git switch main
git merge exercice/conflit-a
git merge exercice/conflit-b
```

La dernière commande signale un conflit. Ouvrez `message.txt`, retirez les
marqueurs `<<<<<<<`, `=======` et `>>>>>>>`, puis conservez une phrase claire
qui combine les deux intentions.

```bash
git add message.txt
git commit -m "Résout le conflit sur le message"
git push
```

## 6. Vérifier — 2 minutes

```bash
git status
git log --oneline --graph --decorate --all
```

Terminé lorsque les branches publiées sont visibles sur GitHub, `main` contient
les changements fusionnés, aucun marqueur de conflit ne demeure et l'historique
montre les deux fusions.

Gardez cette fiche ouverte : E03, E04 et EX01 vous demanderont de revoir ces
commandes sans les recopier intégralement.
