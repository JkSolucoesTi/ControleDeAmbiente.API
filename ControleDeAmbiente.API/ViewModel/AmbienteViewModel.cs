using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeAmbiente.API.ViewModel
{
    public class AmbienteViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Chamado { get; set; }
        public string Descricao { get; set; }
        public int ApiId { get; set; }
        public int WebId { get; set; }
        public int IosId { get; set; }
        public int AndroidId { get; set; }
        public int NegocioId { get; set; }
    }
}
