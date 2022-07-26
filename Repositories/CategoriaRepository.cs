using Lanchonete_ASP_NET_MVC.Db;
using Lanchonete_ASP_NET_MVC.Models;
using Lanchonete_ASP_NET_MVC.Repositories.Interfaces;

namespace Lanchonete_ASP_NET_MVC.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}