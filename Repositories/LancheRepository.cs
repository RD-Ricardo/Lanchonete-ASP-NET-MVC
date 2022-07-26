using Lanchonete_ASP_NET_MVC.Db;
using Lanchonete_ASP_NET_MVC.Models;
using Lanchonete_ASP_NET_MVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lanchonete_ASP_NET_MVC.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(x => x.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(x => x.IsLanchePreferido).Include(x => x.Categoria);

        public Lanche GetLancheById(int lancheId) => _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        
    }
}