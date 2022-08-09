using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanchonete_ASP_NET_MVC.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o sobrenome")]
        [StringLength(50)]
        public string  Sobrenome { get; set; }

        [Required(ErrorMessage = "Informe o endereço")]
        [StringLength(50)]
        [Display(Name = "Endereço")]
        public string  Endereco1 { get; set; }
        
        [StringLength(50)]
        [Display(Name = "Endereço")]        
        public string  Endereco2 { get; set; }

        [Required(ErrorMessage = "Informe o cep")]
        [StringLength(10)]
        [Display(Name = "Cep")]
        public string Cep { get; set; }

        [StringLength(10)]
        public string  Estado { get; set; }
    
        [StringLength(50)]
        public string  Cidade { get; set; }

        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Total do Pedido")]
        public decimal PedidoTotal { get; set; }   

        [ScaffoldColumn(false)]
        [Display(Name = "Itens do Pedido")]
        public int TotalItensPedido { get; set; }   

        [Display(Name = "Data do pedido")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime? PedidoEnviado { get; set; }

        [Display(Name = "Data Envio pedido")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = false)]
        public DateTime? PedidoEntregueEm { get; set; }

        public List<PedidoDetalhe> PedidoItens {get;set;}
    }
}