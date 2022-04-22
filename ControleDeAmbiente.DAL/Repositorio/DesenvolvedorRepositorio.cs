using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeAmbiente.DAL.Repositorio
{
    public class DesenvolvedorRepositorio : RepositorioGenerico<Desenvolvedor> , IDesenvolvedorRepositorio
    {
        private readonly Contexto _contexto;
        public DesenvolvedorRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public new IQueryable<Desenvolvedor> PegarTodos()
        {
            try
            {
                var desenvolvedores = _contexto.Desenvolvedor
                   .Include(a => a.TipoDesenvolvedor);

                return desenvolvedores;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
