using Lanchonete_ASP_NET_MVC.Models;

namespace Lanchonete_ASP_NET_MVC.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}