using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THR.Dto.Login
{
    internal class ModuloDto
    {
        private string id;
        private string apelido;
        private string modulo;
        private string nivel;

        public string Id { get => id; set => id = value; }
        public string Apelido { get => apelido; set => apelido = value; }
        public string Modulo { get => modulo; set => modulo = value; }
        public string Nivel { get => nivel; set => nivel = value; }
    }
}
