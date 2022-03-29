﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.BLL.Model
{
    public class Servidor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Dominio { get; set; }
        public List<Ambiente> Ambientes {get;set;}
    }
}
