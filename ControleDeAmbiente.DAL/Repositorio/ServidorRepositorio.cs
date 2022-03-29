using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeAmbiente.DAL.Repositorio
{
    public class ServidorRepositorio : RepositorioGenerico<Servidor> , IServidorRepositorio
    {
        private readonly Contexto _contexto;
        public ServidorRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public async Task<IEnumerable<Servidor>> PegarTodosTeste()
        {
            try
            {
                var chamados = await _contexto.Servidor
                    .Include(x => x.Ambientes).ToListAsync();
                return chamados;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
