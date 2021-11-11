using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Repositorio
{
    public class IosRepositorio : RepositorioGenerico<Ios> , IIosRepositorio
    {
        private readonly Contexto _contexto;
        public IosRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
