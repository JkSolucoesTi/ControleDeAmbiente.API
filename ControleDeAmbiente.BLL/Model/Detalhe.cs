using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.BLL.Model
{
    public class Detalhe
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public int ChamadoId { get; set; }
        public int DesenvolvedorId { get; set; }
        public Desenvolvedor Desenvolvedor { get; set; }
        public int NegocioId { get; set; }
        public Negocio Negocio { get; set; }

    }
}
