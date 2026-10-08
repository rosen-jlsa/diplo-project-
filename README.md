# Diplomatic Mission Management System

A C# console application for managing diplomats and missions. The main menu in `Program.cs` provides diplomat management, mission management, and reports and search using LINQ.

## Requirements

- .NET 10 SDK (the project targets `net10.0`)

## Run locally

```bash
dotnet run --project DiplomaticMission.csproj
```

Run the command from the repository root. The application opens an interactive console menu.

## Repository layout

- `Models/` — domain models.
- `Services/` — application services and service interface.
- `Exceptions/` — custom exceptions.
- `Program.cs` — console entry point and menus.

The repository also contains SQL files for books, readers, and loans. These are separate sample files; the console application's entry point is focused on diplomats and missions.
