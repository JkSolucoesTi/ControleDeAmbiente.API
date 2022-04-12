using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.BLL.Model
{
    public class Ambiente
    {
        public int AmbienteId { get; set; }
        public string Nome { get; set; }
        public string Acesso { get; set; }
        public int DesenvolvedorId { get; set; }
        public Desenvolvedor Desenvolvedor { get; set; }
        public int ServidorId { get; set; }
        public Servidor Servidor { get; set; }
    }
}
