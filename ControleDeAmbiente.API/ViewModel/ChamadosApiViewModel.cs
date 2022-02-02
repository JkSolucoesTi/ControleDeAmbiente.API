using ControleDeAmbiente.BLL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeAmbiente.API.ViewModel
{
    public class ChamadosApiViewModel
    {
        public ChamadosApiViewModel()
        {
            Ambientes = new Ambiente();
        }
        public Ambiente Ambientes { get; set; }
        public List<Chamado> Chamados { get; set; }

    }

    public class ChamadoApi
    {
        public ChamadoApi()
        {
            ListaDeChamadosPorAmbiente = new List<ChamadosApiViewModel>();
        }
        public List<ChamadosApiViewModel> ListaDeChamadosPorAmbiente { get; set; }


    }
}


