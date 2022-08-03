using Lanchonete_ASP_NET_MVC.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lanchonete_ASP_NET_MVC.components
{
    public class CategoriaMenu: ViewComponent
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaMenu(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        public IViewComponentResult Invoke()
        {
            var categoria = _repository.Categorias.OrderBy(c => c.CategoriaNome);
            return View(categoria);
        }
    }
}