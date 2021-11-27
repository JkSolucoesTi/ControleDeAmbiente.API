using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeAmbiente.DAL.Repositorio
{
    public class ChamadoRepositorio : RepositorioGenerico<Chamado>, IChamadoRepositorio
    {
        private readonly Contexto _contexto;
        public ChamadoRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public new IQueryable<Chamado> PegarTodos()
        {
            try
            {
                var chamados = _contexto.Chamados
                   .Include(a => a.Ambiente)
                   .Include(a => a.Android)
                   .Include(i => i.Ios)
                   .Include(a => a.Web)
                   .Include(n => n.Negocio)
                   .Include(a => a.Api);

                return chamados;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<Chamado> VerificarAlocacao(int ambienteId, int apiId)
        {
            try
            {
                var resultado =  _contexto
                    .Chamados
                    .Include(a => a.Ambiente)
                    .Include(a => a.Api)
                    .Where(i => i.AmbienteId == ambienteId)
                    .Where(i => i.ApiId == apiId)
                    .FirstOrDefault();

                return Task.FromResult(resultado);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
