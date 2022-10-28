using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THR.Views.Expedicao.Filtros
{
    public partial class frmFiltroCarregamento : Form
    {
        private frmControleCarregamentos carregamentos;
        private DataTable dt;

        public frmFiltroCarregamento(frmControleCarregamentos carregamentos, DataTable dt)
        {
            InitializeComponent();
            this.carregamentos = carregamentos;
            this.dt = dt;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dt.DefaultView.RowFilter = string.Format("[Status] like '%{0}%'", cboFiltro.Text);
            carregamentos.LoadGridViewWithFilter(dt);

            this.Cursor = Cursors.Default;

            this.Close();
        }
    }
}
