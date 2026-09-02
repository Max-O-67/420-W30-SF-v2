# Solution cumulative E03–E04

Le départ compile, mais `ServiceCommandes` construit directement une
notification console. E03 rend cette dépendance injectable. E04 remplace
l'assemblage manuel de `Program.cs` par le conteneur .NET.

```bash
dotnet test S03E03E04_Restaurant_Notification.slnx
```
