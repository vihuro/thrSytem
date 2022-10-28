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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnNumeroCarregamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumeroRomaneio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRegião = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBolha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnOndulado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioFim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraFinalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPesoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNumeroCarregamento,
            this.clnNumeroRomaneio,
            this.clnNomeMotorista,
            this.clnRegião,
            this.clnPeriodo,
            this.clnBolha,
            this.clnOndulado,
            this.clnUsuarioLancamento,
            this.clnDataHoraLancamento,
            this.clnStatus,
            this.clnUsuarioFim,
            this.clnDataHoraFinalizacao,
            this.clnPesoTotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridView1.Size = new System.Drawing.Size(805, 545);
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
            // 
            // clnNumeroRomaneio
            // 
            this.clnNumeroRomaneio.DataPropertyName = "NumeroRomaneio";
            this.clnNumeroRomaneio.HeaderText = "Romaneio";
            this.clnNumeroRomaneio.Name = "clnNumeroRomaneio";
            this.clnNumeroRomaneio.ReadOnly = true;
            this.clnNumeroRomaneio.Width = 120;
            // 
            // clnNomeMotorista
            // 
            this.clnNomeMotorista.DataPropertyName = "NomeMotorista";
            this.clnNomeMotorista.HeaderText = "Motorista";
            this.clnNomeMotorista.Name = "clnNomeMotorista";
            this.clnNomeMotorista.ReadOnly = true;
            // 
            // clnRegião
            // 
            this.clnRegião.DataPropertyName = "Regiao";
            this.clnRegião.HeaderText = "Região.";
            this.clnRegião.Name = "clnRegião";
            this.clnRegião.ReadOnly = true;
            // 
            // clnPeriodo
            // 
            this.clnPeriodo.DataPropertyName = "Periodo";
            this.clnPeriodo.HeaderText = "Periodo";
            this.clnPeriodo.Name = "clnPeriodo";
            this.clnPeriodo.ReadOnly = true;
            this.clnPeriodo.Width = 80;
            // 
            // clnBolha
            // 
            this.clnBolha.DataPropertyName = "Bolha";
            this.clnBolha.HeaderText = "Bolha";
            this.clnBolha.Name = "clnBolha";
            this.clnBolha.ReadOnly = true;
            this.clnBolha.Width = 80;
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
            this.clnUsuarioLancamento.Visible = false;
            // 
            // clnDataHoraLancamento
            // 
            this.clnDataHoraLancamento.DataPropertyName = "DataHoraLancamento";
            this.clnDataHoraLancamento.HeaderText = "Data/Hora Lançamento";
            this.clnDataHoraLancamento.Name = "clnDataHoraLancamento";
            this.clnDataHoraLancamento.ReadOnly = true;
            this.clnDataHoraLancamento.Visible = false;
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
            this.clnUsuarioFim.HeaderText = "Usuario/Fin.";
            this.clnUsuarioFim.Name = "clnUsuarioFim";
            this.clnUsuarioFim.ReadOnly = true;
            this.clnUsuarioFim.Visible = false;
            // 
            // clnDataHoraFinalizacao
            // 
            this.clnDataHoraFinalizacao.DataPropertyName = "DataHoraFim";
            this.clnDataHoraFinalizacao.HeaderText = "Data/Hora Fin.";
            this.clnDataHoraFinalizacao.Name = "clnDataHoraFinalizacao";
            this.clnDataHoraFinalizacao.ReadOnly = true;
            this.clnDataHoraFinalizacao.Visible = false;
            // 
            // clnPesoTotal
            // 
            this.clnPesoTotal.DataPropertyName = "PesoTotal";
            this.clnPesoTotal.HeaderText = "Peso/Total";
            this.clnPesoTotal.Name = "clnPesoTotal";
            this.clnPesoTotal.ReadOnly = true;
            // 
            // frmPainelCarregamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 545);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPainelCarregamentos";
            this.Text = "Painel de carregamentos";
            this.Load += new System.EventHandler(this.frmPainelCarregamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroCarregamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroRomaneio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRegião;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBolha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnOndulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioFim;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraFinalizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPesoTotal;
    }
}