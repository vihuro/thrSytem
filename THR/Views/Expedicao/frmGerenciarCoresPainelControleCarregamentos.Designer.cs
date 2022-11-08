namespace THR.Views.Expedicao
{
    partial class frmGerenciarCoresPainelControleCarregamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarCoresPainelControleCarregamentos));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbSegundaCondicao = new System.Windows.Forms.RadioButton();
            this.rdbPrimeiraCondicao = new System.Windows.Forms.RadioButton();
            this.cboPrimeiraCondicao = new System.Windows.Forms.ComboBox();
            this.txtSegundoValor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrimeiroValor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboSegundaCondicao = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBlueLetra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGreenLetra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRedLetra = new System.Windows.Forms.TextBox();
            this.gpColuna = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBlueColuna = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGreenColuna = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRedColuna = new System.Windows.Forms.TextBox();
            this.cboPalavraChave = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboColuna = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.clnNumeroCarregamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRomaneio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRegiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBolha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnOndulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTempoEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPesoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpColuna.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel2.AutoScrollMinSize = new System.Drawing.Size(2, 2);
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.gpColuna);
            this.splitContainer1.Panel2.Controls.Add(this.cboPalavraChave);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.cboColuna);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.btnSalvar);
            this.splitContainer1.Size = new System.Drawing.Size(867, 476);
            this.splitContainer1.SplitterDistance = 166;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNumeroCarregamento,
            this.clnRomaneio,
            this.clnMotorista,
            this.clnRegiao,
            this.clnPeriodo,
            this.clnBolha,
            this.clnOndulado,
            this.clnUsuarioLancamento,
            this.clnDataHoraLancamento,
            this.clnStatus,
            this.clnUsuarioFim,
            this.clnDataHoraFin,
            this.clnTempoEspera,
            this.clnPesoTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
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
            this.dataGridView1.Size = new System.Drawing.Size(865, 164);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbSegundaCondicao);
            this.groupBox2.Controls.Add(this.rdbPrimeiraCondicao);
            this.groupBox2.Controls.Add(this.cboPrimeiraCondicao);
            this.groupBox2.Controls.Add(this.txtSegundoValor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPrimeiroValor);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cboSegundaCondicao);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(527, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 145);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Condições";
            // 
            // rdbSegundaCondicao
            // 
            this.rdbSegundaCondicao.AutoSize = true;
            this.rdbSegundaCondicao.Enabled = false;
            this.rdbSegundaCondicao.Location = new System.Drawing.Point(205, 19);
            this.rdbSegundaCondicao.Name = "rdbSegundaCondicao";
            this.rdbSegundaCondicao.Size = new System.Drawing.Size(115, 17);
            this.rdbSegundaCondicao.TabIndex = 23;
            this.rdbSegundaCondicao.TabStop = true;
            this.rdbSegundaCondicao.Text = "Segunda condição";
            this.rdbSegundaCondicao.UseVisualStyleBackColor = true;
            this.rdbSegundaCondicao.CheckedChanged += new System.EventHandler(this.rdbSegundaCondicao_CheckedChanged);
            // 
            // rdbPrimeiraCondicao
            // 
            this.rdbPrimeiraCondicao.AutoSize = true;
            this.rdbPrimeiraCondicao.Enabled = false;
            this.rdbPrimeiraCondicao.Location = new System.Drawing.Point(19, 19);
            this.rdbPrimeiraCondicao.Name = "rdbPrimeiraCondicao";
            this.rdbPrimeiraCondicao.Size = new System.Drawing.Size(109, 17);
            this.rdbPrimeiraCondicao.TabIndex = 22;
            this.rdbPrimeiraCondicao.TabStop = true;
            this.rdbPrimeiraCondicao.Text = "Primeira condição";
            this.rdbPrimeiraCondicao.UseVisualStyleBackColor = true;
            this.rdbPrimeiraCondicao.CheckedChanged += new System.EventHandler(this.rdbPrimeiraCondicao_CheckedChanged);
            // 
            // cboPrimeiraCondicao
            // 
            this.cboPrimeiraCondicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrimeiraCondicao.Enabled = false;
            this.cboPrimeiraCondicao.Location = new System.Drawing.Point(110, 57);
            this.cboPrimeiraCondicao.Name = "cboPrimeiraCondicao";
            this.cboPrimeiraCondicao.Size = new System.Drawing.Size(80, 21);
            this.cboPrimeiraCondicao.TabIndex = 17;
            // 
            // txtSegundoValor
            // 
            this.txtSegundoValor.Enabled = false;
            this.txtSegundoValor.Location = new System.Drawing.Point(267, 90);
            this.txtSegundoValor.Name = "txtSegundoValor";
            this.txtSegundoValor.Size = new System.Drawing.Size(53, 20);
            this.txtSegundoValor.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Primeira Condição:";
            // 
            // txtPrimeiroValor
            // 
            this.txtPrimeiroValor.Enabled = false;
            this.txtPrimeiroValor.Location = new System.Drawing.Point(267, 58);
            this.txtPrimeiroValor.Name = "txtPrimeiroValor";
            this.txtPrimeiroValor.Size = new System.Drawing.Size(53, 20);
            this.txtPrimeiroValor.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Segunda condição:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(227, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Valor:";
            // 
            // cboSegundaCondicao
            // 
            this.cboSegundaCondicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSegundaCondicao.Enabled = false;
            this.cboSegundaCondicao.Location = new System.Drawing.Point(110, 89);
            this.cboSegundaCondicao.Name = "cboSegundaCondicao";
            this.cboSegundaCondicao.Size = new System.Drawing.Size(80, 21);
            this.cboSegundaCondicao.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(227, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Valor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBlueLetra);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtGreenLetra);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtRedLetra);
            this.groupBox1.Location = new System.Drawing.Point(527, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 84);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cor da letra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "B";
            // 
            // txtBlueLetra
            // 
            this.txtBlueLetra.Location = new System.Drawing.Point(137, 46);
            this.txtBlueLetra.Name = "txtBlueLetra";
            this.txtBlueLetra.Size = new System.Drawing.Size(53, 20);
            this.txtBlueLetra.TabIndex = 10;
            this.txtBlueLetra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBluePalavraChave_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(97, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "G";
            // 
            // txtGreenLetra
            // 
            this.txtGreenLetra.Location = new System.Drawing.Point(78, 46);
            this.txtGreenLetra.Name = "txtGreenLetra";
            this.txtGreenLetra.Size = new System.Drawing.Size(53, 20);
            this.txtGreenLetra.TabIndex = 8;
            this.txtGreenLetra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGreenPalavraChave_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "R";
            // 
            // txtRedLetra
            // 
            this.txtRedLetra.Location = new System.Drawing.Point(19, 46);
            this.txtRedLetra.Name = "txtRedLetra";
            this.txtRedLetra.Size = new System.Drawing.Size(53, 20);
            this.txtRedLetra.TabIndex = 0;
            this.txtRedLetra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRedPalavraChave_KeyPress);
            // 
            // gpColuna
            // 
            this.gpColuna.Controls.Add(this.label6);
            this.gpColuna.Controls.Add(this.txtBlueColuna);
            this.gpColuna.Controls.Add(this.label5);
            this.gpColuna.Controls.Add(this.txtGreenColuna);
            this.gpColuna.Controls.Add(this.label4);
            this.gpColuna.Controls.Add(this.txtRedColuna);
            this.gpColuna.Location = new System.Drawing.Point(92, 183);
            this.gpColuna.Name = "gpColuna";
            this.gpColuna.Size = new System.Drawing.Size(213, 84);
            this.gpColuna.TabIndex = 6;
            this.gpColuna.TabStop = false;
            this.gpColuna.Text = "Cor de fundo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "B";
            // 
            // txtBlueColuna
            // 
            this.txtBlueColuna.Location = new System.Drawing.Point(137, 46);
            this.txtBlueColuna.Name = "txtBlueColuna";
            this.txtBlueColuna.Size = new System.Drawing.Size(53, 20);
            this.txtBlueColuna.TabIndex = 10;
            this.txtBlueColuna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBlueColuna_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "G";
            // 
            // txtGreenColuna
            // 
            this.txtGreenColuna.Location = new System.Drawing.Point(78, 46);
            this.txtGreenColuna.Name = "txtGreenColuna";
            this.txtGreenColuna.Size = new System.Drawing.Size(53, 20);
            this.txtGreenColuna.TabIndex = 8;
            this.txtGreenColuna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGreenColuna_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "R";
            // 
            // txtRedColuna
            // 
            this.txtRedColuna.Location = new System.Drawing.Point(19, 46);
            this.txtRedColuna.Name = "txtRedColuna";
            this.txtRedColuna.Size = new System.Drawing.Size(53, 20);
            this.txtRedColuna.TabIndex = 0;
            this.txtRedColuna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRedColuna_KeyPress);
            // 
            // cboPalavraChave
            // 
            this.cboPalavraChave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPalavraChave.Location = new System.Drawing.Point(133, 52);
            this.cboPalavraChave.Name = "cboPalavraChave";
            this.cboPalavraChave.Size = new System.Drawing.Size(172, 21);
            this.cboPalavraChave.TabIndex = 14;
            this.cboPalavraChave.SelectedValueChanged += new System.EventHandler(this.cboPalavraChave_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Palavra chave:";
            // 
            // cboColuna
            // 
            this.cboColuna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColuna.FormattingEnabled = true;
            this.cboColuna.Items.AddRange(new object[] {
            "NomeMotorista",
            "Regiao",
            "Periodo",
            "Bolha",
            "Ondulado",
            "UsuarioLancamento",
            "DataHoraLancamento",
            "Status",
            "UsuarioFim",
            "DataHoraFim",
            "TempoEspera",
            "PesoTotal"});
            this.cboColuna.Location = new System.Drawing.Point(133, 22);
            this.cboColuna.Name = "cboColuna";
            this.cboColuna.Size = new System.Drawing.Size(172, 21);
            this.cboColuna.TabIndex = 2;
            this.cboColuna.SelectedValueChanged += new System.EventHandler(this.cboColuna_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coluna:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(778, 269);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 13;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Coluna:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(49)))), ((int)(((byte)(146)))));
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 498);
            this.panel1.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::THR.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(37, 33);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(37, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(867, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // clnNumeroCarregamento
            // 
            this.clnNumeroCarregamento.DataPropertyName = "NumeroCarregamento";
            this.clnNumeroCarregamento.HeaderText = "NumeroCarregamento";
            this.clnNumeroCarregamento.Name = "clnNumeroCarregamento";
            this.clnNumeroCarregamento.ReadOnly = true;
            this.clnNumeroCarregamento.Visible = false;
            // 
            // clnRomaneio
            // 
            this.clnRomaneio.DataPropertyName = "NumeroRomaneio";
            this.clnRomaneio.HeaderText = "Romaneio";
            this.clnRomaneio.Name = "clnRomaneio";
            this.clnRomaneio.ReadOnly = true;
            // 
            // clnMotorista
            // 
            this.clnMotorista.DataPropertyName = "NomeMotorista";
            this.clnMotorista.HeaderText = "Motorista";
            this.clnMotorista.Name = "clnMotorista";
            this.clnMotorista.ReadOnly = true;
            // 
            // clnRegiao
            // 
            this.clnRegiao.DataPropertyName = "Regiao";
            this.clnRegiao.HeaderText = "Região";
            this.clnRegiao.Name = "clnRegiao";
            this.clnRegiao.ReadOnly = true;
            // 
            // clnPeriodo
            // 
            this.clnPeriodo.DataPropertyName = "Periodo";
            this.clnPeriodo.HeaderText = "Periodo";
            this.clnPeriodo.Name = "clnPeriodo";
            this.clnPeriodo.ReadOnly = true;
            // 
            // clnBolha
            // 
            this.clnBolha.DataPropertyName = "Bolha";
            this.clnBolha.HeaderText = "Bolha";
            this.clnBolha.Name = "clnBolha";
            this.clnBolha.ReadOnly = true;
            // 
            // clnOndulado
            // 
            this.clnOndulado.DataPropertyName = "Ondulado";
            this.clnOndulado.HeaderText = "Ondulado";
            this.clnOndulado.Name = "clnOndulado";
            this.clnOndulado.ReadOnly = true;
            // 
            // clnUsuarioLancamento
            // 
            this.clnUsuarioLancamento.DataPropertyName = "UsuarioLancamento";
            this.clnUsuarioLancamento.HeaderText = "Usuário/Lancamento";
            this.clnUsuarioLancamento.Name = "clnUsuarioLancamento";
            this.clnUsuarioLancamento.ReadOnly = true;
            // 
            // clnDataHoraLancamento
            // 
            this.clnDataHoraLancamento.DataPropertyName = "DataHoraLancamento";
            this.clnDataHoraLancamento.HeaderText = "Data/Hora Lan.";
            this.clnDataHoraLancamento.Name = "clnDataHoraLancamento";
            this.clnDataHoraLancamento.ReadOnly = true;
            // 
            // clnStatus
            // 
            this.clnStatus.DataPropertyName = "Status";
            this.clnStatus.HeaderText = "Status";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            // 
            // clnUsuarioFim
            // 
            this.clnUsuarioFim.DataPropertyName = "UsuarioFim";
            this.clnUsuarioFim.HeaderText = "Usuário/Fin.";
            this.clnUsuarioFim.Name = "clnUsuarioFim";
            this.clnUsuarioFim.ReadOnly = true;
            this.clnUsuarioFim.Visible = false;
            // 
            // clnDataHoraFin
            // 
            this.clnDataHoraFin.DataPropertyName = "DataHoraFim";
            this.clnDataHoraFin.HeaderText = "Data/Hora Fin.";
            this.clnDataHoraFin.Name = "clnDataHoraFin";
            this.clnDataHoraFin.ReadOnly = true;
            this.clnDataHoraFin.Visible = false;
            // 
            // clnTempoEspera
            // 
            this.clnTempoEspera.DataPropertyName = "TempoEspera";
            this.clnTempoEspera.HeaderText = "Tempo/Espera";
            this.clnTempoEspera.Name = "clnTempoEspera";
            this.clnTempoEspera.ReadOnly = true;
            // 
            // clnPesoTotal
            // 
            this.clnPesoTotal.DataPropertyName = "PesoTotal";
            this.clnPesoTotal.HeaderText = "Peso/Total";
            this.clnPesoTotal.Name = "clnPesoTotal";
            this.clnPesoTotal.ReadOnly = true;
            // 
            // frmGerenciarCoresPainelControleCarregamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 498);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciarCoresPainelControleCarregamentos";
            this.Text = "Cores Painel";
            this.Load += new System.EventHandler(this.frmGerenciarCoresPainelControleCarregamentos_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpColuna.ResumeLayout(false);
            this.gpColuna.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBlueLetra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGreenLetra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRedLetra;
        private System.Windows.Forms.GroupBox gpColuna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBlueColuna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGreenColuna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRedColuna;
        private System.Windows.Forms.ComboBox cboPalavraChave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboColuna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ComboBox cboPrimeiraCondicao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrimeiroValor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbPrimeiraCondicao;
        private System.Windows.Forms.TextBox txtSegundoValor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboSegundaCondicao;
        private System.Windows.Forms.RadioButton rdbSegundaCondicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroCarregamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRomaneio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRegiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBolha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnOndulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTempoEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPesoTotal;
    }
}