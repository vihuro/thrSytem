namespace THR.Views.Expedicao
{
    partial class frmControleCarregamentos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleCarregamentos));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cboCaminhao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.gpStatus = new System.Windows.Forms.GroupBox();
            this.rdbStatusFechado = new System.Windows.Forms.RadioButton();
            this.rdbStatusAberto = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroCarregamento = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPesoTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRomaneio = new System.Windows.Forms.TextBox();
            this.gpOndulado = new System.Windows.Forms.GroupBox();
            this.rdbOnduladoNao = new System.Windows.Forms.RadioButton();
            this.rdbOnduladoSim = new System.Windows.Forms.RadioButton();
            this.gpBolha = new System.Windows.Forms.GroupBox();
            this.rdbBolhaNao = new System.Windows.Forms.RadioButton();
            this.rdbBolhaSim = new System.Windows.Forms.RadioButton();
            this.gpPeriodoCarregamento = new System.Windows.Forms.GroupBox();
            this.rdbNoite = new System.Windows.Forms.RadioButton();
            this.rdbManha = new System.Windows.Forms.RadioButton();
            this.cboRegiao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNomeMotorista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.clnNumeroCarregamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumeroRomanerio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRegiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPeriodoCarregamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBolha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnOndulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeUsuarioLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCaminhao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCapacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPorcentagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioFinalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraFinalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTempoEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpStatus.SuspendLayout();
            this.gpOndulado.SuspendLayout();
            this.gpBolha.SuspendLayout();
            this.gpPeriodoCarregamento.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 568);
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
            this.splitContainer1.Panel2.Controls.Add(this.cboCaminhao);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.btnAlterar);
            this.splitContainer1.Panel2.Controls.Add(this.gpStatus);
            this.splitContainer1.Panel2.Controls.Add(this.btnSalvar);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtNumeroCarregamento);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txtPesoTotal);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtRomaneio);
            this.splitContainer1.Panel2.Controls.Add(this.gpOndulado);
            this.splitContainer1.Panel2.Controls.Add(this.gpBolha);
            this.splitContainer1.Panel2.Controls.Add(this.gpPeriodoCarregamento);
            this.splitContainer1.Panel2.Controls.Add(this.cboRegiao);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.cboNomeMotorista);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1117, 568);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(103)))));
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
            this.clnNomeMotorista,
            this.clnRegiao,
            this.clnPeriodoCarregamento,
            this.clnBolha,
            this.clnOndulado,
            this.clnNomeUsuarioLancamento,
            this.clnDataHoraLancamento,
            this.clnStatus,
            this.clnCaminhao,
            this.clnCapacidade,
            this.clnPorcentagem,
            this.clnUsuarioFinalizacao,
            this.clnDataHoraFinalizacao,
            this.clnTempoEspera,
            this.clnPeso});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.dataGridView1.Size = new System.Drawing.Size(1115, 217);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // cboCaminhao
            // 
            this.cboCaminhao.BackColor = System.Drawing.Color.White;
            this.cboCaminhao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaminhao.FormattingEnabled = true;
            this.cboCaminhao.Items.AddRange(new object[] {
            ""});
            this.cboCaminhao.Location = new System.Drawing.Point(125, 119);
            this.cboCaminhao.Name = "cboCaminhao";
            this.cboCaminhao.Size = new System.Drawing.Size(302, 21);
            this.cboCaminhao.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Caminhão:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Enabled = false;
            this.btnAlterar.Location = new System.Drawing.Point(1022, 257);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // gpStatus
            // 
            this.gpStatus.Controls.Add(this.rdbStatusFechado);
            this.gpStatus.Controls.Add(this.rdbStatusAberto);
            this.gpStatus.Location = new System.Drawing.Point(919, 16);
            this.gpStatus.Name = "gpStatus";
            this.gpStatus.Size = new System.Drawing.Size(178, 61);
            this.gpStatus.TabIndex = 12;
            this.gpStatus.TabStop = false;
            this.gpStatus.Text = "Status";
            // 
            // rdbStatusFechado
            // 
            this.rdbStatusFechado.AutoSize = true;
            this.rdbStatusFechado.Location = new System.Drawing.Point(103, 29);
            this.rdbStatusFechado.Name = "rdbStatusFechado";
            this.rdbStatusFechado.Size = new System.Drawing.Size(67, 17);
            this.rdbStatusFechado.TabIndex = 12;
            this.rdbStatusFechado.TabStop = true;
            this.rdbStatusFechado.Text = "Fechado";
            this.rdbStatusFechado.UseVisualStyleBackColor = true;
            // 
            // rdbStatusAberto
            // 
            this.rdbStatusAberto.AutoSize = true;
            this.rdbStatusAberto.Location = new System.Drawing.Point(6, 29);
            this.rdbStatusAberto.Name = "rdbStatusAberto";
            this.rdbStatusAberto.Size = new System.Drawing.Size(56, 17);
            this.rdbStatusAberto.TabIndex = 11;
            this.rdbStatusAberto.TabStop = true;
            this.rdbStatusAberto.Text = "Aberto";
            this.rdbStatusAberto.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(941, 308);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            // txtNumeroCarregamento
            // 
            this.txtNumeroCarregamento.Location = new System.Drawing.Point(125, 41);
            this.txtNumeroCarregamento.Name = "txtNumeroCarregamento";
            this.txtNumeroCarregamento.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCarregamento.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(1022, 308);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Peso/Total:";
            // 
            // txtPesoTotal
            // 
            this.txtPesoTotal.Location = new System.Drawing.Point(346, 154);
            this.txtPesoTotal.Name = "txtPesoTotal";
            this.txtPesoTotal.Size = new System.Drawing.Size(81, 20);
            this.txtPesoTotal.TabIndex = 4;
            this.txtPesoTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesoTotal_KeyPress);
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
            this.txtRomaneio.TabIndex = 1;
            this.txtRomaneio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRomaneio_KeyDown);
            // 
            // gpOndulado
            // 
            this.gpOndulado.Controls.Add(this.rdbOnduladoNao);
            this.gpOndulado.Controls.Add(this.rdbOnduladoSim);
            this.gpOndulado.Location = new System.Drawing.Point(433, 201);
            this.gpOndulado.Name = "gpOndulado";
            this.gpOndulado.Size = new System.Drawing.Size(178, 61);
            this.gpOndulado.TabIndex = 11;
            this.gpOndulado.TabStop = false;
            this.gpOndulado.Text = "Ondulado?";
            // 
            // rdbOnduladoNao
            // 
            this.rdbOnduladoNao.AutoSize = true;
            this.rdbOnduladoNao.Location = new System.Drawing.Point(122, 29);
            this.rdbOnduladoNao.Name = "rdbOnduladoNao";
            this.rdbOnduladoNao.Size = new System.Drawing.Size(48, 17);
            this.rdbOnduladoNao.TabIndex = 10;
            this.rdbOnduladoNao.TabStop = true;
            this.rdbOnduladoNao.Text = "NÃO";
            this.rdbOnduladoNao.UseVisualStyleBackColor = true;
            // 
            // rdbOnduladoSim
            // 
            this.rdbOnduladoSim.AutoSize = true;
            this.rdbOnduladoSim.Location = new System.Drawing.Point(6, 29);
            this.rdbOnduladoSim.Name = "rdbOnduladoSim";
            this.rdbOnduladoSim.Size = new System.Drawing.Size(44, 17);
            this.rdbOnduladoSim.TabIndex = 9;
            this.rdbOnduladoSim.TabStop = true;
            this.rdbOnduladoSim.Text = "SIM";
            this.rdbOnduladoSim.UseVisualStyleBackColor = true;
            // 
            // gpBolha
            // 
            this.gpBolha.Controls.Add(this.rdbBolhaNao);
            this.gpBolha.Controls.Add(this.rdbBolhaSim);
            this.gpBolha.Location = new System.Drawing.Point(224, 199);
            this.gpBolha.Name = "gpBolha";
            this.gpBolha.Size = new System.Drawing.Size(203, 61);
            this.gpBolha.TabIndex = 10;
            this.gpBolha.TabStop = false;
            this.gpBolha.Text = "Bolha?";
            // 
            // rdbBolhaNao
            // 
            this.rdbBolhaNao.AutoSize = true;
            this.rdbBolhaNao.Location = new System.Drawing.Point(122, 29);
            this.rdbBolhaNao.Name = "rdbBolhaNao";
            this.rdbBolhaNao.Size = new System.Drawing.Size(48, 17);
            this.rdbBolhaNao.TabIndex = 8;
            this.rdbBolhaNao.TabStop = true;
            this.rdbBolhaNao.Text = "NÃO";
            this.rdbBolhaNao.UseVisualStyleBackColor = true;
            // 
            // rdbBolhaSim
            // 
            this.rdbBolhaSim.AutoSize = true;
            this.rdbBolhaSim.Location = new System.Drawing.Point(6, 29);
            this.rdbBolhaSim.Name = "rdbBolhaSim";
            this.rdbBolhaSim.Size = new System.Drawing.Size(44, 17);
            this.rdbBolhaSim.TabIndex = 7;
            this.rdbBolhaSim.TabStop = true;
            this.rdbBolhaSim.Text = "SIM";
            this.rdbBolhaSim.UseVisualStyleBackColor = true;
            // 
            // gpPeriodoCarregamento
            // 
            this.gpPeriodoCarregamento.Controls.Add(this.rdbNoite);
            this.gpPeriodoCarregamento.Controls.Add(this.rdbManha);
            this.gpPeriodoCarregamento.Location = new System.Drawing.Point(27, 199);
            this.gpPeriodoCarregamento.Name = "gpPeriodoCarregamento";
            this.gpPeriodoCarregamento.Size = new System.Drawing.Size(191, 61);
            this.gpPeriodoCarregamento.TabIndex = 9;
            this.gpPeriodoCarregamento.TabStop = false;
            this.gpPeriodoCarregamento.Text = "Período de carregamento";
            // 
            // rdbNoite
            // 
            this.rdbNoite.AutoSize = true;
            this.rdbNoite.Location = new System.Drawing.Point(107, 29);
            this.rdbNoite.Name = "rdbNoite";
            this.rdbNoite.Size = new System.Drawing.Size(58, 17);
            this.rdbNoite.TabIndex = 6;
            this.rdbNoite.TabStop = true;
            this.rdbNoite.Text = "NOITE";
            this.rdbNoite.UseVisualStyleBackColor = true;
            // 
            // rdbManha
            // 
            this.rdbManha.AutoSize = true;
            this.rdbManha.Location = new System.Drawing.Point(7, 29);
            this.rdbManha.Name = "rdbManha";
            this.rdbManha.Size = new System.Drawing.Size(64, 17);
            this.rdbManha.TabIndex = 5;
            this.rdbManha.TabStop = true;
            this.rdbManha.Text = "MANHÃ";
            this.rdbManha.UseVisualStyleBackColor = true;
            // 
            // cboRegiao
            // 
            this.cboRegiao.BackColor = System.Drawing.Color.White;
            this.cboRegiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegiao.FormattingEnabled = true;
            this.cboRegiao.Items.AddRange(new object[] {
            ""});
            this.cboRegiao.Location = new System.Drawing.Point(125, 154);
            this.cboRegiao.Name = "cboRegiao";
            this.cboRegiao.Size = new System.Drawing.Size(146, 21);
            this.cboRegiao.TabIndex = 3;
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
            // cboNomeMotorista
            // 
            this.cboNomeMotorista.BackColor = System.Drawing.Color.White;
            this.cboNomeMotorista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNomeMotorista.FormattingEnabled = true;
            this.cboNomeMotorista.Items.AddRange(new object[] {
            ""});
            this.cboNomeMotorista.Location = new System.Drawing.Point(125, 88);
            this.cboNomeMotorista.Name = "cboNomeMotorista";
            this.cboNomeMotorista.Size = new System.Drawing.Size(302, 21);
            this.cboNomeMotorista.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome/Motorista:";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(49)))), ((int)(((byte)(146)))));
            this.panelMenu.Controls.Add(this.btnRelatorio);
            this.panelMenu.Controls.Add(this.btnFiltro);
            this.panelMenu.Controls.Add(this.btnNovo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(37, 568);
            this.panelMenu.TabIndex = 10;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Image = global::THR.Properties.Resources.clipboard;
            this.btnRelatorio.Location = new System.Drawing.Point(0, 66);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(37, 33);
            this.btnRelatorio.TabIndex = 2;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFiltro.FlatAppearance.BorderSize = 0;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.Image = global::THR.Properties.Resources.filter__1_;
            this.btnFiltro.Location = new System.Drawing.Point(0, 33);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(37, 33);
            this.btnFiltro.TabIndex = 1;
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Image = global::THR.Properties.Resources.plus;
            this.btnNovo.Location = new System.Drawing.Point(0, 0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(37, 33);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // clnNumeroCarregamento
            // 
            this.clnNumeroCarregamento.DataPropertyName = "NumeroCarregamento";
            this.clnNumeroCarregamento.HeaderText = "Nº/Carregamento";
            this.clnNumeroCarregamento.Name = "clnNumeroCarregamento";
            this.clnNumeroCarregamento.ReadOnly = true;
            this.clnNumeroCarregamento.Visible = false;
            // 
            // clnNumeroRomanerio
            // 
            this.clnNumeroRomanerio.DataPropertyName = "NumeroRomaneio";
            this.clnNumeroRomanerio.HeaderText = "Nº/Romaneio";
            this.clnNumeroRomanerio.Name = "clnNumeroRomanerio";
            this.clnNumeroRomanerio.ReadOnly = true;
            this.clnNumeroRomanerio.Width = 80;
            // 
            // clnNomeMotorista
            // 
            this.clnNomeMotorista.DataPropertyName = "NomeMotorista";
            this.clnNomeMotorista.HeaderText = "Motorista";
            this.clnNomeMotorista.Name = "clnNomeMotorista";
            this.clnNomeMotorista.ReadOnly = true;
            this.clnNomeMotorista.Width = 150;
            // 
            // clnRegiao
            // 
            this.clnRegiao.DataPropertyName = "Regiao";
            this.clnRegiao.HeaderText = "Região";
            this.clnRegiao.Name = "clnRegiao";
            this.clnRegiao.ReadOnly = true;
            this.clnRegiao.Width = 150;
            // 
            // clnPeriodoCarregamento
            // 
            this.clnPeriodoCarregamento.DataPropertyName = "Periodo";
            this.clnPeriodoCarregamento.HeaderText = "Período";
            this.clnPeriodoCarregamento.Name = "clnPeriodoCarregamento";
            this.clnPeriodoCarregamento.ReadOnly = true;
            this.clnPeriodoCarregamento.Width = 60;
            // 
            // clnBolha
            // 
            this.clnBolha.DataPropertyName = "Bolha";
            this.clnBolha.HeaderText = "Bolha";
            this.clnBolha.Name = "clnBolha";
            this.clnBolha.ReadOnly = true;
            this.clnBolha.Width = 60;
            // 
            // clnOndulado
            // 
            this.clnOndulado.DataPropertyName = "Ondulado";
            this.clnOndulado.HeaderText = "Ondulado";
            this.clnOndulado.Name = "clnOndulado";
            this.clnOndulado.ReadOnly = true;
            this.clnOndulado.Width = 60;
            // 
            // clnNomeUsuarioLancamento
            // 
            this.clnNomeUsuarioLancamento.DataPropertyName = "UsuarioLancamento";
            this.clnNomeUsuarioLancamento.HeaderText = "Usuário/Lançamento";
            this.clnNomeUsuarioLancamento.Name = "clnNomeUsuarioLancamento";
            this.clnNomeUsuarioLancamento.ReadOnly = true;
            this.clnNomeUsuarioLancamento.Width = 120;
            // 
            // clnDataHoraLancamento
            // 
            this.clnDataHoraLancamento.DataPropertyName = "DataHoraLancamento";
            this.clnDataHoraLancamento.HeaderText = "Data/Hora Lanc.";
            this.clnDataHoraLancamento.Name = "clnDataHoraLancamento";
            this.clnDataHoraLancamento.ReadOnly = true;
            this.clnDataHoraLancamento.Width = 120;
            // 
            // clnStatus
            // 
            this.clnStatus.DataPropertyName = "Status";
            this.clnStatus.HeaderText = "Status";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            this.clnStatus.Width = 80;
            // 
            // clnCaminhao
            // 
            this.clnCaminhao.DataPropertyName = "Caminhao";
            this.clnCaminhao.HeaderText = "Carro";
            this.clnCaminhao.Name = "clnCaminhao";
            this.clnCaminhao.ReadOnly = true;
            this.clnCaminhao.Width = 50;
            // 
            // clnCapacidade
            // 
            this.clnCapacidade.DataPropertyName = "Capacidade";
            this.clnCapacidade.HeaderText = "Capac.";
            this.clnCapacidade.Name = "clnCapacidade";
            this.clnCapacidade.ReadOnly = true;
            this.clnCapacidade.Width = 50;
            // 
            // clnPorcentagem
            // 
            this.clnPorcentagem.DataPropertyName = "PorcentagemCarregada";
            this.clnPorcentagem.HeaderText = "%";
            this.clnPorcentagem.Name = "clnPorcentagem";
            this.clnPorcentagem.ReadOnly = true;
            this.clnPorcentagem.Width = 50;
            // 
            // clnUsuarioFinalizacao
            // 
            this.clnUsuarioFinalizacao.DataPropertyName = "UsuarioFim";
            this.clnUsuarioFinalizacao.HeaderText = "Usuário/Fin.";
            this.clnUsuarioFinalizacao.Name = "clnUsuarioFinalizacao";
            this.clnUsuarioFinalizacao.ReadOnly = true;
            // 
            // clnDataHoraFinalizacao
            // 
            this.clnDataHoraFinalizacao.DataPropertyName = "DataHoraFim";
            this.clnDataHoraFinalizacao.HeaderText = "Data/Hora Fin.";
            this.clnDataHoraFinalizacao.Name = "clnDataHoraFinalizacao";
            this.clnDataHoraFinalizacao.ReadOnly = true;
            this.clnDataHoraFinalizacao.Width = 120;
            // 
            // clnTempoEspera
            // 
            this.clnTempoEspera.DataPropertyName = "TempoEspera";
            this.clnTempoEspera.HeaderText = "Tempo/Espera";
            this.clnTempoEspera.Name = "clnTempoEspera";
            this.clnTempoEspera.ReadOnly = true;
            // 
            // clnPeso
            // 
            this.clnPeso.DataPropertyName = "PesoTotal";
            this.clnPeso.HeaderText = "Peso/Total";
            this.clnPeso.Name = "clnPeso";
            this.clnPeso.ReadOnly = true;
            this.clnPeso.Width = 80;
            // 
            // frmControleCarregamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 590);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmControleCarregamentos";
            this.Text = "Carregamento";
            this.Load += new System.EventHandler(this.frmControleCarregamentos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmControleCarregamentos_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpStatus.ResumeLayout(false);
            this.gpStatus.PerformLayout();
            this.gpOndulado.ResumeLayout(false);
            this.gpOndulado.PerformLayout();
            this.gpBolha.ResumeLayout(false);
            this.gpBolha.PerformLayout();
            this.gpPeriodoCarregamento.ResumeLayout(false);
            this.gpPeriodoCarregamento.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpOndulado;
        private System.Windows.Forms.RadioButton rdbOnduladoNao;
        private System.Windows.Forms.RadioButton rdbOnduladoSim;
        private System.Windows.Forms.GroupBox gpBolha;
        private System.Windows.Forms.RadioButton rdbBolhaNao;
        private System.Windows.Forms.RadioButton rdbBolhaSim;
        private System.Windows.Forms.GroupBox gpPeriodoCarregamento;
        private System.Windows.Forms.RadioButton rdbNoite;
        private System.Windows.Forms.RadioButton rdbManha;
        private System.Windows.Forms.ComboBox cboRegiao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNomeMotorista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPesoTotal;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumeroCarregamento;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gpStatus;
        private System.Windows.Forms.RadioButton rdbStatusFechado;
        private System.Windows.Forms.RadioButton rdbStatusAberto;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ComboBox cboCaminhao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroCarregamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroRomanerio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRegiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPeriodoCarregamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBolha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnOndulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeUsuarioLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCaminhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCapacidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPorcentagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioFinalizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraFinalizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTempoEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPeso;
    }
}