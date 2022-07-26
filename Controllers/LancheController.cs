using Lanchonete_ASP_NET_MVC.Repositories.Interfaces;
using Lanchonete_ASP_NET_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lanchonete_ASP_NET_MVC.Controllers
{
    public class LancheController : Controller
    {

        private readonly ILancheRepository _repository;
        public LancheController(ILancheRepository repository)
        {
            _repository = repository;
        }
        public IActionResult List()
        {
            var lanchesListViewModel = new LanchesListViewModel()
            {
                Lanches = _repository.Lanches,
                CategoriaAtual = "Categoria Atual"
            };
            return View(lanchesListViewModel);
        }
    }
}