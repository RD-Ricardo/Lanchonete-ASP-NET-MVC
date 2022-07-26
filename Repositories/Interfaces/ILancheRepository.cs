using Lanchonete_ASP_NET_MVC.Models;

namespace Lanchonete_ASP_NET_MVC.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches {get;}
        IEnumerable<Lanche> LanchesPreferidos {get;}
        Lanche GetLancheById(int lancheId);
    }
}