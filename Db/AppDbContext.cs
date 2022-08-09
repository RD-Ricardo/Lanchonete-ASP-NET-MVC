using Lanchonete_ASP_NET_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Lanchonete_ASP_NET_MVC.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }
        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}