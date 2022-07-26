using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanchonete_ASP_NET_MVC.Models
{
    [Table("CarrinhoComprasItens")]
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }
        public Lanche Lanche { get; set; }
        public int Quantidade { get; set; }
        
        [StringLength(200)]
        public string CarrinhoCompraId { get; set; }
    }
}