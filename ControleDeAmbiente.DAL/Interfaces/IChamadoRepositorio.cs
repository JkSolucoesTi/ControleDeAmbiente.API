using ControleDeAmbiente.BLL.Model;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeAmbiente.DAL.Interfaces
{
    public interface IChamadoRepositorio : IRepositorioGenerico<Chamado>
    {
        new IQueryable<Chamado> PegarTodos();
        new Task<Chamado> PegarPorId(int id);
        Task<Chamado> VerificarAlocacao(int ambienteId);
        Task<Chamado> Detalhes(string numeroChamado);

    }
}
