using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanchonete_ASP_NET_MVC.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required]
        [Display(Name = "Nome do Lanche")]
        [StringLength(80, MinimumLength = 10 , ErrorMessage = "O {0} deve ter no mínimo {1} e no maximo")]
        public string Nome { get; set; }
        
        [Required]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20)]
        [MaxLength(200)]
        public string  DescricaoCurta { get; set; }
        [Required]
        [Display(Name = "Descrição do Lanche")]
        [MinLength(20)]
        [MaxLength(200)]
        public string  DescricaoLonga { get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range (1,999.99,ErrorMessage = "o {0} deve ter no máximo {1} caracteres")]
        public decimal  Preco { get; set; }

        [Display(Name = "Caminho Imagem normal")]
        [StringLength(200, ErrorMessage = "o {0} deve ter no máximo {1] caracteres")]
        public string  ImagemUrl { get; set; }
        
        [Display(Name = "Caminho Imagem normal")]
        [StringLength(200, ErrorMessage = "o {0} deve ter no máximo {1] caracteres")]
        public string  ImaagemThumbnaiUrl { get; set; }
        
        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Em estoque")]
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}