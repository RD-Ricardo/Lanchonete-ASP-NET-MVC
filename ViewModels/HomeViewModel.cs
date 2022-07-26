using Lanchonete_ASP_NET_MVC.Models;

namespace Lanchonete_ASP_NET_MVC.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}