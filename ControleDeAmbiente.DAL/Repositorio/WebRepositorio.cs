using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Repositorio
{
    public class WebRepositorio : RepositorioGenerico<Web>, IWebRepositorio
    {
        private readonly Contexto _contexto;
        public WebRepositorio(Contexto contexto) :base(contexto)
        {
            _contexto = contexto;
        }
    }
}
