﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THR.Dto.Expedicao;
using THR.Service.Expedicao;
using THR.Service.CustonException;
using THR.Views.Message;
using THR.Dto.Login;

namespace THR.Views.Expedicao
{
    public partial class frmGerenciarCoresPainelControleCarregamentos : Form
    {

        private CarregamentosDto dto;
        private ServiceException exception;
        private CarregamentosService service;
        private MessageCuston messageCuston;
        private CoresPainelControleCarregamentosService coresService;
        private CoresPainelControleCarregamentosDto coresDto;

        private string idVariavel = "";

        public frmGerenciarCoresPainelControleCarregamentos(LoginDto loginDto, DataTable dt)
        {
            InitializeComponent();
            service = new CarregamentosService(loginDto,dt);
            messageCuston = new MessageCuston();
            coresService = new CoresPainelControleCarregamentosService(loginDto);

        }

        private void frmGerenciarCoresPainelControleCarregamentos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                dataGridView1.DataSource = service.SelectTable();
                CarregarTempoEspera();
                VerificarCoresBancoDados();
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {

                messageCuston.MessageBoxError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void CarregarTempoEspera()
        {
            for(int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].DataPropertyName == "TempoEspera")
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        var TempoEspera = Tempo(Convert.ToDateTime(dataGridView1.Rows[j].Cells[8].Value.ToString()));
                        if (dataGridView1.Rows[j].Cells[9].Value.ToString() == "EM ABERTO")
                        {
                            dataGridView1.Rows[j].Cells[i].Value = TempoEspera;
                        }
                    }
                    break;
                }
            }

        }

        private string Tempo(DateTime dateTime)
        {
            return service.TempoEspera(dateTime, DateTime.Now);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                int R = Convert.ToInt32(txtRedColuna.Text);
                int G = Convert.ToInt32(txtGreenColuna.Text);
                int B = Convert.ToInt32(txtBlueColuna.Text);

                int RLetra = Convert.ToInt32(txtRedLetra.Text);
                int GLetra = Convert.ToInt32(txtGreenLetra.Text);
                int BLetra = Convert.ToInt32(txtBlueLetra.Text);

                if (R > 255 || G > 255 || B > 255 || RLetra > 255 || GLetra > 255 || BLetra > 255 ||
                    R < 0 || G < 0 || B < 0 || RLetra < 0 || GLetra < 0 || BLetra < 0)
                {
                    messageCuston.MessageBoxWarning("Numeração não suportada. As cores RGB devem estar entre 0 e 255");
                }
                else
                {
                    Salvar();
                    CarregarGrid();

                }

            }
            catch (Exception ex)
            {

                messageCuston.MessageBoxError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Salvar()
        {
            this.Cursor = Cursors.WaitCursor;

            coresDto = new CoresPainelControleCarregamentosDto();
            coresDto.PalavraChave = cboPalavraChave.Text;
            coresDto.Coluna = cboColuna.Text;
            coresDto.RCelula = txtRedColuna.Text;
            coresDto.GCelula = txtGreenColuna.Text;
            coresDto.BCelula = txtBlueColuna.Text;
            coresDto.RLetra = txtRedLetra.Text;
            coresDto.GLetra = txtGreenLetra.Text;
            coresDto.BLetra = txtBlueLetra.Text;
            coresDto.Condicao = cboPrimeiraCondicao.Text;
            coresDto.Valor = txtPrimeiroValor.Text;
            coresDto.Id = idVariavel;

            if (cboColuna.Text == "PesoTotal" || cboColuna.Text == "TempoEspera" || cboColuna.Text == "PorcentagemCarregada" ||
                cboColuna.Text == "DataHoraLancamento")
            {
                if (rdbPrimeiraCondicao.Checked)
                {
                    coresDto.PalavraChave = cboPrimeiraCondicao.Text;
                    coresDto.Condicao = cboPrimeiraCondicao.Text;
                    coresDto.Valor = txtPrimeiroValor.Text;

                }
                else if (rdbSegundaCondicao.Checked)
                {
                    coresDto.PalavraChave = cboSegundaCondicao.Text;
                    coresDto.Condicao = cboSegundaCondicao.Text;
                    coresDto.Valor = txtSegundoValor.Text;
                }
                else if (rdbTerceiraCondicao.Checked)
                {
                    coresDto.PalavraChave = cboTerceiraCondicao.Text;
                    coresDto.Condicao = cboTerceiraCondicao.Text;
                    coresDto.Valor = txtTerceiroValor.Text;
                }
                else if(cboColuna.Text == "PorcentagemCarregada")
                {
                    if (rdbPrimeiraCondicao.Checked)
                    {
                        coresDto.Valor = cboPrimeiraCondicao.Text;
                        coresDto.Valor = cboPrimeiraCondicao.Text;
                    }
                    else
                    {
                        coresDto.Valor = cboSegundaCondicao.Text;
                        coresDto.Valor = cboSegundaCondicao.Text;
                    }

                }

            }
            try
            {
                coresService.BuscarCores(coresDto,idVariavel);

                messageCuston.MessageBoxInfomation("Alterado com sucesso!");
            }
            catch (ServiceException ex)
            {

                messageCuston.MessageBoxError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void VerificarCores()
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {

                if (dataGridView1.Columns[i].DataPropertyName == cboColuna.Text)
                {
                    for (int y = 0; y < dataGridView1.RowCount; y++)
                    {
                        if (dataGridView1.Rows[y].Cells[i].Value.ToString() == cboPalavraChave.Text)
                        {
                            txtRedColuna.Text = dataGridView1.Rows[y].Cells[i].Style.BackColor.R.ToString();
                            txtGreenColuna.Text = dataGridView1.Rows[y].Cells[i].Style.BackColor.G.ToString();
                            txtBlueColuna.Text = dataGridView1.Rows[y].Cells[i].Style.BackColor.B.ToString();

                            txtRedLetra.Text = dataGridView1.Rows[y].Cells[i].Style.ForeColor.R.ToString();
                            txtGreenLetra.Text = dataGridView1.Rows[y].Cells[i].Style.ForeColor.G.ToString();
                            txtBlueLetra.Text = dataGridView1.Rows[y].Cells[i].Style.ForeColor.B.ToString();
                        }
                    }

                    break;
                }

            }
        }

        private void cboColuna_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cboColuna.Text == "PesoTotal" || cboColuna.Text == "TempoEspera" || cboColuna.Text == "PorcentagemCarregada")
            {
                cboPalavraChave.Text = string.Empty;
                cboPalavraChave.Enabled = false;
                rdbPrimeiraCondicao.Enabled = true;
                rdbSegundaCondicao.Enabled = true;
                rdbTerceiraCondicao.Enabled = true;

                cboPrimeiraCondicao.Items.Clear();
                cboSegundaCondicao.Items.Clear();
                cboTerceiraCondicao.Items.Clear();



                cboPrimeiraCondicao.Items.Add("MAIOR");
                cboPrimeiraCondicao.Items.Add("MENOR");

                cboSegundaCondicao.Items.Add("MAIOR");
                cboSegundaCondicao.Items.Add("MENOR");

                cboTerceiraCondicao.Items.Add("MAIOR");
                cboTerceiraCondicao.Items.Add("MENOR");

                txtPrimeiroValor.Text = "0";
                txtSegundoValor.Text = "0";
                txtTerceiroValor.Text = "0";

                CarregarCondicao();

            }
            else if(cboColuna.Text == "DataHoraLancamento")
            {
                cboPalavraChave.Text = string.Empty;
                cboPalavraChave.Enabled = false;
                rdbPrimeiraCondicao.Enabled = true;
                rdbSegundaCondicao.Enabled = true;

                cboPrimeiraCondicao.Items.Clear();
                cboSegundaCondicao.Items.Clear();



                cboPrimeiraCondicao.Items.Add("ONTEM");
                cboPrimeiraCondicao.Items.Add("HOJE");

                cboSegundaCondicao.Items.Add("ONTEM");
                cboSegundaCondicao.Items.Add("HOJE");

                CarregarCondicao();
            }
            else
            {
                VerificarCores();
                cboPalavraChave.Enabled = true;
                rdbPrimeiraCondicao.Enabled = false;
                rdbPrimeiraCondicao.Checked = false;
                rdbSegundaCondicao.Enabled = false;
                rdbSegundaCondicao.Checked = false;
                rdbTerceiraCondicao.Enabled = false;
                rdbTerceiraCondicao.Checked = false;
                cboPrimeiraCondicao.Enabled = false;
                cboSegundaCondicao.Enabled = false;
                cboTerceiraCondicao.Enabled = false;
                txtPrimeiroValor.Enabled = false;
                txtSegundoValor.Enabled = false;
                txtTerceiroValor.Enabled = false;
                cboPrimeiraCondicao.Items.Clear();
                cboSegundaCondicao.Items.Clear();
                cboTerceiraCondicao.Items.Clear();
                txtPrimeiroValor.Text = "";
                txtSegundoValor.Text = "";
                txtTerceiroValor.Text = "";

                CarregarComboBox();
            }

        }

        private void CarregarComboBox()
        {
            this.Cursor = Cursors.WaitCursor;

            cboPalavraChave.Items.Clear();
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].DataPropertyName == cboColuna.Text)
                {
                    for (int i2 = 0; i2 < dataGridView1.Rows.Count; i2++)
                    {
                        VerificarNoComboBox(dataGridView1.Rows[i2].Cells[i].Value.ToString());
                    }
                }
            }

            this.Cursor = Cursors.Default;

        }

        private void VerificarNoComboBox(string item)
        {
            if (cboPalavraChave.Items.Count == 0)
            {
                cboPalavraChave.Items.Add(item);
            }
            else
            {
                for (int i = 0; i < cboPalavraChave.Items.Count; i++)
                {
                    if (cboPalavraChave.Items[i].ToString() == item)
                    {
                        break;
                    }
                    else if (i == cboPalavraChave.Items.Count - 1)
                    {
                        cboPalavraChave.Items.Add(item);
                    }
                }
            }
        }

        private void cboPalavraChave_SelectedValueChanged(object sender, EventArgs e)
        {
            VerificarCores();
        }

        private void txtRedColuna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGreenColuna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBlueColuna_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRedPalavraChave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGreenPalavraChave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBluePalavraChave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void VerificarCoresBancoDados()
        {
            this.Cursor = Cursors.WaitCursor;

            var dataTable = coresService.SelectTableColors();
            try
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    var col = dataGridView1.Columns[i].DataPropertyName;
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
                            else if (dataGridView1.Columns[i].DataPropertyName == "PorcentagemCarregada")
                            {
                                ColorirPorcentagem(dataGridView1.Columns[i].DataPropertyName,
                                                        linha[j]["Condicao"].ToString(),
                                                        linha[j]["Valor"].ToString(),
                                                        R, G, B,
                                                        RLetra, GLetra, BLetra);
                            }
                            else if (dataGridView1.Columns[i].DataPropertyName == "DataHoraLancamento")
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
            catch (Exception ex)
            {

                messageCuston.MessageBoxError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
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
                            if(Condicao == "HOJE")
                            {
                                DateTime agora = DateTime.Now;
                                DateTime horaLancamento = Convert.ToDateTime(dataGridView1.Rows[j].Cells[i].Value.ToString());

                                string agoraString = Convert.ToString(agora.ToString("dd/MM/yyyy"));

                                string lancamentoString = Convert.ToString(horaLancamento.ToString("dd/MM/yyyy"));

                                if(agoraString == lancamentoString)
                                {
                                    dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(R, G, B);
                                    dataGridView1.Rows[j].Cells[i].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                                }

                            }
                            else if(Condicao == "ONTEM")
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

        private void ColorirPorcentagem(string coluna, string Condicao, string Valor, int R, int G, int B, int RLetra, int GLetra, int BLetra)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].DataPropertyName == "PorcentagemCarregada")
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
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
                            if (Condicao == "MENOR")
                            {
                                if (porcetagemCarregada < segundaCondicao)
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
                            DateTime DataHoraGrid = Convert.ToDateTime(dataGridView1.Rows[y].Cells[8].Value.ToString());


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

        private void ColorirDataGrid(string coluna, string palavraChave, int R, int G, int B, int RLetra, int GLetra, int BLetra)
        {
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (dataGridView1.Columns[i].DataPropertyName == coluna && 
                    dataGridView1.Columns[i].DataPropertyName != "PesoTotal" &&
                    dataGridView1.Columns[i].DataPropertyName != "TempoEspera")
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
                else if (dataGridView1.Columns[i].DataPropertyName == "PesoTotal")
                {
                    for (int j = 0; j < dataGridView1.Rows.Count; j++)
                    {
                        if (dataGridView1.Rows[j].Cells[i].Value.ToString() == palavraChave &&
                            dataGridView1.Rows[j].Cells[i].Value.ToString() != string.Empty)
                        {
                            dataGridView1.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(R, G, B);
                            dataGridView1.Rows[j].Cells[i].Style.ForeColor = Color.FromArgb(RLetra, GLetra, BLetra);
                        }
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            CarregarGrid();

            this.Cursor = Cursors.Default;
        }

        private void rdbPrimeiraCondicao_CheckedChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            cboPrimeiraCondicao.Enabled = true;

            cboSegundaCondicao.Enabled = false;
            cboTerceiraCondicao.Enabled = false;
            txtSegundoValor.Enabled = false;
            txtTerceiroValor.Enabled = false;

            if(cboColuna.Text != "DataHoraLancamento")
            {
                txtPrimeiroValor.Enabled = true;

            }

            CarregarCondicao();

            this.Cursor = Cursors.Default;

        }
        private void rdbSegundaCondicao_CheckedChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            cboPrimeiraCondicao.Enabled = false;
            txtPrimeiroValor.Enabled = false;
            cboTerceiraCondicao.Enabled = false;
            txtTerceiroValor.Enabled = false;

            cboSegundaCondicao.Enabled = true;

            if(cboColuna.Text != "DataHoraLancamento")
            {
                txtSegundoValor.Enabled = true;

            }

            CarregarCondicao();

            this.Cursor = Cursors.Default;
        }

        private void rdbTerceiraCondicao_CheckedChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            cboPrimeiraCondicao.Enabled = false;
            txtPrimeiroValor.Enabled = false;

            cboSegundaCondicao.Enabled = false;
            txtSegundoValor.Enabled = false;

            cboTerceiraCondicao.Enabled = true;
            txtTerceiroValor.Enabled = true;

            if (cboColuna.Text != "DataHoraLancamento")
            {
                txtTerceiroValor.Enabled = true;

            }

            CarregarCondicao();

            this.Cursor = Cursors.Default;
        }

        private void CarregarCondicao()
        {
            var condicoes = coresService.SelectTableColors();
            idVariavel = "";
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                var linha = condicoes.Select($"Coluna = '{cboColuna.Text}'");

                if (linha.Count() > 0)
                {
                    for (int j = 0; j < linha.Count(); j++)
                    {

                        txtPrimeiroValor.Text = linha[0]["Valor"].ToString();
                        cboPrimeiraCondicao.Text = linha[0]["Condicao"].ToString();


                        if (linha.Count() > 1)
                        {
                            txtSegundoValor.Text = linha[1]["Valor"].ToString();
                            cboSegundaCondicao.Text = linha[1]["Condicao"].ToString();

                        }
                        if(linha.Count() > 2)
                        {
                            txtTerceiroValor.Text = linha[2]["Valor"].ToString();
                            cboTerceiraCondicao.Text = linha[2]["Condicao"].ToString();
                        }


                        if (rdbPrimeiraCondicao.Checked)
                        {

                            txtRedColuna.Text = linha[j]["RCelula"].ToString();
                            txtGreenColuna.Text = linha[j]["GCelula"].ToString();
                            txtBlueColuna.Text = linha[j]["BCelula"].ToString();
                            txtRedLetra.Text = linha[j]["RLetra"].ToString();
                            txtGreenLetra.Text = linha[j]["GLetra"].ToString();
                            txtBlueLetra.Text = linha[j]["BLetra"].ToString();

                            idVariavel = linha[j]["ID"].ToString();

                            break;

                        }
                        else if (rdbSegundaCondicao.Checked)
                        {
                            if (linha.Count() > 1)
                            {

                                txtRedColuna.Text = linha[1]["RCelula"].ToString();
                                txtGreenColuna.Text = linha[1]["GCelula"].ToString();
                                txtBlueColuna.Text = linha[1]["BCelula"].ToString();
                                txtRedLetra.Text = linha[1]["RLetra"].ToString();
                                txtGreenLetra.Text = linha[1]["GLetra"].ToString();
                                txtBlueLetra.Text = linha[1]["BLetra"].ToString();

                                idVariavel = linha[1]["ID"].ToString();

                                break;


                            }
                            else
                            {

                                txtRedColuna.Text = "0";
                                txtGreenColuna.Text = "0";
                                txtBlueColuna.Text = "0";
                                txtRedLetra.Text = "0";
                                txtGreenLetra.Text = "0";
                                txtBlueLetra.Text = "0";
                                idVariavel = "";
                            }

                        }
                        else if (rdbTerceiraCondicao.Checked)
                        {
                            if(linha.Count() > 2)
                            {
                                txtRedColuna.Text = linha[2]["RCelula"].ToString();
                                txtGreenColuna.Text = linha[2]["GCelula"].ToString();
                                txtBlueColuna.Text = linha[2]["BCelula"].ToString();
                                txtRedLetra.Text = linha[2]["RLetra"].ToString();
                                txtGreenLetra.Text = linha[2]["GLetra"].ToString();
                                txtBlueLetra.Text = linha[2]["BLetra"].ToString();

                                idVariavel = linha[2]["ID"].ToString();

                                break;
                            }
                            else
                            {
                                txtRedColuna.Text = "0";
                                txtGreenColuna.Text = "0";
                                txtBlueColuna.Text = "0";
                                txtRedLetra.Text = "0";
                                txtGreenLetra.Text = "0";
                                txtBlueLetra.Text = "0";
                                idVariavel = "";

                            }
                        }

                    }

                }

            }
        }

    }
}
