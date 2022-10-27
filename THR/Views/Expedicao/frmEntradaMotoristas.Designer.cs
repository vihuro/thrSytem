namespace THR.Views.Expedicao
{
    partial class frmEntradaMotoristas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntradaMotoristas));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnNumeroCarregamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumeroRomanerio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRegiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPeriodoCarregamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBolha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnOndulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeUsuarioLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioFinalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraFinalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPesoTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRomaneio = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbOnduladoNao = new System.Windows.Forms.RadioButton();
            this.rdbOnduladoSim = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbBolhaNao = new System.Windows.Forms.RadioButton();
            this.rdbBolhaSim = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNoite = new System.Windows.Forms.RadioButton();
            this.rdbManha = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1154, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(37, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.btnFinalizar);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnAlterar);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txtPesoTotal);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtRomaneio);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1117, 526);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(49)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(49)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNumeroCarregamento,
            this.clnNumeroRomanerio,
            this.clnRegiao,
            this.clnPeriodoCarregamento,
            this.clnBolha,
            this.clnOndulado,
            this.clnNomeUsuarioLancamento,
            this.clnDataHoraLancamento,
            this.clnStatus,
            this.clnUsuarioFinalizacao,
            this.clnDataHoraFinalizacao});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // clnNumeroCarregamento
            // 
            this.clnNumeroCarregamento.HeaderText = "Nº/Carreamento";
            this.clnNumeroCarregamento.Name = "clnNumeroCarregamento";
            this.clnNumeroCarregamento.ReadOnly = true;
            // 
            // clnNumeroRomanerio
            // 
            this.clnNumeroRomanerio.HeaderText = "Nº/Romaneio";
            this.clnNumeroRomanerio.Name = "clnNumeroRomanerio";
            this.clnNumeroRomanerio.ReadOnly = true;
            // 
            // clnRegiao
            // 
            this.clnRegiao.HeaderText = "Região";
            this.clnRegiao.Name = "clnRegiao";
            this.clnRegiao.ReadOnly = true;
            // 
            // clnPeriodoCarregamento
            // 
            this.clnPeriodoCarregamento.HeaderText = "Período";
            this.clnPeriodoCarregamento.Name = "clnPeriodoCarregamento";
            this.clnPeriodoCarregamento.ReadOnly = true;
            // 
            // clnBolha
            // 
            this.clnBolha.HeaderText = "Bolha(Sim/Não)";
            this.clnBolha.Name = "clnBolha";
            this.clnBolha.ReadOnly = true;
            this.clnBolha.Width = 120;
            // 
            // clnOndulado
            // 
            this.clnOndulado.HeaderText = "Ondulado(Sim/Não)";
            this.clnOndulado.Name = "clnOndulado";
            this.clnOndulado.ReadOnly = true;
            this.clnOndulado.Width = 120;
            // 
            // clnNomeUsuarioLancamento
            // 
            this.clnNomeUsuarioLancamento.HeaderText = "Usuário/Lançamento";
            this.clnNomeUsuarioLancamento.Name = "clnNomeUsuarioLancamento";
            this.clnNomeUsuarioLancamento.ReadOnly = true;
            // 
            // clnDataHoraLancamento
            // 
            this.clnDataHoraLancamento.HeaderText = "Data/Hora Lanc.";
            this.clnDataHoraLancamento.Name = "clnDataHoraLancamento";
            this.clnDataHoraLancamento.ReadOnly = true;
            // 
            // clnStatus
            // 
            this.clnStatus.HeaderText = "Status";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            // 
            // clnUsuarioFinalizacao
            // 
            this.clnUsuarioFinalizacao.HeaderText = "Usuário/Fin.";
            this.clnUsuarioFinalizacao.Name = "clnUsuarioFinalizacao";
            this.clnUsuarioFinalizacao.ReadOnly = true;
            // 
            // clnDataHoraFinalizacao
            // 
            this.clnDataHoraFinalizacao.HeaderText = "Data/Hora Fin.";
            this.clnDataHoraFinalizacao.Name = "clnDataHoraFinalizacao";
            this.clnDataHoraFinalizacao.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nº/Carregamento:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizar.Location = new System.Drawing.Point(930, 281);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 18;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(1022, 281);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Location = new System.Drawing.Point(1022, 239);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Peso/Total:";
            // 
            // txtPesoTotal
            // 
            this.txtPesoTotal.Location = new System.Drawing.Point(327, 154);
            this.txtPesoTotal.Name = "txtPesoTotal";
            this.txtPesoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtPesoTotal.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nº/Romaneio";
            // 
            // txtRomaneio
            // 
            this.txtRomaneio.Location = new System.Drawing.Point(327, 41);
            this.txtRomaneio.Name = "txtRomaneio";
            this.txtRomaneio.Size = new System.Drawing.Size(100, 20);
            this.txtRomaneio.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbOnduladoNao);
            this.groupBox3.Controls.Add(this.rdbOnduladoSim);
            this.groupBox3.Location = new System.Drawing.Point(703, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(178, 61);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ondulado?";
            // 
            // rdbOnduladoNao
            // 
            this.rdbOnduladoNao.AutoSize = true;
            this.rdbOnduladoNao.Location = new System.Drawing.Point(122, 29);
            this.rdbOnduladoNao.Name = "rdbOnduladoNao";
            this.rdbOnduladoNao.Size = new System.Drawing.Size(45, 17);
            this.rdbOnduladoNao.TabIndex = 6;
            this.rdbOnduladoNao.TabStop = true;
            this.rdbOnduladoNao.Text = "Não";
            this.rdbOnduladoNao.UseVisualStyleBackColor = true;
            // 
            // rdbOnduladoSim
            // 
            this.rdbOnduladoSim.AutoSize = true;
            this.rdbOnduladoSim.Location = new System.Drawing.Point(6, 29);
            this.rdbOnduladoSim.Name = "rdbOnduladoSim";
            this.rdbOnduladoSim.Size = new System.Drawing.Size(42, 17);
            this.rdbOnduladoSim.TabIndex = 5;
            this.rdbOnduladoSim.TabStop = true;
            this.rdbOnduladoSim.Text = "Sim";
            this.rdbOnduladoSim.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbBolhaNao);
            this.groupBox2.Controls.Add(this.rdbBolhaSim);
            this.groupBox2.Location = new System.Drawing.Point(479, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 61);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bolha?";
            // 
            // rdbBolhaNao
            // 
            this.rdbBolhaNao.AutoSize = true;
            this.rdbBolhaNao.Location = new System.Drawing.Point(122, 29);
            this.rdbBolhaNao.Name = "rdbBolhaNao";
            this.rdbBolhaNao.Size = new System.Drawing.Size(45, 17);
            this.rdbBolhaNao.TabIndex = 6;
            this.rdbBolhaNao.TabStop = true;
            this.rdbBolhaNao.Text = "Não";
            this.rdbBolhaNao.UseVisualStyleBackColor = true;
            // 
            // rdbBolhaSim
            // 
            this.rdbBolhaSim.AutoSize = true;
            this.rdbBolhaSim.Location = new System.Drawing.Point(6, 29);
            this.rdbBolhaSim.Name = "rdbBolhaSim";
            this.rdbBolhaSim.Size = new System.Drawing.Size(42, 17);
            this.rdbBolhaSim.TabIndex = 5;
            this.rdbBolhaSim.TabStop = true;
            this.rdbBolhaSim.Text = "Sim";
            this.rdbBolhaSim.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNoite);
            this.groupBox1.Controls.Add(this.rdbManha);
            this.groupBox1.Location = new System.Drawing.Point(27, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 61);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Período de carregamento";
            // 
            // rdbNoite
            // 
            this.rdbNoite.AutoSize = true;
            this.rdbNoite.Location = new System.Drawing.Point(316, 29);
            this.rdbNoite.Name = "rdbNoite";
            this.rdbNoite.Size = new System.Drawing.Size(50, 17);
            this.rdbNoite.TabIndex = 6;
            this.rdbNoite.TabStop = true;
            this.rdbNoite.Text = "Noite";
            this.rdbNoite.UseVisualStyleBackColor = true;
            // 
            // rdbManha
            // 
            this.rdbManha.AutoSize = true;
            this.rdbManha.Location = new System.Drawing.Point(7, 29);
            this.rdbManha.Name = "rdbManha";
            this.rdbManha.Size = new System.Drawing.Size(58, 17);
            this.rdbManha.TabIndex = 5;
            this.rdbManha.TabStop = true;
            this.rdbManha.Text = "Manhã";
            this.rdbManha.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(125, 154);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(98, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zona/Região:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(302, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome/Motorista:";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(49)))), ((int)(((byte)(146)))));
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(37, 526);
            this.panelMenu.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::THR.Properties.Resources.clipboard;
            this.button2.Location = new System.Drawing.Point(0, 33);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 33);
            this.button2.TabIndex = 3;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::THR.Properties.Resources.filter__1_;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 33);
            this.button1.TabIndex = 2;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmEntradaMotoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 548);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEntradaMotoristas";
            this.Text = "Carregamento";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRomaneio;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbOnduladoNao;
        private System.Windows.Forms.RadioButton rdbOnduladoSim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbBolhaNao;
        private System.Windows.Forms.RadioButton rdbBolhaSim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNoite;
        private System.Windows.Forms.RadioButton rdbManha;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPesoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroCarregamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroRomanerio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRegiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPeriodoCarregamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBolha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnOndulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeUsuarioLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioFinalizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraFinalizacao;
        public System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}