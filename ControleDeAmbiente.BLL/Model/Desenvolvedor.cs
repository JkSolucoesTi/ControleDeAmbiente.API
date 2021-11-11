using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.BLL.Model
{
    public class Desenvolvedor
    {
        public virtual ICollection<Ambiente> Ambientes { get; set; }
        public string Nome { get; set; }
    }
}
