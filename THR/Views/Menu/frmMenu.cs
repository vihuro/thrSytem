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
            this.Cursor = Cursors.WaitCursor;

            AtivarBotoes();
            //ColorirBotoes();
            getButton(panelMenu);
            VoltarPosicaoBotoes();

            this.Cursor = Cursors.Default;
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
                            btnPainelColetas.Enabled = true;
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

            btnPainelColetas.Enabled = true;

            foreach (var permissoes in modulosService.ListaAcessos())
            {
                switch (modulosService.DefinirAcessos(acessos, permissoes))
                {
                    case true:
                        if(permissoes == "Expedição - Admin" || permissoes == "Expedição - Alterações" ||
                            permissoes == "Expedição - Comunicador")
                        {
                            btnControleMotoristas.Enabled = true;
                            if(permissoes == "Expedição - Admin")
                            {
                                btnGerenciarCoresPainel.Enabled = true;
                            }
                        }

                        break;
                }
            }

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
                btnGerenciarCoresPainel.Text = "Gerenciar cores do Painel";
            }
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (panelMenu.Width == 206)
            {
                VoltarPosicaoBotoes();

            }
            else
            {
                btnMenu.ImageAlign = ContentAlignment.MiddleRight;
                panelMenu.Width = 206;
                btnExpedicao.Text = "Expedição";
                btnEstoque.Text = "Estoque";
                btnGerenciarCoresPainel.Text = "Gerenciar cores do Painel";

            }

            this.Cursor = Cursors.Default;
        }

        private void VoltarPosicaoBotoes()
        {
            this.Cursor = Cursors.WaitCursor;

            panelMenu.Width = 37;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnControleMotoristas.Visible = false;
            btnPainelColetas.Visible = false;
            btnControleEstoque.Visible = false;
            btnGerenciarCoresPainel.Visible = false;
            btnExpedicao.Text = "";
            btnEstoque.Text = "";
            btnGerenciarCoresPainel.Text = "";

            this.Cursor = Cursors.Default;
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (btnControleEstoque.Visible == false)
            {
                VerificarPosicaoPanelMenu();
                btnControleEstoque.Visible = true;
            }
            else
            {
                btnControleEstoque.Visible = false;

            }
            this.Cursor = Cursors.Default;
        }

        private void btnExpedicao_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (btnControleMotoristas.Visible == false)
            {
                VerificarPosicaoPanelMenu();

                btnPainelColetas.Visible = true;
                btnControleMotoristas.Visible = true;
                btnGerenciarCoresPainel.Visible = true;
            }
            else
            {

                btnControleMotoristas.Visible = false;
                btnPainelColetas.Visible = false;
                btnGerenciarCoresPainel.Visible = false;

            }

            this.Cursor = Cursors.Default;
        }

        private void btnControleMotoristas_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmControleCarregamentos motoristas = new frmControleCarregamentos(loginDto, acessos);
            motoristas.lblUsuario.Text = this.lblUsuario.Text;
            motoristas.Show();

            this.Cursor = Cursors.Default;
        }

        private void btnPainelColetas_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmPainelCarregamentos painel = new frmPainelCarregamentos(loginDto, acessos);
            painel.Show();

            this.Cursor = Cursors.Default;
        }

        private void btnGerenciarCoresPainel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmGerenciarCoresPainelControleCarregamentos cores = new frmGerenciarCoresPainelControleCarregamentos(loginDto, acessos);
            cores.lblUsuario.Text = this.lblUsuario.Text;
            cores.Show();

            this.Cursor = Cursors.Default;
        }
    }
}
