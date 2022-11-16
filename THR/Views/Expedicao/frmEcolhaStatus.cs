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

namespace THR.Views.Expedicao
{
    public partial class frmEcolhaStatus : Form
    {
        private CarregamentosDto dto;
        private frmControleCarregamentos carregamentos;
        public frmEcolhaStatus(CarregamentosDto dto, frmControleCarregamentos carregamentos)
        {
            InitializeComponent();
            this.dto = dto;
            this.carregamentos = carregamentos;
        }

        private void frmEcolhaStatus_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            carregamentos.dto.Status = cboStatus.Text;

            this.Cursor = Cursors.Default;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            this.Close();


            this.Cursor = Cursors.Default;
        }
    }
}
