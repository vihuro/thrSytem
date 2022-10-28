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
using THR.Views.Expedicao;
using System.Runtime.InteropServices;

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
            //ColorirBotoes();
            getButton(panelMenu);
            VoltarPosicaoBotoes();
        }


        public static void getButton(Control c)
        {
            for(int i = 0; i < c.Controls.Count; i++)
            {
                if (c.Controls[i] is Button)
                {
                    if (!((Button)c.Controls[i]).Enabled)
                    {
                        c.Controls[i].BackColor = Color.FromArgb(128, 128, 128);
                    }
                }
            }
        }

        private void AtivarBotoes()
        {

            foreach(var permissoes in modulosService.ListaAcessos())
            {
                switch (modulosService.DefinirAcessos(acessos, permissoes))
                {
                    case true:

                        if(permissoes.Contains("Expedição"))
                        {
                            AtivarbotoesExpedicao();

                        }
                        else if (permissoes == "Estoque")
                        {
                            AtivarBotoesEstoque();

                        }

                        break;
                }
            }

        }

        public void AtivarbotoesExpedicao()
        {
            btnControleMotoristas.Enabled = true;
            btnPainelColetas.Enabled = true;
        }
        public void AtivarBotoesEstoque()
        {
            btnControleEstoque.Enabled = true;
            btnPainelColetas.Enabled = true;
        }


        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Verifica se o menu está minimizado e se estiver, maximiza!
        public void VerificarPosicaoPanelMenu()
        {
            if (panelMenu.Width == 37)
            {
                panelMenu.Width = 206;
                btnMenu.ImageAlign = ContentAlignment.MiddleRight;
                btnExpedicao.Text = "Expedição";
                btnEstoque.Text = "Estoque";
            }
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(panelMenu.Width == 206)
            {
                VoltarPosicaoBotoes();

            }
            else
            {
                btnMenu.ImageAlign = ContentAlignment.MiddleRight;
                panelMenu.Width = 206;
                btnExpedicao.Text = "Expedição";
                btnEstoque.Text = "Estoque";

            }
        }

        private void VoltarPosicaoBotoes()
        {
            panelMenu.Width = 37;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnControleMotoristas.Visible = false;
            btnPainelColetas.Visible = false;
            btnControleEstoque.Visible = false;
            btnExpedicao.Text = "";
            btnEstoque.Text = "";
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            if(btnControleEstoque.Visible == false)
            {
                VerificarPosicaoPanelMenu();
                btnControleEstoque.Visible = true;
            }
            else
            {
                btnControleEstoque.Visible = false;

            }
        }

        private void btnExpedicao_Click(object sender, EventArgs e)
        {
            if (btnControleMotoristas.Visible == false)
            {
                VerificarPosicaoPanelMenu();

                btnPainelColetas.Visible = true;
                btnControleMotoristas.Visible = true;
            }
            else
            {

                btnControleMotoristas.Visible = false;
                btnPainelColetas.Visible = false;

            }
        }

        private void btnControleMotoristas_Click(object sender, EventArgs e)
        {
            frmControleCarregamentos motoristas = new frmControleCarregamentos(loginDto, acessos);
            motoristas.lblUsuario.Text = this.lblUsuario.Text;
            motoristas.Show();
        }

        private void btnPainelColetas_Click(object sender, EventArgs e)
        {
            frmPainelCarregamentos painel = new frmPainelCarregamentos(loginDto);
            painel.Show();
        }
    }
}
