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

        public async Task<IQueryable<IEnumerable<Ambiente>>> PegarTodosTeste()
        {
            try
            {
                var chamados = await _contexto.Ambientes.ToListAsync();
                return (IQueryable<IEnumerable<Ambiente>>)chamados;

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
