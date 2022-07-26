using Lanchonete_ASP_NET_MVC.Models;

namespace Lanchonete_ASP_NET_MVC.ViewModels
{
    public class LanchesListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string CategoriaAtual { get; set; }
    }
}