using PracticasCsharp.Models;

namespace PracticasCsharp.Services;

public class PostService
{
  private readonly List<Post> _posts = [];

  public void CrearPost(string titulo, string contenido)
  {
    var nuevoPost = new Post(titulo, contenido);
    _posts.Add(nuevoPost);
  }

  public void MostrarPosts()
  {
    if (!_posts.Any())
    {
      Console.WriteLine("⚠️ No hay posts todavía.");
      return;
    }

    foreach (var post in _posts)
    {
      post.Mostrar();
      Console.WriteLine("-------------------------");
    }
  }

  public void EditarPost(string titulo, string nuevoContenido)
  {
    var post = _posts.FirstOrDefault(p => p.Titulo == titulo);
    if (post is not null)
    {
      post.Editar(nuevoContenido);
      Console.WriteLine("✅ Post editado.");
    }
    else
    {
      Console.WriteLine("❌ Post no encontrado.");
    }
  }

  public void BorrarPost(string titulo)
  {
    var post = _posts.FirstOrDefault(p => p.Titulo == titulo);
    if (post is not null)
    {
      _posts.Remove(post);
      Console.WriteLine("🗑️ Post eliminado.");
    }
    else
    {
      Console.WriteLine("❌ Post no encontrado.");
    }
  }
}
