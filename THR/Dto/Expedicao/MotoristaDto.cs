using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THR.Dto.Expedicao
{
    internal class MotoristaDto
    {
        private string id;
        private string nomeMotorista;

        public string Id { get => id; set => id = value; }
        public string NomeMotorista { get => nomeMotorista; set => nomeMotorista = value; }
    }
}
