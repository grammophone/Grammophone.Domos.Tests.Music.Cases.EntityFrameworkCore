# Grammophone.Domos.Tests.Music.Cases.EntityFrameworkCore

Entity Framework Core MSTest project for the Domos music test application.

This project runs the shared music test cases against the EF Core provider, using LocalDB and Unity configuration from `App.config`.

## Target Framework

- `net8.0`

## Required Projects

This project expects these sibling projects to be available when building from the solution or from extracted submodules:

Direct project references:

- `Grammophone.Domos.Tests.Music.Cases`
- `Grammophone.Domos.Tests.Music.DataAccess.EntityFrameworkCore`

Additional transitive project references:

- `Grammophone.Caching`
- `Grammophone.Configuration`
- `Grammophone.DataAccess`
- `Grammophone.DataAccess.EntityFrameworkCore`
- `Grammophone.Domos.AccessChecking`
- `Grammophone.Domos.Accounting`
- `Grammophone.Domos.DataAccess`
- `Grammophone.Domos.DataAccess.EntityFrameworkCore`
- `Grammophone.Domos.Domain`
- `Grammophone.Domos.Environment`
- `Grammophone.Domos.Logic`
- `Grammophone.Domos.Tests.Music.DataAccess`
- `Grammophone.Domos.Tests.Music.Domain`
- `Grammophone.Domos.Tests.Music.Logic`
- `Grammophone.Email`
- `Grammophone.GenericContentModel`
- `Grammophone.Logging`
- `Grammophone.Serialization`
- `Grammophone.Setup`
- `Grammophone.Storage`
- `Grammophone.Tasks`
- `Grammophone.TemplateRendering`

## Runtime Notes

- Requires SQL Server LocalDB.
- Uses `App.config` for the Unity `musicLogic` configuration section.
- The project copies `App.config` to `testhost.dll.config` and `testhost.exe.config` so `System.Configuration.ConfigurationManager` can load the Unity section during `dotnet test`.
