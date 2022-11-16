namespace THR.Views.Expedicao
{
    partial class frmPainelCarregamentos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPainelCarregamentos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnNumeroCarregamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumeroRomaneio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRegião = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagePeriodo = new System.Windows.Forms.DataGridViewImageColumn();
            this.clnBolha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnOndulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imagem = new System.Windows.Forms.DataGridViewImageColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCaminhao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCapacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraFinalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTempoEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPesoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPorcentagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNumeroCarregamento,
            this.clnNumeroRomaneio,
            this.clnRegião,
            this.clnNomeMotorista,
            this.clnPeriodo,
            this.imagePeriodo,
            this.clnBolha,
            this.clnOndulado,
            this.clnUsuarioLancamento,
            this.clnDataHoraLancamento,
            this.Imagem,
            this.clnStatus,
            this.clnUsuarioFim,
            this.clnCaminhao,
            this.clnCapacidade,
            this.clnDataHoraFinalizacao,
            this.clnTempoEspera,
            this.clnPesoTotal,
            this.clnPorcentagem});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(37, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 45;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(952, 545);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // clnNumeroCarregamento
            // 
            this.clnNumeroCarregamento.DataPropertyName = "NumeroCarregamento";
            this.clnNumeroCarregamento.HeaderText = "Nº/Carregamento";
            this.clnNumeroCarregamento.Name = "clnNumeroCarregamento";
            this.clnNumeroCarregamento.ReadOnly = true;
            this.clnNumeroCarregamento.Visible = false;
            this.clnNumeroCarregamento.Width = 223;
            // 
            // clnNumeroRomaneio
            // 
            this.clnNumeroRomaneio.DataPropertyName = "NumeroRomaneio";
            this.clnNumeroRomaneio.HeaderText = "ROMANEIO";
            this.clnNumeroRomaneio.Name = "clnNumeroRomaneio";
            this.clnNumeroRomaneio.ReadOnly = true;
            this.clnNumeroRomaneio.Visible = false;
            this.clnNumeroRomaneio.Width = 153;
            // 
            // clnRegião
            // 
            this.clnRegião.DataPropertyName = "Regiao";
            this.clnRegião.HeaderText = "REGIÃO";
            this.clnRegião.Name = "clnRegião";
            this.clnRegião.ReadOnly = true;
            this.clnRegião.Width = 240;
            // 
            // clnNomeMotorista
            // 
            this.clnNomeMotorista.DataPropertyName = "NomeMotorista";
            this.clnNomeMotorista.HeaderText = "MOTORISTA";
            this.clnNomeMotorista.Name = "clnNomeMotorista";
            this.clnNomeMotorista.ReadOnly = true;
            this.clnNomeMotorista.Width = 150;
            // 
            // clnPeriodo
            // 
            this.clnPeriodo.DataPropertyName = "Periodo";
            this.clnPeriodo.HeaderText = "PERÍODO";
            this.clnPeriodo.Name = "clnPeriodo";
            this.clnPeriodo.ReadOnly = true;
            this.clnPeriodo.Visible = false;
            this.clnPeriodo.Width = 127;
            // 
            // imagePeriodo
            // 
            this.imagePeriodo.DataPropertyName = "imagePeriodo";
            this.imagePeriodo.HeaderText = "PERÍODO";
            this.imagePeriodo.Name = "imagePeriodo";
            this.imagePeriodo.ReadOnly = true;
            this.imagePeriodo.Width = 127;
            // 
            // clnBolha
            // 
            this.clnBolha.DataPropertyName = "Bolha";
            this.clnBolha.HeaderText = "BOL";
            this.clnBolha.Name = "clnBolha";
            this.clnBolha.ReadOnly = true;
            this.clnBolha.Width = 75;
            // 
            // clnOndulado
            // 
            this.clnOndulado.DataPropertyName = "Ondulado";
            this.clnOndulado.HeaderText = "OND";
            this.clnOndulado.Name = "clnOndulado";
            this.clnOndulado.ReadOnly = true;
            this.clnOndulado.Width = 80;
            // 
            // clnUsuarioLancamento
            // 
            this.clnUsuarioLancamento.DataPropertyName = "UsuarioLancamento";
            this.clnUsuarioLancamento.HeaderText = "Usuario";
            this.clnUsuarioLancamento.Name = "clnUsuarioLancamento";
            this.clnUsuarioLancamento.ReadOnly = true;
            this.clnUsuarioLancamento.Visible = false;
            this.clnUsuarioLancamento.Width = 276;
            // 
            // clnDataHoraLancamento
            // 
            this.clnDataHoraLancamento.DataPropertyName = "DataHoraLancamento";
            this.clnDataHoraLancamento.HeaderText = "DATA";
            this.clnDataHoraLancamento.Name = "clnDataHoraLancamento";
            this.clnDataHoraLancamento.ReadOnly = true;
            this.clnDataHoraLancamento.Width = 150;
            // 
            // Imagem
            // 
            this.Imagem.DataPropertyName = "ImageStatus";
            this.Imagem.HeaderText = "STATUS";
            this.Imagem.Name = "Imagem";
            this.Imagem.ReadOnly = true;
            this.Imagem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imagem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clnStatus
            // 
            this.clnStatus.DataPropertyName = "Status";
            this.clnStatus.HeaderText = "STATUS";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            this.clnStatus.Visible = false;
            this.clnStatus.Width = 107;
            // 
            // clnUsuarioFim
            // 
            this.clnUsuarioFim.DataPropertyName = "UsuarioFim";
            this.clnUsuarioFim.HeaderText = "Usuario/Fin.";
            this.clnUsuarioFim.Name = "clnUsuarioFim";
            this.clnUsuarioFim.ReadOnly = true;
            this.clnUsuarioFim.Visible = false;
            this.clnUsuarioFim.Width = 178;
            // 
            // clnCaminhao
            // 
            this.clnCaminhao.DataPropertyName = "Caminhao";
            this.clnCaminhao.HeaderText = "CAR.";
            this.clnCaminhao.Name = "clnCaminhao";
            this.clnCaminhao.ReadOnly = true;
            // 
            // clnCapacidade
            // 
            this.clnCapacidade.DataPropertyName = "Capacidade";
            this.clnCapacidade.HeaderText = "CAPAC.";
            this.clnCapacidade.Name = "clnCapacidade";
            this.clnCapacidade.ReadOnly = true;
            // 
            // clnDataHoraFinalizacao
            // 
            this.clnDataHoraFinalizacao.DataPropertyName = "DataHoraFim";
            this.clnDataHoraFinalizacao.HeaderText = "Data/Hora Fin.";
            this.clnDataHoraFinalizacao.Name = "clnDataHoraFinalizacao";
            this.clnDataHoraFinalizacao.ReadOnly = true;
            this.clnDataHoraFinalizacao.Visible = false;
            this.clnDataHoraFinalizacao.Width = 187;
            // 
            // clnTempoEspera
            // 
            this.clnTempoEspera.DataPropertyName = "TempoEspera";
            this.clnTempoEspera.HeaderText = "Tempo";
            this.clnTempoEspera.Name = "clnTempoEspera";
            this.clnTempoEspera.ReadOnly = true;
            this.clnTempoEspera.Visible = false;
            this.clnTempoEspera.Width = 115;
            // 
            // clnPesoTotal
            // 
            this.clnPesoTotal.DataPropertyName = "PesoTotal";
            this.clnPesoTotal.HeaderText = "PESO";
            this.clnPesoTotal.Name = "clnPesoTotal";
            this.clnPesoTotal.ReadOnly = true;
            // 
            // clnPorcentagem
            // 
            this.clnPorcentagem.DataPropertyName = "PorcentagemCarregada";
            this.clnPorcentagem.HeaderText = "%";
            this.clnPorcentagem.Name = "clnPorcentagem";
            this.clnPorcentagem.ReadOnly = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(217)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 545);
            this.panel1.TabIndex = 1;
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = global::THR.Properties.Resources.stop_button;
            this.btnStop.Location = new System.Drawing.Point(0, 33);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(37, 33);
            this.btnStop.TabIndex = 1;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = global::THR.Properties.Resources.play;
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(37, 33);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmPainelCarregamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 545);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPainelCarregamentos";
            this.Text = "Painel de carregamentos";
            this.Load += new System.EventHandler(this.frmPainelCarregamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroCarregamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroRomaneio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRegião;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPeriodo;
        private System.Windows.Forms.DataGridViewImageColumn imagePeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBolha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnOndulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraLancamento;
        private System.Windows.Forms.DataGridViewImageColumn Imagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCaminhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCapacidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraFinalizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTempoEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPesoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPorcentagem;
    }
}