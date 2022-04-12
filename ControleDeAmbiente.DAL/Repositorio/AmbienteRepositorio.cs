using System;
using ControleDeAmbiente.BLL.Model;
using System.Collections.Generic;
using System.Text;
using ControleDeAmbiente.DAL.Interfaces;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ControleDeAmbiente.DAL.Repositorio
{
    public class AmbienteRepositorio : RepositorioGenerico<Ambiente>, IAmbienteRepositorio
    {
        private readonly Contexto _contexto;
        public AmbienteRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public IQueryable<Ambiente> PegarTodosTeste()
        {
            try
            {
                var chamados = _contexto.Ambientes
                    .Include(x => x.Servidor)
                    .Include(x => x.Desenvolvedor);
                return chamados;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Ambiente> ObterPorIdTeste(int id)
        {
            try
            {
                var chamados = await  _contexto.Ambientes
                    .Include(x => x.Servidor)
                    .Include(x => x.Desenvolvedor)
                    .Where(x => x.AmbienteId == id)
                    .FirstOrDefaultAsync();
                return chamados;

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
