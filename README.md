# Prácticas C#

[Español](README.es.md)

C# console learning exercise with a menu to create, list, edit and delete posts.

## Stack

C# · .NET 9.

## Scope and configuration

Run from the directory containing practicas-csharp.csproj. This is a console practice project, not a web API.

## Storage and lookup

[PostService](services/post-service.cs) keeps posts in a process-local `List<Post>`: closing the application discards them. Editing and deletion search for the first post whose title exactly matches the supplied title. This exercise has no database, file persistence or uniqueness constraint on titles.

## Local development

Use a toolchain compatible with the project descriptor.

```sh
dotnet restore
dotnet build
dotnet run
```

## Related repositories

- [Atlas API](https://github.com/matigaleanodev/proyecto-atlas-api)
