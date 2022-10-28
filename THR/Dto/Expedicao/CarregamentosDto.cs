using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THR.Dto.Expedicao
{
    internal class CarregamentosDto
    {
        private string numeroCarregamento;
        private string numeroRomaneio;
        private string nomeMotorista;
        private string regiao;
        private string periodo;
        private string bolha;
        private string ondulado;
        private string usuarioLancamento;
        private string dataHoraLancamento;
        private string status;
        private string usuarioFinalizacao;
        private string dataHoraFinalizacao;
        private string pesoTotal;

        public string NumeroCarregamento { get => numeroCarregamento; set => numeroCarregamento = value; }
        public string NumeroRomaneio { get => numeroRomaneio; set => numeroRomaneio = value; }
        public string NomeMotorista { get => nomeMotorista; set => nomeMotorista = value; }
        public string Regiao { get => regiao; set => regiao = value; }
        public string Periodo { get => periodo; set => periodo = value; }
        public string Bolha { get => bolha; set => bolha = value; }
        public string Ondulado { get => ondulado; set => ondulado = value; }
        public string UsuarioLancamento { get => usuarioLancamento; set => usuarioLancamento = value; }
        public string DataHoraLancamento { get => dataHoraLancamento; set => dataHoraLancamento = value; }
        public string Status { get => status; set => status = value; }
        public string UsuarioFinalizacao { get => usuarioFinalizacao; set => usuarioFinalizacao = value; }
        public string DataHoraFinalizacao { get => dataHoraFinalizacao; set => dataHoraFinalizacao = value; }
        public string PesoTotal { get => pesoTotal; set => pesoTotal = value; }
    }
}
