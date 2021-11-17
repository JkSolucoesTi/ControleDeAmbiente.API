using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Repositorio
{
    public class NegocioRepositorio : RepositorioGenerico<Negocio>, INegocioRepositorio
    {
        private readonly Contexto _contexto;
        public NegocioRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
