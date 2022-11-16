using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THR.Dto.Expedicao;
using THR.Views.Message;
using THR.Dto.Login;
using THR.Controller.Expedicao;
using THR.Service.CustonException;
using THR.Views.Expedicao.Filtros;
using THR.Service.Login;

namespace THR.Views.Expedicao
{
    public partial class frmControleCarregamentos : Form
    {
        private LoginDto loginDto;
        private DataTable acessos;
        private CarregamentosController controller;
        public CarregamentosDto dto;
        private MessageCuston messageCuston;
        private ModuloService modulosService;
        private RegiaoController regiaoController;
        private MotoristaController motoristaController;
        private CarrosController carrosController;


        public frmControleCarregamentos(LoginDto loginDto, DataTable acessos)
        {
            InitializeComponent();
            this.loginDto = loginDto;
            this.acessos = acessos;
            controller = new CarregamentosController(loginDto, acessos);
            messageCuston = new MessageCuston();
            modulosService = new ModuloService();
            regiaoController = new RegiaoController();
            motoristaController = new MotoristaController();
            carrosController = new CarrosController();
            CarregarDataGrid();
            CarregarRegiao();
            CarregarMotorista();
            CarregarCarros();

        }

        private void CarregarCarros()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                foreach(var itens in carrosController.Carros())
                {
                    cboCaminhao.Items.Add(itens);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void CarregarMotorista()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                foreach(var itens in motoristaController.Motorista())
                {
                    cboNomeMotorista.Items.Add(itens);
                }
            }
            catch (ServiceException ex)
            {

                messageCuston.MessageBoxError(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void CarregarRegiao()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                foreach (var itens in regiaoController.Regiao())
                {
                    cboRegiao.Items.Add(itens);
                }

            }
            catch (ServiceException ex)
            {

                messageCuston.MessageBoxError(ex.Message);
            }

            this.Cursor = Cursors.Default;

        }

        private void CarregarDataGrid()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                dataGridView1.DataSource = controller.SelectTable();

                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (i == dataGridView1.Rows.Count - 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                        break;
                    }
                }
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


        private string VerificaStatus(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i] is RadioButton)
                {
                    if (((RadioButton)control.Controls[i]).Checked)
                    {
                        if(control.Controls[i].Text == "Fechado")
                        {
                            return "FECHADO";
                        }
                        else
                        {
                            return "EM ABERTO";
                        }
                    }
                }
            }
            return null;
        }

        private string VerificarOndulado(Control control)
        {
            for(int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i] is RadioButton)
                {
                    if (((RadioButton)control.Controls[i]).Checked)
                    {
                        return control.Controls[i].Text;
                    }
                }
            }
            return null;
        }

        private string VerificaPeriodo(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i] is RadioButton)
                {
                    if (((RadioButton)control.Controls[i]).Checked)
                    {
                        return control.Controls[i].Text;
                    }
                }
            }
            return null;
        }
        private string VerificarBolha(Control control)
        {
            for (int i = 0; i < control.Controls.Count; i++)
            {
                if (control.Controls[i] is RadioButton)
                {
                    if (((RadioButton)control.Controls[i]).Checked)
                    {
                        return control.Controls[i].Text;
                    }
                }
            }
            return null;
        }

        private void ClearAll()
        {
            this.Cursor = Cursors.WaitCursor;

            txtRomaneio.Text = string.Empty;
            txtNumeroCarregamento.Text = string.Empty;
            cboNomeMotorista.Text = string.Empty;
            cboRegiao.Text = string.Empty;
            cboCaminhao.Text = string.Empty;
            txtPesoTotal.Text = string.Empty;
            rdbManha.Checked = false;
            rdbNoite.Checked = false;
            rdbBolhaSim.Checked = false;
            rdbOnduladoSim.Checked = false;
            ckbBloqueado.Checked = false;
            rdbStatusFechado.Checked = false;
            dataGridView1.ClearSelection();
            VerificaPermissao();

            txtPesoTotal.Text = "0";
            cboRegiao.Text = "Disponível";

            rdbBolhaNao.Checked = true;
            rdbOnduladoNao.Checked = true;

            this.Cursor = Cursors.Default;
        }

        private void frmControleCarregamentos_Load(object sender, EventArgs e)
        {
            ClearAll();

        }

        private void txtPesoTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            CarregarDataGrid();
            ClearAll();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmFiltroCarregamento filtro = new frmFiltroCarregamento(this, controller.SelectTable());
            filtro.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        public void LoadGridViewWithFilter(DataTable dt)
        {
            dataGridView1.DataSource = dt;
            ClearAll();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dto = new CarregamentosDto();
            try
            {
                dto.NumeroRomaneio = txtRomaneio.Text;
                dto.NomeMotorista = cboNomeMotorista.Text;
                dto.Regiao = cboRegiao.Text;
                dto.Periodo = VerificaPeriodo(gpPeriodoCarregamento);
                dto.Bolha = VerificarBolha(gpBolha);
                dto.Ondulado = VerificarOndulado(gpOndulado);
                dto.Status = VerificaStatus(gpStatus);
                dto.PesoTotal = txtPesoTotal.Text;
                dto.Caminhao = cboCaminhao.Text;
                controller.Insert(dto);

                CarregarDataGrid();

                ClearAll();

                messageCuston.MessageBoxInfomation("Lançamento realizado com sucesso!");
            }
            catch (ServiceException ex)
            {

                messageCuston.MessageBoxError(ex.Message);
            }

            this.Cursor = Cursors.Default;

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dto = new CarregamentosDto();
            try
            {
                dto.NumeroCarregamento = txtNumeroCarregamento.Text;
                dto.NumeroRomaneio = txtRomaneio.Text;
                dto.NomeMotorista = cboNomeMotorista.Text;
                dto.Regiao = cboRegiao.Text;
                dto.Periodo = VerificaPeriodo(gpPeriodoCarregamento);
                dto.Bolha = VerificarBolha(gpBolha);
                dto.Ondulado = VerificarOndulado(gpOndulado);
                dto.Status = VerificaStatus(gpStatus);
                dto.DataHoraLancamento = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                dto.PesoTotal = txtPesoTotal.Text;
                dto.Caminhao = cboCaminhao.Text;
                if (ckbBloqueado.Checked)
                {
                    dto.Status = "BLOQUEADO";
                }
                else if (rdbStatusFechado.Checked)
                {
                    dto.Status = "FECHADO";
                }
                else
                {
                    dto.Status = "EM ABERTO";
                }
                var lista = modulosService.ListaAcessos();
                for (int i = 0; i < lista.Length; i++)
                {
                    if (modulosService.DefinirAcessos(acessos, lista[i]))
                    {
                        if (lista[i] == "Expedição - Admin")
                        {
                            frmEcolhaStatus status = new frmEcolhaStatus(dto,this);
                            status.ShowDialog();
                        }
                    }
                }

                        controller.Update(dto);

                CarregarDataGridNumero(dto.NumeroCarregamento);

                ClearAll();

                messageCuston.MessageBoxInfomation("Carregamento alterado com sucesso!");
            }
            catch (ServiceException ex)
            {

                messageCuston.MessageBoxError(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void CarregarDataGridNumero(string numeroCarregamento)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                dataGridView1.DataSource = controller.SelectTable();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == numeroCarregamento)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                        break;
                    }
                }
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

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtNumeroCarregamento.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtRomaneio.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                cboNomeMotorista.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                cboRegiao.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                cboCaminhao.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                txtPesoTotal.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();

                VerificarCheckeds();

                if (dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "FECHADO")
                {
                    btnAlterar.Enabled = false;
                }
                else
                {
                    btnAlterar.Enabled = true;
                }
                if(dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "BLOQUEADO")
                {
                    rdbStatusFechado.Enabled = false;
                }

                VerificaPermissao();

            }
            this.Cursor = Cursors.Default;

        }

        private void VerificaPermissao()
        {

            var lista = modulosService.ListaAcessos();

            for (int i = 0; i < lista.Length; i++)
            {
                if (modulosService.DefinirAcessos(acessos, lista[i]))
                {
                    if (lista[i] == "Expedição - Alterações" || lista[i] == "Expedição - Comunicador")
                    {
                        if(lista[i] == "Expedição - Alterações")
                        {
                            ckbBloqueado.Enabled = false;
                        }
                        if(dataGridView1.SelectedRows.Count > 0)
                        {
                            if (lista[i] == "Expedição - Comunicador" && 
                                dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "BLOQUEADO" ||
                                lista[i] == "Expedição - Comunicador" &&
                                dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "EM ABERTO")
                            {
                                btnAlterar.Enabled = true;
                                btnSalvar.Enabled = false;
                            }
                            if (lista[i] == "Expedição - Comunicador" ||
                                lista[i] == "Expedição - Alterações" &&
                                dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "BLOQUEADO" ||
                                lista[i] == "Expedição - Alterações" &&
                                dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "FECHADO")
                            {
                                txtNumeroCarregamento.ReadOnly = true;
                                txtPesoTotal.ReadOnly = true;
                                txtRomaneio.ReadOnly = true;
                                cboCaminhao.Enabled = false;
                                cboNomeMotorista.Enabled = false;
                                cboRegiao.Enabled = false;
                                rdbBolhaNao.Enabled = false;
                                rdbBolhaSim.Enabled = false;
                                rdbManha.Enabled = false;
                                rdbNoite.Enabled = false;
                                rdbOnduladoNao.Enabled = false;
                                rdbOnduladoSim.Enabled = false;
                                rdbStatusFechado.Enabled = false;
                                btnSalvar.Enabled = false;
                                break;
                            }
                        }

                    }
                    if (lista[i] == "Expedição - Admin" || lista[i] == "Expedição - Alterações")
                    {
                        if (dataGridView1.SelectedRows.Count > 0)
                        {
                            btnSalvar.Enabled = false;
                            btnAlterar.Enabled = true;
                        }
                        else
                        {
                            btnSalvar.Enabled = true;
                            btnAlterar.Enabled = false;
                        }
                        if (lista[i] == "Expedição - Admin")
                        {

                            ckbBloqueado.Enabled = true;
                        }
                        txtNumeroCarregamento.ReadOnly = false;
                        txtPesoTotal.ReadOnly = false;
                        txtRomaneio.ReadOnly = false;
                        cboCaminhao.Enabled = true;
                        cboNomeMotorista.Enabled = true;
                        cboRegiao.Enabled = true;
                        rdbBolhaNao.Enabled = true;
                        rdbBolhaSim.Enabled = true;
                        rdbManha.Enabled = true;
                        rdbNoite.Enabled = true;
                        rdbOnduladoNao.Enabled = true;
                        rdbOnduladoSim.Enabled = true;
                        rdbStatusFechado.Enabled = true;
                        break;
                    }

                }
            }
        }

        private void VerificarCheckeds()
        {
            ckbBloqueado.Checked = false;
            rdbStatusFechado.Checked = false;
            if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "MANHÃ")
            {
                rdbManha.Checked = true;
            }
            else
            {
                rdbNoite.Checked = true;
            }

            if (dataGridView1.SelectedRows[0].Cells[5].Value.ToString() == "NÃO")
            {
                rdbBolhaSim.Checked = true;
            }
            else
            {
                rdbBolhaNao.Checked = true;
            }

            if (dataGridView1.SelectedRows[0].Cells[6].Value.ToString() == "SIM")
            {
                rdbOnduladoSim.Checked = true;
            }
            else
            {
                rdbOnduladoNao.Checked = true;
            }

            if(dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "BLOQUEADO")
            {
                ckbBloqueado.Checked = true;
            }
            if(dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "FECHADO")
            {
                rdbStatusFechado.Checked = true;
            }

        }

        private void txtRomaneio_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == txtRomaneio.Text)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                        break;
                    }
                    else if(i == dataGridView1.Rows.Count - 1)
                    {
                        messageCuston.MessageBoxWarning("Romaneio não encontrado!");
                    }
                }

            }
        }

        private void frmControleCarregamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F5)
            {
                CarregarDataGrid();
                ClearAll();
            }
        }
    }
}
