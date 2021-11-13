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

        public new async Task<Ambiente> PegarPorId(int id)
        {
            try
            {
                return await _contexto.Ambientes.Include(a => a.Android)
                    .Include(i => i.Ios).Include(a => a.Api)
                    .FirstOrDefaultAsync(ab => ab.Id == id);
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        public new IQueryable<Ambiente> PegarTodos()
        {
            try
            {
                var ambiente = _contexto.Ambientes
                   .Include(a => a.Android)
                   .Include(i => i.Ios)
                   .Include(a => a.Api);


                return ambiente;
                    
            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
}
