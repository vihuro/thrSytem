using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THR.DAO.Expedicao;
using THR.Dto.Expedicao;
using THR.Model.Expedicao;

namespace THR.Service.Expedicao
{
    internal class MotoristaService
    {
        private MotoristaDto dto;
        private MotoristasModel model;
        private MotoristaDao dao;
        public MotoristaService()
        {
            dao = new MotoristaDao();
        }
        public List<string> Motoristas()
        {
            return dao.Motorista();
        }
    }
}
