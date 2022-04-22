using ControleDeAmbiente.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAmbiente.DAL.Interfaces
{
    public interface IServidorRepositorio : IRepositorioGenerico<Servidor>
    {
        Task<IEnumerable<Servidor>> PegarTodosTeste();
    }
}
