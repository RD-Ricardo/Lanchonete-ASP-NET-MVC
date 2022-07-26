using Lanchonete_ASP_NET_MVC.Models;

namespace Lanchonete_ASP_NET_MVC.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias{ get;  }
    }
}