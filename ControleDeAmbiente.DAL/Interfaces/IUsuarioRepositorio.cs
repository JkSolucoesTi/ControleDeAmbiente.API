using ControleDeAmbiente.BLL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAmbiente.DAL.Interfaces
{
    public interface IUsuarioRepositorio : IRepositorioGenerico<Usuario>
    {
        Task<Usuario> Login(string login , string senha);
    }
}
