# Semaine 1 — Révisions

## Objectifs

- Réactiver les connaissances acquises en POOI.
- Expliquer les caractéristiques de la POO et ses quatre piliers.
- Modéliser puis coder une collaboration polymorphe simple en C#.

## Préalables

- Avoir suivi POOI ou posséder des notions équivalentes sur les classes et les
  objets.
- Avoir accès aux chapitres 1 à 5 des notes.
- Pour la deuxième séance : SDK .NET 10 et environnement C# fonctionnels.

---

## Exercice 1 (E00) — Expliquer la POO et ses quatre piliers

### Objectifs spécifiques

- Rechercher et sélectionner de l'information sur une notion de POO.
- Reformuler une notion dans ses propres mots.
- Distinguer un mécanisme de POO de la syntaxe particulière de C#.
- Communiquer une synthèse courte et répondre aux questions de la classe.

### Préalables spécifiques

- Avoir déjà rencontré les notions de classe et d'objet en POOI.
- Pouvoir consulter les chapitres 2 à 4 des notes et les sources autorisées par
  l'enseignant.
- Pouvoir créer un support d'au plus trois diapositives ou une page
  équivalente.

Aucune maîtrise préalable des quatre piliers n'est attendue : l'exercice sert
aussi de diagnostic.

### Exercice 1.1 — Préparer une mini-présentation

#### Sujet attribué

Une équipe reçoit l'un des cinq sujets suivants :

1. caractéristiques générales de la programmation orientée objet;
2. encapsulation;
3. abstraction;
4. héritage;
5. polymorphisme.

Si la classe compte plus de cinq équipes, certains sujets peuvent être confiés
à deux équipes afin de comparer leurs explications.

#### À faire

Préparez un support d'au plus trois diapositives ou une page équivalente. Votre
présentation doit contenir :

- une définition formulée dans vos propres mots;
- le problème que la notion aide à résoudre;
- un exemple simple en C# ou un petit diagramme;
- un contre-exemple ou une mauvaise utilisation;
- une question à poser à la classe;
- les sources consultées.

Chaque membre doit contribuer à la préparation et prendre la parole pendant la
présentation.

#### Questions directrices

- Quels mots sont indispensables pour expliquer la notion avec précision?
- Quel comportement observable permet de reconnaître cette notion dans du
  code?
- Quelle confusion fréquente faut-il éviter?
- La notion est-elle propre à C# ou appartient-elle à la POO en général?

#### Résultat attendu

- [ ] La définition est formulée dans les mots de l'équipe.
- [ ] L'exemple soutient réellement la définition.
- [ ] Une confusion ou une mauvaise utilisation est expliquée.
- [ ] La distinction entre le mécanisme POO et la syntaxe C# est visible.
- [ ] Les sources sont indiquées.

### Exercice 1.2 — Présenter et faire réagir la classe

#### Avant de commencer

Disposez du support terminé à l'exercice 1.1 et répartissez les prises de
parole.

#### À faire

- 8 minutes au plus pour expliquer et illustrer le sujet;
- 2 minutes pour la question et les échanges;
- remise du support à l'endroit indiqué par l'enseignant.

#### Résultat attendu

- [ ] Chaque membre prend la parole.
- [ ] L'explication est compréhensible sans lire le support mot à mot.
- [ ] La présentation respecte la limite de 10 minutes.
- [ ] La question posée provoque une vérification ou une discussion de la
  notion.

---

## Exercice 2 (E01) — Modéliser une facture polymorphe

### Objectifs spécifiques

- Distinguer une classe d'une interface dans un modèle simple.
- Implanter une interface dans deux classes qui partagent une capacité.
- Exploiter le polymorphisme sans test de type.
- Protéger les invariants des objets et une collection interne.

### Préalables spécifiques

- Classes, objets, constructeurs et propriétés C#.
- Variables d'objet privées et collections `List<T>`.
- Lecture d'un diagramme de classes comprenant une association, des
  multiplicités et une réalisation d'interface.
- SDK .NET 10 installé.

Cet exercice ne demande ni test unitaire, ni injection de dépendances, ni
patron de conception.

### Contexte et matériel de départ

Le projet console fourni dans
`e01-facture-polymorphe/Restaurant.Console` compile, mais ne contient aucune
classe du modèle.

Une facture de restaurant contient plusieurs sortes de lignes facturables.

- Un plat commandé possède un nom, un prix unitaire et une quantité. Son
  montant correspond au prix multiplié par la quantité.
- Des frais de livraison possèdent une distance en kilomètres et un tarif par
  kilomètre. Leur montant correspond à la distance multipliée par le tarif.

Ces deux objets sont différents, mais une facture doit pouvoir demander à
chacun une description et un montant sans tester sa classe concrète.

### Exercice 2.1 — Modéliser les lignes facturables

#### À faire

1. Dessinez un diagramme de classes comprenant `Facture`, `PlatCommande`,
   `FraisLivraison` et une interface au nom révélateur.
2. Indiquez les multiplicités pertinentes et distinguez la réalisation
   d'interface de la relation qui unit la facture à ses lignes.
3. Faites approuver ou comparez votre diagramme avant de commencer le code.

#### Résultat attendu

- [ ] Le type commun est une interface au nom révélateur.
- [ ] Les réalisations d'interface ne portent aucune multiplicité.
- [ ] La relation entre `Facture` et les lignes indique qu'une facture peut
  contenir zéro ou plusieurs lignes.

### Exercice 2.2 — Implanter le modèle

#### Avant de commencer

Disposez d'un diagramme suffisamment stable pour nommer les types, leurs
responsabilités et leurs relations.

#### À faire

1. Codez l'interface afin qu'une ligne fournisse une description et calcule
   son montant.
2. Implantez l'interface dans `PlatCommande` et `FraisLivraison`.
3. Protégez les invariants suivants : nom non vide, prix non négatif, quantité
   strictement positive, distance non négative et tarif non négatif.
4. Codez `Facture` afin qu'elle ajoute des lignes et calcule le total sans
   connaître les classes concrètes.
5. Protégez la collection interne contre les modifications directes.

#### Résultat attendu

- [ ] Chaque type se trouve dans son propre fichier.
- [ ] Les objets protègent leurs propres invariants.
- [ ] `Facture` traite toutes les lignes par le type abstrait commun.
- [ ] Aucun `if`, `switch` ou test de type ne choisit le calcul à effectuer.
- [ ] La collection interne n'est pas modifiable par l'appelant.

### Exercice 2.3 — Valider le comportement

#### Avant de commencer

Le projet doit compiler et les comportements de l'exercice 2.2 doivent être
implantés.

#### À faire

1. Dans `Program.cs`, construisez le scénario suivant :
   - deux plats à 14,50 $ donnent 29,00 $;
   - une livraison de 5 km à 2,50 $ par kilomètre donne 12,50 $;
   - le total attendu est 41,50 $.
2. Affichez chaque ligne ainsi que le total avec `Console.Out.WriteLine`.
3. Depuis le répertoire `semaine-01`, compilez et exécutez avec :

```bash
dotnet run --project e01-facture-polymorphe/Restaurant.Console/Restaurant.Console.csproj
```

#### Résultat attendu

- [ ] Le projet compile sur `net10.0`.
- [ ] Les deux montants intermédiaires sont exacts.
- [ ] Le total affiché vaut 41,50 $.
- [ ] Une même boucle peut afficher toutes les lignes par leur interface.
