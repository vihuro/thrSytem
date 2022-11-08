using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THR.Model.Expedicao
{
    internal class CoresPainelControleCarregamentosModel
    {
        private string id;
        private string coluna;
        private string palavraChave;
        private string condicao;
        private string valor;
        private string rCelula;
        private string gCelula;
        private string bCelula;
        private string rLetra;
        private string gLetra;
        private string bLetra;
        private string usuarioCadastro;
        private string dataHoraCadastro;

        public string Id { get => id; set => id = value; }
        public string Coluna { get => coluna; set => coluna = value; }
        public string PalavraChave { get => palavraChave; set => palavraChave = value; }
        public string Condicao { get => condicao; set => condicao = value; }
        public string Valor { get => valor; set => valor = value; }
        public string RCelula { get => rCelula; set => rCelula = value; }
        public string GCelula { get => gCelula; set => gCelula = value; }
        public string BCelula { get => bCelula; set => bCelula = value; }
        public string RLetra { get => rLetra; set => rLetra = value; }
        public string GLetra { get => gLetra; set => gLetra = value; }
        public string BLetra { get => bLetra; set => bLetra = value; }
        public string UsuarioCadastro { get => usuarioCadastro; set => usuarioCadastro = value; }
        public string DataHoraCadastro { get => dataHoraCadastro; set => dataHoraCadastro = value; }
    }
}
