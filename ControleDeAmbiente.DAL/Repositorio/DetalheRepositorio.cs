using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Repositorio
{
    public class DetalheRepositorio : RepositorioGenerico<Detalhe>, IDetalheRepositorio
    {
        private readonly Contexto _contexto;
        public DetalheRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
