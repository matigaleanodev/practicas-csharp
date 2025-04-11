using PracticasCsharp.Services;

var postService = new PostService();
bool salir = false;

while (!salir)
{
    Console.WriteLine("📘 Menú de Posts");
    Console.WriteLine("1. Crear post");
    Console.WriteLine("2. Mostrar posts");
    Console.WriteLine("3. Editar post");
    Console.WriteLine("4. Borrar post");
    Console.WriteLine("0. Salir");
    Console.Write("Opción: ");
    var opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Título: ");
            var titulo = Console.ReadLine() ?? "";
            Console.Write("Contenido: ");
            var contenido = Console.ReadLine() ?? "";
            postService.CrearPost(titulo, contenido);
            break;
        case "2":
            postService.MostrarPosts();
            break;
        case "3":
            Console.Write("Título del post a editar: ");
            var tituloEditar = Console.ReadLine() ?? "";
            Console.Write("Nuevo contenido: ");
            var nuevoContenido = Console.ReadLine() ?? "";
            postService.EditarPost(tituloEditar, nuevoContenido);
            break;
        case "4":
            Console.Write("Título del post a borrar: ");
            var tituloBorrar = Console.ReadLine() ?? "";
            postService.BorrarPost(tituloBorrar);
            break;
        case "0":
            salir = true;
            break;
        default:
            Console.WriteLine("❌ Opción inválida.");
            break;
    }

    Console.WriteLine("\nPresioná ENTER para continuar...");
    Console.ReadLine();
    Console.Clear();
}
