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
        private CarregamentosDto dto;
        private MessageCuston messageCuston;
        private ModuloService modulosService;
        private RegiaoController regiaoController;
        private MotoristaController motoristaController;


        public frmControleCarregamentos(LoginDto loginDto, DataTable acessos)
        {
            InitializeComponent();
            this.loginDto = loginDto;
            this.acessos = acessos;
            controller = new CarregamentosController(loginDto);
            messageCuston = new MessageCuston();
            modulosService = new ModuloService();
            regiaoController = new RegiaoController();
            motoristaController = new MotoristaController();
            CarregarDataGrid();
            CarregarRegiao();
            CarregarMotorista();

        }

        private void CarregarMotorista()
        {
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
        }

        private void CarregarRegiao()
        {
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

        }

        private void CarregarDataGrid()
        {
            try
            {
                dataGridView1.DataSource = controller.SelectTable();
            }
            catch (ServiceException ex)
            {

                messageCuston.MessageBoxError(ex.Message);
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
                        if(control.Controls[i].Text == "Aberto")
                        {
                            return "EM ABERTO";
                        }
                        else
                        {
                            return "FECHADO";
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
            txtRomaneio.Text = string.Empty;
            txtNumeroCarregamento.Text = string.Empty;
            cboNomeMotorista.Text = string.Empty;
            cboRegiao.Text = string.Empty;
            txtPesoTotal.Text = string.Empty;
            rdbManha.Checked = false;
            rdbNoite.Checked = false;
            rdbBolhaSim.Checked = false;
            rdbBolhaNao.Checked = false;
            rdbOnduladoSim.Checked = false;
            rdbOnduladoNao.Checked = false;
            rdbStatusAberto.Checked = false;
            rdbStatusFechado.Checked = false;
            dataGridView1.ClearSelection();
            VerificaPermissao();
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
                controller.Update(dto);

                CarregarDataGrid();

                ClearAll();

                messageCuston.MessageBoxInfomation("Carregamento alterado com sucesso!");
            }
            catch (ServiceException ex)
            {

                messageCuston.MessageBoxError(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                txtNumeroCarregamento.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtRomaneio.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                cboNomeMotorista.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                cboRegiao.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtPesoTotal.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();

                VerificarCheckeds();

                VerificaPermissao();

                if (dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "FECHADO")
                {
                    btnAlterar.Enabled = false;
                }
                else
                {
                    btnAlterar.Enabled = true;
                }

            }
        }

        private void VerificaPermissao()
        {
            var permissões = modulosService.DefinirAcessos(acessos, "");
            foreach (var permissoes in modulosService.ListaAcessos())
            {
                switch (modulosService.DefinirAcessos(acessos, permissoes))
                {
                    case true:

                        if (permissoes == "Expedição - Admin")
                        {
                            AtivarbotoesExpedicao();
                        }
                        break;
                }
            }
        }

        private void AtivarbotoesExpedicao()
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                btnAlterar.Enabled = true;
                btnSalvar.Enabled = false;
            }
            else
            {
                btnAlterar.Enabled = false;
                btnSalvar.Enabled = true;
            }

        }

        private void VerificarCheckeds()
        {
            if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "Manhã")
            {
                rdbManha.Checked = true;
            }
            else
            {
                rdbNoite.Checked = true;
            }

            if (dataGridView1.SelectedRows[0].Cells[5].Value.ToString() == "Sim")
            {
                rdbBolhaSim.Checked = true;
            }
            else
            {
                rdbBolhaNao.Checked = true;
            }

            if (dataGridView1.SelectedRows[0].Cells[6].Value.ToString() == "Sim")
            {
                rdbOnduladoSim.Checked = true;
            }
            else
            {
                rdbOnduladoNao.Checked = true;
            }

            if (dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "EM ABERTO")
            {
                rdbStatusAberto.Checked = true;
            }
            else
            {
                rdbStatusFechado.Checked = true;
            }
        }
    }
}
