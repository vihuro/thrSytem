using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THR.Dto.Expedicao
{
    internal class RegiaoDto
    {
        private string id;
        private string regiao;

        public string Id { get => id; set => id = value; }
        public string Regiao { get => regiao; set => regiao = value; }
    }
}
