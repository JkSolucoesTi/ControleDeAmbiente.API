using ControleDeAmbiente.BLL.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeAmbiente.DAL.Interfaces
{
    public interface IAmbienteRepositorio : IRepositorioGenerico<Ambiente>
    {
        new IQueryable<Ambiente> PegarTodos();

        Task<IQueryable<IEnumerable<Ambiente>>> PegarTodosTeste();

        new Task<Ambiente> PegarPorId(int id);
    }
}
