# Exemples des diapositives — semaine 2

Ces solutions reprennent les exemples de restauration utilisés dans les
diapositives sur les tests unitaires, le TDD, les doublures manuelles et Moq.
Elles sont séparées afin que chaque étape introduise seulement les dépendances
nécessaires.

## Progression

| Répertoire | Notions illustrées | Dépendances de test |
|---|---|---|
| `01_tests_sans_dependance` | AAA, nom des tests, théorie, exception et cycle TDD | xUnit |
| `02_espion_manuel` | interface, injection par constructeur et espion écrit à la main | xUnit |
| `03_moq` | `Setup`, `.Object`, `Verify`, `Times.Once`, `Times.Never` et `VerifyNoOtherCalls` | xUnit et Moq |

Chaque solution contient un projet principal et un projet de tests. Le projet
de tests référence le projet principal. Moq est installé uniquement dans le
projet de tests du troisième exemple.

## Exemple 1 — Tests sans dépendance et TDD

La classe `LigneCommande` correspond au premier cas présenté dans les
diapositives. Les tests montrent :

- un premier test structuré avec Arranger, Agir et Auditer;
- l'approche du cours avec `[Theory]`, `InlineData`, des constantes `double` et
  leur conversion explicite en `decimal`;
- la même règle avec `MemberData`, qui permet de fournir directement des
  valeurs `decimal`;
- la vérification du type et du `ParamName` d'une exception.

Les deux théories sont volontairement conservées côte à côte. Elles testent la
même règle afin de comparer les mécanismes de fourniture des données, et non
parce que la duplication serait nécessaire dans une suite de production.

`FactureTests.SousTotal_DeuxLignes_RetourneSomme` correspond à la pseudo-démo
TDD. Le dépôt conserve la version finale verte. Pour rejouer la séquence :

1. remplacez temporairement le calcul de `Facture.SousTotal` par `return 0m;`;
2. exécutez le test pour observer l'étape rouge;
3. implantez la boucle `foreach` présentée dans les diapositives et relancez
   toute la suite pour obtenir l'étape verte;
4. remplacez la boucle par `m_lignes.Sum(ligne => ligne.Total)` et relancez les
   tests pour valider le réusinage.

## Exemple 2 — Espion manuel

`ServiceCommande` dépend de `IExpediteurCuisine`. Le test lui fournit un
`ExpediteurCuisineEspion`, qui enregistre le nombre d'appels et la dernière
commande reçue. Le cas valide vérifie un envoi; le cas d'une commande vide
vérifie l'exception et l'absence d'envoi.

## Exemple 3 — Moq

Les tests de `ServiceCommande` reprennent les cas de confirmation et de refus
présentés dans les diapositives. Le test de `ServiceDisponibilitePlat` complète
le fragment sur `Setup` avec une petite unité testable : la réponse configurée
est consommée par un vrai service, puis l'appel est audité.

## Exécuter un exemple

Placez-vous dans le répertoire de la solution choisie, puis exécutez :

```bash
dotnet restore
dotnet test
```

Les projets ciblent .NET 10 et restent compatibles avec C# 10.

## Correspondance avec les diapositives

Les comportements, les données et les observations des diapositives sont
conservés : total de `24.00m`, jeux de données `InlineData`, exception sur
`quantite`, sous-total de `17.00m`, espion manuel, confirmation valide,
commande vide, `Setup`, `Verify`, `Times.Once`, `Times.Never` et
`VerifyNoOtherCalls`.

Trois compléments sont intentionnels et ne changent pas ces scénarios :

- la variante `MemberData` demandée en plus de la variante `InlineData`;
- la validation de la description et du prix dans `LigneCommande`;
- `ServiceDisponibilitePlat`, qui permet d'exécuter le fragment `Setup` à
  travers une véritable unité testée.

> [!NOTE]
> La `LigneCommande` de ces exemples conserve volontairement le contrat court
> montré dans les diapositives. La solution cumulative des exercices E03 à E05
> possède un contrat plus complet, notamment le pourcentage de rabais.
