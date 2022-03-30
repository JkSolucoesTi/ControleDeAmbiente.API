using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Interfaces
{
    public class TipoDesenvolvedorRepositorio : RepositorioGenerico<TipoDesenvolvedor> , ITipoDesenvolvedorRepositorio
    {
        private readonly Contexto _contexto;
        public TipoDesenvolvedorRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
