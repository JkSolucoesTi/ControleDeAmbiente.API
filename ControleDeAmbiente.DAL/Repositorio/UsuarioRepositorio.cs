using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAmbiente.DAL.Repositorio
{
    public class UsuarioRepositorio : RepositorioGenerico<Usuario>, IUsuarioRepositorio
    {
        private Contexto _contexto;
        public UsuarioRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public Task<Usuario> Login(string login , string senha)
        {
            try
            {
                var usuarioLogado = _contexto.Usuarios
                    .Where(x => x.Login == login)
                    .Where(x => x.Senha == senha)
                    .FirstOrDefault();

                return Task.FromResult(usuarioLogado);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
