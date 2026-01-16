# Prácticas C#

[English](README.md)

Ejercicio de aprendizaje C# por consola con menú para crear, listar, editar y borrar publicaciones.

## Stack

C# · .NET 9.

## Alcance y configuración

Ejecutar desde el directorio que contiene practicas-csharp.csproj. Es una práctica de consola, no una API web.

## Almacenamiento y búsqueda

[PostService](services/post-service.cs) conserva las publicaciones en una `List<Post>` del proceso: al cerrar la aplicación se pierden. La edición y el borrado buscan la primera publicación cuyo título coincide exactamente con el indicado. Este ejercicio no tiene base de datos, persistencia en archivos ni restricción de títulos únicos.

## Desarrollo local

Usar un entorno compatible con el descriptor del proyecto.

```sh
dotnet restore
dotnet build
dotnet run
```

## Repositorios relacionados

- [Atlas API](https://github.com/matigaleanodev/proyecto-atlas-api)
