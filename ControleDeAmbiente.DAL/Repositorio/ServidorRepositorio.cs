using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Repositorio
{
    public class ServidorRepositorio : RepositorioGenerico<Servidor> , IServidorRepositorio
    {
        private readonly Contexto _contexto;
        public ServidorRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
