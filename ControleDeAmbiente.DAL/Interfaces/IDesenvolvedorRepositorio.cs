using ControleDeAmbiente.BLL.Model;
using System.Linq;

namespace ControleDeAmbiente.DAL.Interfaces
{
    public interface IDesenvolvedorRepositorio : IRepositorioGenerico<Desenvolvedor>
    {
        new IQueryable<Desenvolvedor> PegarTodos();
    }
}
