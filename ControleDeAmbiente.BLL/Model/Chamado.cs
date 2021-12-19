using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.BLL.Model
{
    public class Chamado
    {
        public int Id { get; set; }        
        public string Numero { get; set; }
        public int AmbienteId { get; set; }
        public Ambiente Ambiente { get; set; }
        public int ApiId { get; set; }
        public Api Api { get; set; }

        public int WebId { get; set; }
        public Web Web { get; set; }

        public string ChamadoWeb { get; set; }

        public int IosId { get; set; }
        public Ios Ios { get; set; }
        public string ChamadoIos { get; set; }

        public int AndroidId { get; set; }
        public Android Android { get; set; }
        public string ChamadoAndroid { get; set; }

        public int NegocioId { get; set; }
        public Negocio Negocio { get; set; }

    }
}
