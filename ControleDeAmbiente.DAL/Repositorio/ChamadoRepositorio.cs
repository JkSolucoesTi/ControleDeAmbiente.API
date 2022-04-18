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

        public async Task<Chamado> Detalhes(string numeroChamado)
        {
            try
            {
                return await _contexto
                    .Chamados
                    .Include(a => a.Detalhes)
                    .ThenInclude(a => a.Desenvolvedor)
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
                   .Include(a => a.Ambiente)
                   .Include(a => a.Negocio)
                   .Include(a => a.Detalhes)   
                   .ThenInclude(a => a.Desenvolvedor)
                   .ThenInclude(a => a.TipoDesenvolvedor)
                   ;
                return chamados;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public new async Task<Chamado> PegarPorId(int chamadoId)
        {
            try
            {
                var chamado = await _contexto.Chamados
                   .Include(a => a.Detalhes)
                   .Include(a => a.Ambiente)
                   .ThenInclude(a => a.Desenvolvedor)
                   .Where(a => a.ChamadoId == chamadoId)
                   .FirstOrDefaultAsync();

                return chamado;
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
                    .Include(a => a.Ambiente)
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
