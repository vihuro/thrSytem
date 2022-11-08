using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THR.Service.Expedicao;

namespace THR.Controller.Expedicao
{
    internal class MotoristaController
    {
        private MotoristaService service;
        public MotoristaController()
        {
            service = new MotoristaService();
        }

        public List<string> Motorista()
        {
            return service.Motoristas();
        }
    }
}
