using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THR.DAO.Expedicao;
using THR.Controller.Expedicao;
using THR.Dto.Expedicao;
using THR.Model.Expedicao;

namespace THR.Service.Expedicao
{
    internal class CarrosService
    {
        private CarrosDao dao;
        public CarrosService()
        {
            dao = new CarrosDao();
        }
        public List<string> Carros()
        {
            return dao.Carros();
        }

        internal string BuscarCapacidade(string caminhao)
        {
            return dao.BuscarCapacidade(caminhao);
        }
    }
}
