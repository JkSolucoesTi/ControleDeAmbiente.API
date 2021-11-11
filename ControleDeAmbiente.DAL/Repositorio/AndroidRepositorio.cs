using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Repositorio
{
    public class AndroidRepositorio : RepositorioGenerico<Android>, IAndroidRepositorio
    {
        private readonly Contexto _contexto;
        public AndroidRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }
    }
}
