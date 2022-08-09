using Lanchonete_ASP_NET_MVC.Db;
using Lanchonete_ASP_NET_MVC.Models;
using Lanchonete_ASP_NET_MVC.Repositories.Interfaces;

namespace Lanchonete_ASP_NET_MVC.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {   
        private  readonly AppDbContext _context;
        private  readonly CarrinhoCompra _carrinhoCompra;
        public PedidoRepository(AppDbContext context, CarrinhoCompra carrinhoCompra)
        {
            _context = context;
            _carrinhoCompra = carrinhoCompra;
        }

        public void CriarPedido(Pedido pedido)
        {
            pedido.PedidoEnviado = DateTime.Now;
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();

            var carrinhoCompraItens  = _carrinhoCompra.CarrinhoCompraItems;

            foreach (var carrinhoItem in carrinhoCompraItens)
            {
                var pedidoDetail =  new PedidoDetalhe()
                {
                    Quantidade = carrinhoItem.Quantidade,
                    LancheId = carrinhoItem.Lanche.LancheId,
                    PedidoId = pedido.PedidoId,
                    Preco = carrinhoItem.Lanche.Preco  
                };
                _context.PedidoDetalhes.Add(pedidoDetail);
            }
            _context.SaveChanges();
        }
    }
}