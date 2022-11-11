using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THR.Dto.Expedicao;
using THR.Service.Expedicao;

namespace THR.Controller.Expedicao
{
    internal class CarrosController
    {
        private CarrosService service;
        public CarrosController()
        {
            service = new CarrosService();
        }
        public List<string> Carros()
        {
            return service.Carros();
        }
    }
}
