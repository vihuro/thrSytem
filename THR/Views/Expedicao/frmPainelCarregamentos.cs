using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THR.Controller.Expedicao;
using THR.Dto.Login;
using THR.Service.CustonException;
using THR.Views.Message;
using THR.Service;
using THR.Service.Expedicao;

namespace THR.Views.Expedicao
{
    public partial class frmPainelCarregamentos : Form
    {
        private CarregamentosController controller;
        private MessageCuston messageCuston;
        private CoresPainelControleCarregamentosService coresService;
        private CarregamentosService service;
        public frmPainelCarregamentos(LoginDto dto, DataTable dt)
        {
            InitializeComponent();
            controller = new CarregamentosController(dto, dt);
            messageCuston = new MessageCuston();
            coresService = new CoresPainelControleCarregamentosService(dto);
            service = new CarregamentosService(dto, dt);

        }

        private void frmPainelCarregamentos_Load(object sender, EventArgs e)
        {
            LoadGridView();
            VerificarCoresBancoDados();
            dataGridView1.ClearSelection();
            timer1.Start();
        }

        private void VerificarCoresBancoDados()
        {
            var dataTable = coresService.SelectTableColors();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                var linha = dataTable.Select($"Coluna = '{dataGridView1.Columns[i].DataPropertyName}'");

                if (linha.Count() > 0)
                {
                    for (int j = 0; j < linha.Count(); j++)
                    {
                        int R = Convert.ToInt32(linha[j]["RCelula"]);
                        int G = Convert.ToInt32(linha[j]["GCelula"]);
                        int B = Convert.ToInt32(linha[j]["BCelula"]);

                        int RLetra = Convert.ToInt32(linha[j]["RLetra"]);
                        int GLetra = Convert.ToInt32(linha[j]["GLetra"]);
                        int BLetra = Convert.ToInt32(linha[j]["BLetra"]);

                        if (dataGridView1.Columns[i].DataPropertyName == "PesoTotal")
                        {
                            ColorirDataGridCondicaoPeso(dataGridView1.Columns[i].DataPropertyName,
                                                    linha[j]["Condicao"].ToString(),
                                                    linha[j]["Valor"].ToString(),
                                                    R, G, B,
                                                    RLetra, GLetra, BLetra);
                        }
                        else if (dataGridView1.Columns[i].DataPropertyName == "TempoEspera")
                        {
                            ColorirDataGridCondicaoTempo(dataGridView1.Columns[i].DataPropertyName,
                                                        linha[j]["Condicao"].ToString(),
                                                        linha[j]["Valor"].ToString(),
                                                        R, G, B,
                                                        RLetra, GLetra, BLetra);
                        }
                        else if (dataGridView1.Columns[i].DataPropertyName == "Status")
                        {
                            CarregarImagemStatus();
                            ColorirStatus(dataGridView1.Columns[i].DataPropertyName,
                                                        linha[j]["PalavraChave"].ToString(),
                                                        R, G, B,
                                                        RLetra, GLetra, BLetra);
                        }
                        else if (dataGridView1.Columns[i].DataPropertyName == "PorcentagemCarregada")
                        {
                            ColorirPorcentagem(dataGridView1.Columns[i].DataPropertyName,
                                                    linha[j]["Condicao"].ToString(),
                                                    linha[j]["Valor"].ToString(),
                                                    R, G, B,
                                                    RLetra, GLetra, BLetra);
                        }
                        else if(dataGridView1.Columns[i].DataPropertyName == "Periodo")
                        {
                            CarregarImagemPeriodo();
                            ColorirPeriodo(dataGridView1.Columns[i].DataPropertyName,
                                                        linha[j]["PalavraChave"].ToString(),
                                                        R, G, B,
                                                        RLetra, GLetra, BLetra);
                        }
                        else if(dataGridView1.Columns[i].DataPropertyName == "DataHoraLancamento")
                        {
                            ColorirDataHoraLancamento(dataGridView1.Columns[i].DataPropertyName,
                                                    linha[j]["Condicao"].ToString(),
                                                    linha[j]["Valor"].ToString(),
                                                    R, G, B,
                                                    RLetra, GLetra, BLetra);
                        }
                        else
                        {
                            ColorirDataGrid(dataGridView1.Columns[i].DataPropertyName,
                                            linha[j]["PalavraChave"].ToString(),
                                            R, G, B,
                                            RLetra, GLetra, BLetra);
                        }
                    }
                }
            }
        }
        private void ColorirDataHoraLancamento(string coluna, string Condicao, string Valor, int R, int G, int B, int RLetra, int GLetra, int BLetra)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].DataPropertyName == "DataHoraLancamento")
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        if (dataGridView1.Rows[j].Cells[i].Value.ToString() != string.Empty)
                        {
                            if (Condicao == "HOJE")
                            {
                                DateTime agora = DateTime.Now;
                                DateTime horaLancamento = Convert.ToDateTime(dataGridView1.Rows[j].Cells[i].Value.ToString());

                                string agoraString = Convert.ToString(agora.ToString("dd/MM/yyyy"));

                                string lancamentoString = Convert.ToString(horaLancamento.ToString("dd/MM/yyyy"));

                                if (agoraString == lancamentoString)
                                {
                                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(R, G, B);
                                    dataGridView1.Rows[j].Cells[i].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                                }

                            }
                            else if (Condicao == "ONTEM")
                            {
                                DateTime agora = DateTime.Now;
                                DateTime horaLancamento = Convert.ToDateTime(dataGridView1.Rows[j].Cells[i].Value.ToString());

                                string agoraString = Convert.ToString(agora.AddDays(-1).ToString("dd/MM/yyyy"));

                                string lancamentoString = Convert.ToString(horaLancamento.ToString("dd/MM/yyyy"));

                                if (agoraString == lancamentoString)
                                {
                                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(R, G, B);
                                    dataGridView1.Rows[j].Cells[i].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                                }
                            }

                        }


                    }

                }

            }

        }

        private void ColorirStatus(string coluna, string palavraChave, int R, int G, int B, int RLetra, int GLetra, int BLetra)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].DataPropertyName == "Status")
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        if (dataGridView1.Rows[j].Cells[i].Value.ToString() == palavraChave)
                        {
                            dataGridView1.Rows[j].Cells["imagem"].Style.BackColor = Color.FromArgb(R, G, B);
                            dataGridView1.Rows[j].Cells["imagem"].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                        }
                    }
                }
            }
        }
        private void ColorirPeriodo(string coluna, string palavraChave, int R, int G, int B, int RLetra, int GLetra, int BLetra)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].DataPropertyName == "Periodo")
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        if (dataGridView1.Rows[j].Cells[i].Value.ToString() == palavraChave)
                        {
                            dataGridView1.Rows[j].Cells["imagePeriodo"].Style.BackColor = Color.FromArgb(R, G, B);
                            dataGridView1.Rows[j].Cells["imagePeriodo"].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                        }
                    }
                }
            }
        }

        private void ColorirPorcentagem(string coluna, string Condicao, string Valor, int R, int G, int B, int RLetra, int GLetra, int BLetra)
        {
            for(int i = 0;  i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].DataPropertyName == "PorcentagemCarregada")
                {
                    for(int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        if(dataGridView1.Rows[j].Cells[i].Value.ToString() != string.Empty)
                        {
                            double porcetagemCarregada = Convert.ToDouble(dataGridView1.Rows[j].Cells[i].Value.ToString().Replace("%", ""));

                            double segundaCondicao = Convert.ToDouble(Valor);

                            if (Condicao == "MAIOR")
                            {
                                if (porcetagemCarregada > segundaCondicao)
                                {
                                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(R, G, B);
                                    dataGridView1.Rows[j].Cells[i].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                                }
                            }
                            else if (Condicao == "MENOR")
                            {
                                if (porcetagemCarregada < segundaCondicao)
                                {
                                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(R, G, B);
                                    dataGridView1.Rows[j].Cells[i].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                                }
                            }
                            else
                            {
                                dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(183, 9, 9);
                                dataGridView1.Rows[j].Cells[i].Style.ForeColor = Color.FromArgb(255, 255, 255);
                            }
                        }
                        
                    }

                }

            }

        }

        private void CarregarImagemStatus()
        {

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].DataPropertyName == "Status")
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        if (dataGridView1.Rows[j].Cells[i].Value.ToString() == "EM ABERTO")
                        {
                            dataGridView1.Rows[j].Cells["imagem"].Value = Image.FromFile("C:\\Program Files (x86)\\THR\\THR\\Resources\\Aberto.png".ToString());
                            dataGridView1.Columns["imagem"].DisplayIndex = 9;
                        }
                        else if(dataGridView1.Rows[j].Cells[i].Value.ToString() == "FECHADO")
                        {
                            dataGridView1.Rows[j].Cells["imagem"].Value = Image.FromFile("C:\\Program Files (x86)\\THR\\THR\\Resources\\Fechado.png".ToString());
                            dataGridView1.Columns["imagem"].DisplayIndex = 9;
                        }
                        else if (dataGridView1.Rows[j].Cells[i].Value.ToString() == "BLOQUEADO")
                        {
                            dataGridView1.Rows[j].Cells["imagem"].Value = Image.FromFile("C:\\Program Files (x86)\\THR\\THR\\Resources\\human-skull.png".ToString());
                            dataGridView1.Columns["imagem"].DisplayIndex = 9;
                        }
                        else
                        {
                            dataGridView1.Rows[j].Cells["imagem"].Value = Image.FromFile("C:\\Program Files (x86)\\THR\\THR\\Resources\\Aberto.png".ToString());
                            dataGridView1.Columns["imagem"].DisplayIndex = 9;
                        }

                    }
                    break;
                }
            }
        }

        private void CarregarImagemPeriodo()
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].DataPropertyName == "Periodo")
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        if (dataGridView1.Rows[j].Cells[i].Value.ToString() == "MANHÃ")
                        {
                            dataGridView1.Rows[j].Cells["imagePeriodo"].Value = Image.FromFile("C:\\Program Files (x86)\\THR\\THR\\Resources\\sun.png".ToString());
                            dataGridView1.Columns["imagePeriodo"].DisplayIndex = 4;
                        }
                        else if (dataGridView1.Rows[j].Cells[i].Value.ToString() == "NOITE")
                        {
                            dataGridView1.Rows[j].Cells["imagePeriodo"].Value = Image.FromFile("C:\\Program Files (x86)\\THR\\THR\\Resources\\moon.png".ToString());
                            dataGridView1.Columns["imagePeriodo"].DisplayIndex = 4;
                        }
                    }
                    break;
                }

            }
        }

        private void ColorirDataGrid(string coluna, string palavraChave, int R, int G, int B, int RLetra, int GLetra, int BLetra)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].DataPropertyName == coluna)
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        if (dataGridView1.Rows[j].Cells[i].Value.ToString() == palavraChave)
                        {
                            dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(R, G, B);
                            dataGridView1.Rows[j].Cells[i].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                        }
                    }
                }
            }
        }
        private void ColorirDataGridCondicaoTempo(string coluna, string Condicao, string Valor, int R, int G, int B, int RLetra, int GLetra, int BLetra)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].DataPropertyName == "TempoEspera")
                {
                    for (int y = 0; y < dataGridView1.Rows.Count; y++)
                    {
                        if (dataGridView1.Rows[y].Cells[i].Value.ToString() != string.Empty)
                        {
                            TimeSpan segundaCondicao = TimeSpan.FromMinutes(Convert.ToInt32(Valor));

                            DateTime dataHoraAgora = DateTime.Now;
                            DateTime DataHoraGrid = new DateTime();
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                if (dataGridView1.Columns[j].DataPropertyName == "DataHoraLancamento")
                                {
                                    DataHoraGrid = Convert.ToDateTime(dataGridView1.Rows[y].Cells[j].Value.ToString());

                                }
                            }

                            TimeSpan Resultado = dataHoraAgora - DataHoraGrid;

                            if (Condicao == "MAIOR")
                            {
                                if (Resultado > segundaCondicao)
                                {
                                    dataGridView1.Rows[y].Cells[i].Style.BackColor = Color.FromArgb(R, G, B);
                                    dataGridView1.Rows[y].Cells[i].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                                }
                            }
                            if (Condicao == "MENOR")
                            {
                                if (Resultado < segundaCondicao)
                                {
                                    dataGridView1.Rows[y].Cells[i].Style.BackColor = Color.FromArgb(R, G, B);
                                    dataGridView1.Rows[y].Cells[i].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                                }
                            }



                            if (Condicao == "MAIOR")
                            {
                                if (Resultado > segundaCondicao)
                                {
                                    dataGridView1.Rows[y].Cells[i].Style.BackColor = Color.FromArgb(R, G, B);
                                    dataGridView1.Rows[y].Cells[i].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                                }
                            }
                            if (Condicao == "MENOR")
                            {
                                if (Resultado < segundaCondicao)
                                {
                                    dataGridView1.Rows[y].Cells[i].Style.BackColor = Color.FromArgb(R, G, B);
                                    dataGridView1.Rows[y].Cells[i].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                                }
                            }

                        }
                    }

                }
            }
        }

        private void ColorirDataGridCondicaoPeso(string coluna, string Condicao, string Valor, int R, int G, int B, int RLetra, int GLetra, int BLetra)
        {
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (dataGridView1.Columns[i].DataPropertyName == "PesoTotal")
                {
                    for (int y = 0; y < dataGridView1.Rows.Count; y++)
                    {
                        if (dataGridView1.Rows[y].Cells[i].Value.ToString() != string.Empty)
                        {

                            double PesoTotal = Convert.ToDouble(dataGridView1.Rows[y].Cells[i].Value);
                            double segundaCondicao = Convert.ToDouble(Valor);

                            segundaCondicao = Convert.ToDouble(Valor);
                            if (Condicao == "MAIOR")
                            {
                                if (PesoTotal > segundaCondicao)
                                {
                                    dataGridView1.Rows[y].Cells[i].Style.BackColor = Color.FromArgb(R, G, B);
                                    dataGridView1.Rows[y].Cells[i].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                                }
                            }
                            if (Condicao == "MENOR")
                            {
                                if (PesoTotal < segundaCondicao)
                                {
                                    dataGridView1.Rows[y].Cells[i].Style.BackColor = Color.FromArgb(R, G, B);
                                    dataGridView1.Rows[y].Cells[i].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                                }
                            }


                            segundaCondicao = Convert.ToDouble(Valor);
                            if (Condicao == "MAIOR")
                            {
                                if (PesoTotal > segundaCondicao)
                                {
                                    dataGridView1.Rows[y].Cells[i].Style.BackColor = Color.FromArgb(R, G, B);
                                    dataGridView1.Rows[y].Cells[i].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                                }
                            }
                            if (Condicao == "MENOR")
                            {
                                if (PesoTotal < segundaCondicao)
                                {
                                    dataGridView1.Rows[y].Cells[i].Style.BackColor = Color.FromArgb(R, G, B);
                                    dataGridView1.Rows[y].Cells[i].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                                }
                            }

                        }
                    }

                }
            }

        }

        private void LoadGridView()
        {
            try
            {
                var dataTable = controller.SelectTable();

                dataGridView1.DataSource = dataTable;
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.ClearSelection();

                CarregarTempoEspera();
                CarregarPorcentagem();
            }
            catch (Exception ex)
            {

                messageCuston.MessageBoxError(ex.Message);
            }

        }

        private void CarregarPorcentagem()
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].DataPropertyName == "PorcentagemCarregada")
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {

                        dataGridView1.Rows[j].Cells[i].Value = service.Porcentagem(
                            dataGridView1.Rows[j].Cells[18].Value.ToString(),
                            dataGridView1.Rows[j].Cells[13].Value.ToString()
                            );
                    }
                }
            }
        }

        private void CarregarTempoEspera()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if (dataGridView1.Columns[j].DataPropertyName == "DataHoraLancamento")
                    {
                        var TempoEspera = Tempo(Convert.ToDateTime(dataGridView1.Rows[i].Cells[8].Value.ToString()));
                        if (dataGridView1.Rows[i].Cells[9].Value.ToString() == "EM ABERTO")
                        {

                            for (int c = 0; c < dataGridView1.RowCount; c++)
                            {
                                if (dataGridView1.Columns[c].DataPropertyName == "TempoEspera")
                                {
                                    dataGridView1.Rows[i].Cells[c].Value = TempoEspera;
                                }
                            }
                            break;
                        }
                    }
                }

            }
        }

        private string Tempo(DateTime dateTime)
        {
            return service.TempoEspera(dateTime, DateTime.Now);

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
        int seg;
        private void timer1_Tick(object sender, EventArgs e)
        {
            seg++;
            Console.WriteLine(seg);

            if (seg == 100)
            {
                LoadGridView();
                VerificarCoresBancoDados();

                seg = 0;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.FromArgb(43, 217, 64))
            {
                timer1.Stop();
                panel1.BackColor = Color.FromArgb(156, 8, 8);
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.FromArgb(156, 8, 8))
            {
                timer1.Start();
                panel1.BackColor = Color.FromArgb(43, 217, 64);
            }
        }
    }
}
