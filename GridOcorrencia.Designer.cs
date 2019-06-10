namespace Ocorrencia_de_Manutenção
{
    partial class GridOcorrencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridOcorrencia));
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.txtPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.tsbPesquisar = new System.Windows.Forms.ToolStripButton();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cbPrioridade = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbLaboratorio = new System.Windows.Forms.ComboBox();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.TsbSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpAbertura = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpAtualizado = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdSetup = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSelecione = new System.Windows.Forms.ComboBox();
            this.cbOrdena = new System.Windows.Forms.ToolStripComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gridOcorrenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOcorrenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.GridColor = System.Drawing.Color.DimGray;
            this.dgvDados.Location = new System.Drawing.Point(226, 28);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(708, 304);
            this.dgvDados.TabIndex = 0;
            this.dgvDados.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDados_ColumnHeaderMouseClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Font = new System.Drawing.Font("Verdana", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbOrdena,
            this.toolStripButton1,
            this.txtPesquisar,
            this.tsbPesquisar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(116, 25);
            this.txtPesquisar.Text = "Pesquise pelo ID";
            // 
            // tsbPesquisar
            // 
            this.tsbPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("tsbPesquisar.Image")));
            this.tsbPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPesquisar.Name = "tsbPesquisar";
            this.tsbPesquisar.Size = new System.Drawing.Size(23, 22);
            this.tsbPesquisar.Text = "Pesquise pelo ID";
            this.tsbPesquisar.ToolTipText = "Pesquisar";
            this.tsbPesquisar.Click += new System.EventHandler(this.TsbPesquisar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.LightGray;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Location = new System.Drawing.Point(7, 55);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(212, 90);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.Text = "Digite aqui...";
            // 
            // cbPrioridade
            // 
            this.cbPrioridade.BackColor = System.Drawing.Color.LightGray;
            this.cbPrioridade.FormattingEnabled = true;
            this.cbPrioridade.Items.AddRange(new object[] {
            "Alta",
            "Baixa",
            "Média"});
            this.cbPrioridade.Location = new System.Drawing.Point(7, 164);
            this.cbPrioridade.Name = "cbPrioridade";
            this.cbPrioridade.Size = new System.Drawing.Size(140, 21);
            this.cbPrioridade.Sorted = true;
            this.cbPrioridade.TabIndex = 3;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.LightGray;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Concluído",
            "Em Análise",
            "Pendente"});
            this.cbStatus.Location = new System.Drawing.Point(7, 214);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(140, 21);
            this.cbStatus.Sorted = true;
            this.cbStatus.TabIndex = 4;
            // 
            // cbLaboratorio
            // 
            this.cbLaboratorio.BackColor = System.Drawing.Color.LightGray;
            this.cbLaboratorio.FormattingEnabled = true;
            this.cbLaboratorio.Location = new System.Drawing.Point(7, 272);
            this.cbLaboratorio.Name = "cbLaboratorio";
            this.cbLaboratorio.Size = new System.Drawing.Size(140, 21);
            this.cbLaboratorio.Sorted = true;
            this.cbLaboratorio.TabIndex = 5;
            // 
            // cbUsuario
            // 
            this.cbUsuario.BackColor = System.Drawing.Color.LightGray;
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Items.AddRange(new object[] {
            "Concluído",
            "Em Análise",
            "Pendente"});
            this.cbUsuario.Location = new System.Drawing.Point(7, 329);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(140, 21);
            this.cbUsuario.Sorted = true;
            this.cbUsuario.TabIndex = 6;
            // 
            // TsbSalvar
            // 
            this.TsbSalvar.Location = new System.Drawing.Point(317, 379);
            this.TsbSalvar.Name = "TsbSalvar";
            this.TsbSalvar.Size = new System.Drawing.Size(141, 23);
            this.TsbSalvar.TabIndex = 7;
            this.TsbSalvar.Text = "Salvar";
            this.TsbSalvar.UseVisualStyleBackColor = true;
            this.TsbSalvar.Click += new System.EventHandler(this.TsbSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fale sobe a ocorrência";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prioridade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(8, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(8, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Laboratorio";
            // 
            // dtpAbertura
            // 
            this.dtpAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAbertura.Location = new System.Drawing.Point(7, 380);
            this.dtpAbertura.Name = "dtpAbertura";
            this.dtpAbertura.Size = new System.Drawing.Size(138, 21);
            this.dtpAbertura.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(8, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Selecione seu usuário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(7, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data da Ocorrência";
            // 
            // dtpAtualizado
            // 
            this.dtpAtualizado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAtualizado.Location = new System.Drawing.Point(153, 381);
            this.dtpAtualizado.Name = "dtpAtualizado";
            this.dtpAtualizado.Size = new System.Drawing.Size(138, 21);
            this.dtpAtualizado.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(156, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Última Modificação";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cbSelecione);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtIdSetup);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(478, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 59);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SETUP";
            // 
            // txtIdSetup
            // 
            this.txtIdSetup.BackColor = System.Drawing.Color.LightGray;
            this.txtIdSetup.Location = new System.Drawing.Point(7, 35);
            this.txtIdSetup.Name = "txtIdSetup";
            this.txtIdSetup.Size = new System.Drawing.Size(39, 21);
            this.txtIdSetup.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "ID";
            // 
            // cbSelecione
            // 
            this.cbSelecione.BackColor = System.Drawing.Color.LightGray;
            this.cbSelecione.FormattingEnabled = true;
            this.cbSelecione.Items.AddRange(new object[] {
            "Editar",
            "Excluir"});
            this.cbSelecione.Location = new System.Drawing.Point(54, 34);
            this.cbSelecione.Name = "cbSelecione";
            this.cbSelecione.Size = new System.Drawing.Size(86, 21);
            this.cbSelecione.Sorted = true;
            this.cbSelecione.TabIndex = 2;
            // 
            // cbOrdena
            // 
            this.cbOrdena.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cbOrdena.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cbOrdena.Items.AddRange(new object[] {
            "DatadeAbertura",
            "ID",
            "Laboratorio",
            "Prioridade",
            "Status"});
            this.cbOrdena.Name = "cbOrdena";
            this.cbOrdena.Size = new System.Drawing.Size(140, 25);
            this.cbOrdena.Sorted = true;
            this.cbOrdena.Text = "[Ordene por...]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Selecione";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // gridOcorrenciaBindingSource
            // 
            this.gridOcorrenciaBindingSource.DataSource = typeof(Ocorrencia_de_Manutenção.GridOcorrencia);
            // 
            // GridOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpAtualizado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpAbertura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TsbSalvar);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.cbLaboratorio);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbPrioridade);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDados);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GridOcorrencia";
            this.Text = "Ocorrências";
            this.Load += new System.EventHandler(this.GridOcorrencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOcorrenciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPesquisar;
        private System.Windows.Forms.ToolStripTextBox txtPesquisar;
        private System.Windows.Forms.BindingSource gridOcorrenciaBindingSource;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cbPrioridade;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbLaboratorio;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Button TsbSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpAbertura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpAtualizado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripComboBox cbOrdena;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSelecione;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdSetup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}