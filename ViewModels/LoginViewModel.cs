using System.ComponentModel.DataAnnotations;

namespace Lanchonete_ASP_NET_MVC.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Usuário")]
        public string  UserName { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string  Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}