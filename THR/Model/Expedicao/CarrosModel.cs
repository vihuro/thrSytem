using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THR.Model.Expedicao
{
    internal class CarrosModel
    {
        private string id;
        private string tipoCarro;
        private string capacidadeCarro;

        public string Id { get => id; set => id = value; }
        public string TipoCarro { get => tipoCarro; set => tipoCarro = value; }
        public string CapacidadeCarro { get => capacidadeCarro; set => capacidadeCarro = value; }
    }
}
