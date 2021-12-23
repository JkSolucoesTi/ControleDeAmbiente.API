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
    public class AmbienteChamadoRepositorio : RepositorioGenerico<AmbienteChamado> , IAmbienteChamadoRepositorio
    {
        private readonly Contexto _contexto;
        public AmbienteChamadoRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<AmbienteChamado> PegarTodosTeste()
        {
            try
            {
                var chamados = 
                     _contexto.AmbienteChamado
                    .Include(c => c.Chamado)
                    .ToList();

                return chamados;


            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
