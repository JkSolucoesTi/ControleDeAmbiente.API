﻿
using System;
using ControleDeAmbiente.BLL.Model;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeAmbiente.DAL.Interfaces
{
    public interface IAmbienteRepositorio : IRepositorioGenerico<Ambiente>
    {
        new IQueryable<Ambiente> PegarTodos();

        new Task<Ambiente> PegarPorId(int id);
    }
}
