namespace THR.Views.Menu
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnControleEstoque = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnPainelColetas = new System.Windows.Forms.Button();
            this.btnControleMotoristas = new System.Windows.Forms.Button();
            this.btnExpedicao = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 515);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(49)))), ((int)(((byte)(146)))));
            this.panelMenu.Controls.Add(this.btnControleEstoque);
            this.panelMenu.Controls.Add(this.btnEstoque);
            this.panelMenu.Controls.Add(this.btnPainelColetas);
            this.panelMenu.Controls.Add(this.btnControleMotoristas);
            this.panelMenu.Controls.Add(this.btnExpedicao);
            this.panelMenu.Controls.Add(this.btnMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(206, 515);
            this.panelMenu.TabIndex = 4;
            // 
            // btnControleEstoque
            // 
            this.btnControleEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(217)))));
            this.btnControleEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControleEstoque.Enabled = false;
            this.btnControleEstoque.FlatAppearance.BorderSize = 0;
            this.btnControleEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControleEstoque.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleEstoque.ForeColor = System.Drawing.Color.White;
            this.btnControleEstoque.Location = new System.Drawing.Point(0, 165);
            this.btnControleEstoque.Margin = new System.Windows.Forms.Padding(0);
            this.btnControleEstoque.Name = "btnControleEstoque";
            this.btnControleEstoque.Size = new System.Drawing.Size(206, 33);
            this.btnControleEstoque.TabIndex = 6;
            this.btnControleEstoque.Text = "Controle de Estoque";
            this.btnControleEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControleEstoque.UseVisualStyleBackColor = false;
            this.btnControleEstoque.Visible = false;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = global::THR.Properties.Resources.box;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(0, 132);
            this.btnEstoque.Margin = new System.Windows.Forms.Padding(0);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(206, 33);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnPainelColetas
            // 
            this.btnPainelColetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(217)))));
            this.btnPainelColetas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPainelColetas.Enabled = false;
            this.btnPainelColetas.FlatAppearance.BorderSize = 0;
            this.btnPainelColetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPainelColetas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPainelColetas.ForeColor = System.Drawing.Color.White;
            this.btnPainelColetas.Location = new System.Drawing.Point(0, 99);
            this.btnPainelColetas.Margin = new System.Windows.Forms.Padding(0);
            this.btnPainelColetas.Name = "btnPainelColetas";
            this.btnPainelColetas.Size = new System.Drawing.Size(206, 33);
            this.btnPainelColetas.TabIndex = 3;
            this.btnPainelColetas.Text = "Painel/Coletas";
            this.btnPainelColetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPainelColetas.UseVisualStyleBackColor = false;
            this.btnPainelColetas.Visible = false;
            this.btnPainelColetas.Click += new System.EventHandler(this.btnPainelColetas_Click);
            // 
            // btnControleMotoristas
            // 
            this.btnControleMotoristas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(76)))), ((int)(((byte)(217)))));
            this.btnControleMotoristas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControleMotoristas.Enabled = false;
            this.btnControleMotoristas.FlatAppearance.BorderSize = 0;
            this.btnControleMotoristas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControleMotoristas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleMotoristas.ForeColor = System.Drawing.Color.White;
            this.btnControleMotoristas.Location = new System.Drawing.Point(0, 66);
            this.btnControleMotoristas.Margin = new System.Windows.Forms.Padding(0);
            this.btnControleMotoristas.Name = "btnControleMotoristas";
            this.btnControleMotoristas.Size = new System.Drawing.Size(206, 33);
            this.btnControleMotoristas.TabIndex = 2;
            this.btnControleMotoristas.Text = "Controle de motoristas";
            this.btnControleMotoristas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnControleMotoristas.UseVisualStyleBackColor = false;
            this.btnControleMotoristas.Visible = false;
            this.btnControleMotoristas.Click += new System.EventHandler(this.btnControleMotoristas_Click);
            // 
            // btnExpedicao
            // 
            this.btnExpedicao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpedicao.FlatAppearance.BorderSize = 0;
            this.btnExpedicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpedicao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpedicao.ForeColor = System.Drawing.Color.White;
            this.btnExpedicao.Image = global::THR.Properties.Resources.cargo_truck;
            this.btnExpedicao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpedicao.Location = new System.Drawing.Point(0, 33);
            this.btnExpedicao.Margin = new System.Windows.Forms.Padding(0);
            this.btnExpedicao.Name = "btnExpedicao";
            this.btnExpedicao.Size = new System.Drawing.Size(206, 33);
            this.btnExpedicao.TabIndex = 1;
            this.btnExpedicao.Text = "Expedição";
            this.btnExpedicao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExpedicao.UseVisualStyleBackColor = true;
            this.btnExpedicao.Click += new System.EventHandler(this.btnExpedicao_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Image = global::THR.Properties.Resources.hamburger;
            this.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(206, 33);
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 537);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnControleEstoque;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnPainelColetas;
        private System.Windows.Forms.Button btnControleMotoristas;
        private System.Windows.Forms.Button btnExpedicao;
        private System.Windows.Forms.Button btnMenu;
        public System.Windows.Forms.ToolStripStatusLabel lblUsuario;
    }
}