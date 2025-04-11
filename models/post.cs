namespace PracticasCsharp.Models;

public class Post
{
    public string Titulo { get; private set; }
    public string Contenido { get; private set; }
    public DateTime FechaCreacion { get; private set; }

    public Post(string titulo, string contenido)
    {
        Titulo = titulo;
        Contenido = contenido;
        FechaCreacion = DateTime.Now;
    }

    public void Mostrar()
    {
        Console.WriteLine($"📌 {Titulo} - {FechaCreacion}");
        Console.WriteLine(Contenido);
    }

    public void Editar(string nuevoContenido)
    {
        Contenido = nuevoContenido;
    }
}
