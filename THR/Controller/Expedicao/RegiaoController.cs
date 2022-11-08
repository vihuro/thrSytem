using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THR.Service.Expedicao;
using THR.Dto.Expedicao;

namespace THR.Controller.Expedicao
{
    internal class RegiaoController
    {
        private RegiaoService service;
        public RegiaoController()
        {
            service = new RegiaoService();
        }
        public List<string> Regiao()
        {
            return service.Regiao();
        }
    }
}
