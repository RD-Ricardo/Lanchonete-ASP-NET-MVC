using Lanchonete_ASP_NET_MVC.Models;
using Lanchonete_ASP_NET_MVC.Repositories.Interfaces;
using Lanchonete_ASP_NET_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lanchonete_ASP_NET_MVC.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ILancheRepository lancheRepository,CarrinhoCompra carrinhoCompra)
        {
            _carrinhoCompra = carrinhoCompra;
            _lancheRepository = lancheRepository;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraViewModel = new  CarrinhoCompraViewModel()
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };
            return View(carrinhoCompraViewModel);
        }

        public RedirectToActionResult AdicionarItemCarrinhoCompra(int lancheId)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault( p=> p.LancheId == lancheId);

            if(lancheSelecionado != null)
            {   
                _carrinhoCompra.AdicionarAoCarrinho(lancheSelecionado);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoverItemCarrinhoCompra(int lancheId)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault( p=> p.LancheId == lancheId);

            if(lancheSelecionado != null)
            {   
                _carrinhoCompra.RemoverCarrinho(lancheSelecionado);
            }
            return RedirectToAction("Index");
        }
    }
}