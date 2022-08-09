using Lanchonete_ASP_NET_MVC.Models;
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
        public IActionResult List(string categoria)
        {
            IEnumerable<Lanche> lanches;

            string categoriaAtual  = string.Empty;

            if(string.IsNullOrEmpty(categoria))
            {
                lanches = _repository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os Lanches";
            }
            else
            {
                // if(string.Equals("Normal", categoria, StringComparison.OrdinalIgnoreCase))
                // {
                //     lanches = _repository.Lanches
                //     .Where(l => l.Categoria.CategoriaNome.Equals("Normal"))
                //     .OrderBy(l => l.Nome);
                // }
                // else
                // {
                //     lanches = _repository.Lanches
                //     .Where(l => l.Categoria.CategoriaNome.Equals("Natural"))
                //     .OrderBy(l => l.Nome);
                // }

                lanches = _repository.Lanches
                    .Where(x => x.Categoria.CategoriaNome.Equals(categoria))
                    .OrderBy(x => x.Nome);
                categoriaAtual = categoria;
            }

            var lanchesListViewModel = new LanchesListViewModel()
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual                                 
            };

            return View(lanchesListViewModel);
        }

        public IActionResult Details(int lancheId)
        {   
            var lanche = _repository.Lanches.FirstOrDefault(x => x.LancheId == lancheId);
            return View(lanche);
        }


        public ViewResult Search(string searchString)
        {
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if(string.IsNullOrEmpty(searchString))
            {
                lanches = _repository.Lanches.OrderBy(p => p.LancheId);
                categoriaAtual = "Todos os Lanches";
            }
            else
            {
                lanches = _repository.Lanches.Where(p => p.Nome.ToLower().Contains(searchString.ToLower()));

                if(lanches.Any())
                    categoriaAtual =  "Lanches";
                else
                    categoriaAtual = "Nenhum lanhce foi encontrado"; 
            }
             return View("~/Views/Lanche/List.cshtml", new LanchesListViewModel
                {
                    Lanches= lanches,
                    CategoriaAtual = categoriaAtual
                });
        }
    }
}