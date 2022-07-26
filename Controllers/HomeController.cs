using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lanchonete_ASP_NET_MVC.Models;
using Lanchonete_ASP_NET_MVC.Repositories.Interfaces;
using Lanchonete_ASP_NET_MVC.ViewModels;

namespace Lanchonete_ASP_NET_MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILancheRepository  _repository;

    public HomeController(ILancheRepository  repository)
    {
        _repository = repository;
    }

    public IActionResult Index()
    {
        var homeViewModel = new HomeViewModel()
        {
            LanchesPreferidos = _repository.LanchesPreferidos
        };
        return View(homeViewModel);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
