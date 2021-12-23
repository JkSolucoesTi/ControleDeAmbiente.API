using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.BLL.Model
{
    public class AmbienteChamado
    {
        public int ChamadoId { get; set; }
        public int AmbienteId { get; set; }

        public Chamado Chamado { get; set; }
        public Ambiente Ambiente { get; set; }
    }
}
