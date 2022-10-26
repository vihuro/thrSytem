﻿using System;
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
using THR.Service.CustonException;
using THR.Views.Menu;

namespace THR
{
    public partial class frmLogin : Form
    {
        private LoginDto dto;
        private LoginController controller;
        public frmLogin()
        {
            InitializeComponent();
            dto = new LoginDto();
            controller = new LoginController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dto.Apelido = txtUsuario.Text;
            dto.Senha = txtSenha.Text;
            try
            {
                var acessos = controller.Verify(dto);

                frmMenu menu = new frmMenu(dto, acessos);
                menu.lblUsuario.Text = $"Usuário: {txtUsuario.Text.ToLower()}";

                this.txtSenha.Text = string.Empty;
                this.txtUsuario.Text = string.Empty;

                menu.Show();

            }
            catch (ServiceException ex)
            {

                MessageBox.Show(ex.Message, "THR SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}