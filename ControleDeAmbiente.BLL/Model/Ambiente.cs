using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.BLL.Model
{
    public class Ambiente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Chamado { get; set; }        
        public string Descricao { get; set; }
        
        public int ApiId { get; set; }
        public Api Api { get; set; }

        public int IosId { get; set; }
        public Ios Ios{ get; set; }

        public int AndroidId { get; set; }
        public Android Android{ get; set; }
    }
}
