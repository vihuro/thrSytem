using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THR.Dto.Expedicao;
using THR.Model.Expedicao;
using THR.DAO.Expedicao;

namespace THR.Service.Expedicao
{
    internal class RegiaoService
    {
        private RegiaoDto dto;
        private RegiaoModel model;
        private RegiaoDao dao;
        public RegiaoService()
        {
            dao = new RegiaoDao();
        }
        public List<string> Regiao()
        {
            return dao.Regiao();
        }
    }
}
