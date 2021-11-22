using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Repositorio
{
    public class ApiRepositorio : RepositorioGenerico<Api>, IApiRepositorio
    {
        private readonly Contexto _contexto;
        public ApiRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
