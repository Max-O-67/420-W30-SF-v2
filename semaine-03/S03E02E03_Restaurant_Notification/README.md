# Solution cumulative E02–E03

Le départ compile, mais `ServiceCommandes` construit directement une
notification console. E02 rend cette dépendance injectable. E03 remplace
l'assemblage manuel de `Program.cs` par le conteneur .NET.

```bash
dotnet test S03E02E03_Restaurant_Notification.slnx
```
