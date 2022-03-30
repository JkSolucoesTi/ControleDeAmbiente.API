using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ControleDeAmbiente.BLL.Model
{
    public class Desenvolvedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public int TipoDesenvolvedorId { get; set; }
        public TipoDesenvolvedor TipoDesenvolvedor { get; set; }

    }
}
