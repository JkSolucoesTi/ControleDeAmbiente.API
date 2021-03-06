using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.BLL.Model
{
    public class Chamado
    {
        public int ChamadoId { get; set; }        
        public string Numero { get; set; }
        public string Descricao { get; set; }
        public int NegocioId { get; set; }
        public Negocio Negocio { get; set; }
        public int AmbienteId { get; set; }
        public Ambiente Ambiente { get; set; }
        public List<Detalhe> Detalhes { get; set; }
        public bool Ativo { get; set; }

    }
}
