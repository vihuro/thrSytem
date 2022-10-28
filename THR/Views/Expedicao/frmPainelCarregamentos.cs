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

namespace THR.Views.Expedicao
{
    public partial class frmPainelCarregamentos : Form
    {
        private CarregamentosController controller;
        private MessageCuston messageCuston;
        public frmPainelCarregamentos(LoginDto dto)
        {
            InitializeComponent();
            controller = new CarregamentosController(dto);
            messageCuston = new MessageCuston();

        }

        private void frmPainelCarregamentos_Load(object sender, EventArgs e)
        {
            LoadGridView();
            dataGridView1.ClearSelection();
        }

        private void LoadGridView()
        {
            try
            {
                dataGridView1.DataSource = controller.SelectTable();
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
            catch (Exception ex)
            {

                messageCuston.MessageBoxError(ex.Message);
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[9].Value.ToString() == "EM ABERTO")
                {
                    dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.Red;
                }
                if (dataGridView1.Rows[i].Cells[9].Value.ToString() == "FECHADO")
                {

                    dataGridView1.Rows[i].Cells[9].Style.BackColor = Color.FromArgb(r, g, b);
                }
            }
        }

        private int r = 26;
        private int g = 49;
        private int b = 146;
    }
}
