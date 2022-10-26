using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THR.Dto.Login;
using THR.Controller.Login;
using THR.Service.Login;

namespace THR.Views.Menu
{
    public partial class frmMenu : Form
    {

        private LoginDto loginDto;
        private DataTable acessos;
        private ModuloService modulosService;



        public frmMenu(LoginDto loginDto,DataTable acessos)
        {
            this.loginDto = loginDto;
            this.acessos = acessos;
            this.modulosService = new ModuloService();
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            AtivarBotoes();
        }

        private void AtivarBotoes()
        {
            if(modulosService.DefinirAcessos(acessos, "Expedição - Admin"))
            {
                entradaToolStripMenuItem.Enabled = true;
                Console.WriteLine("Esse usuário tem acesso a expedição admin");
            }
            if(modulosService.DefinirAcessos(acessos, "Estoque - Admin"))
            {
                históricoToolStripMenuItem.Enabled = true;
                Console.WriteLine("Esse usuário tem acesso ao estoque admin");
            }
        }
    }
}
