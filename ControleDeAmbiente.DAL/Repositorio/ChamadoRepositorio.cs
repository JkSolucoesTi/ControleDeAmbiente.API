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

        public async Task<Chamado> Detalhes(string numeroChamado, string nomeAmbiente)
        {
            try
            {
                return await _contexto
                    .Chamados
                    .Where(i => i.Numero == numeroChamado)
                    .FirstOrDefaultAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public new IQueryable<Chamado> PegarTodos()
        {
            try
            {
                var chamados = _contexto.Chamados
                   .Include(a => a.Ambiente);
                return chamados;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<Chamado> VerificarAlocacao(int ambienteId)
        {
            try
            {
                var resultado =  _contexto
                    .Chamados
                    .Where(a => a.AmbienteId == ambienteId)
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
