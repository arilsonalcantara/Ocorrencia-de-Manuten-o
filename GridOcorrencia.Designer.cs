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
            this.tsbExcluir = new System.Windows.Forms.ToolStripButton();
            this.tsbPesquisar = new System.Windows.Forms.ToolStripButton();
            this.txtPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.gridOcorrenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cbPrioridade = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbLaboratorio = new System.Windows.Forms.ComboBox();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.TsbSalvar = new System.Windows.Forms.Button();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpAbertura = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPredio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOcorrenciaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(194, 28);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(607, 304);
            this.dgvDados.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExcluir,
            this.toolStripSeparator1,
            this.tsbEditar,
            this.toolStripSeparator2,
            this.txtPesquisar,
            this.tsbPesquisar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(801, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcluir.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluir.Image")));
            this.tsbExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(23, 22);
            this.tsbExcluir.Text = "Excluir";
            // 
            // tsbPesquisar
            // 
            this.tsbPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("tsbPesquisar.Image")));
            this.tsbPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPesquisar.Name = "tsbPesquisar";
            this.tsbPesquisar.Size = new System.Drawing.Size(23, 22);
            this.tsbPesquisar.Text = "Pesquisar";
            this.tsbPesquisar.ToolTipText = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(100, 25);
            this.txtPesquisar.Text = "Pesquisar";
            // 
            // gridOcorrenciaBindingSource
            // 
            this.gridOcorrenciaBindingSource.DataSource = typeof(Ocorrencia_de_Manutenção.GridOcorrencia);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(6, 55);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(182, 90);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.Text = "Digite aqui...";
            // 
            // cbPrioridade
            // 
            this.cbPrioridade.FormattingEnabled = true;
            this.cbPrioridade.Items.AddRange(new object[] {
            "Baixa",
            "Média",
            "Alta"});
            this.cbPrioridade.Location = new System.Drawing.Point(6, 164);
            this.cbPrioridade.Name = "cbPrioridade";
            this.cbPrioridade.Size = new System.Drawing.Size(121, 21);
            this.cbPrioridade.TabIndex = 3;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Pendente",
            "Em Análise",
            "Concluído"});
            this.cbStatus.Location = new System.Drawing.Point(6, 214);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 4;
            // 
            // cbLaboratorio
            // 
            this.cbLaboratorio.FormattingEnabled = true;
            this.cbLaboratorio.Items.AddRange(new object[] {
            "Pendente",
            "Em Análise",
            "Concluído"});
            this.cbLaboratorio.Location = new System.Drawing.Point(6, 311);
            this.cbLaboratorio.Name = "cbLaboratorio";
            this.cbLaboratorio.Size = new System.Drawing.Size(121, 21);
            this.cbLaboratorio.TabIndex = 5;
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Items.AddRange(new object[] {
            "Pendente",
            "Em Análise",
            "Concluído"});
            this.cbUsuario.Location = new System.Drawing.Point(6, 366);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(121, 21);
            this.cbUsuario.TabIndex = 6;
            // 
            // TsbSalvar
            // 
            this.TsbSalvar.Location = new System.Drawing.Point(373, 361);
            this.TsbSalvar.Name = "TsbSalvar";
            this.TsbSalvar.Size = new System.Drawing.Size(121, 23);
            this.TsbSalvar.TabIndex = 7;
            this.TsbSalvar.Text = "Salvar";
            this.TsbSalvar.UseVisualStyleBackColor = true;
            this.TsbSalvar.Click += new System.EventHandler(this.TsbSalvar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fale sobe a ocorrência";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prioridade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Laboratorio";
            // 
            // dtpAbertura
            // 
            this.dtpAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAbertura.Location = new System.Drawing.Point(194, 364);
            this.dtpAbertura.Name = "dtpAbertura";
            this.dtpAbertura.Size = new System.Drawing.Size(119, 20);
            this.dtpAbertura.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Selecione seu usuário";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data da Ocorrência";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Prédio";
            // 
            // cbPredio
            // 
            this.cbPredio.FormattingEnabled = true;
            this.cbPredio.Items.AddRange(new object[] {
            "Pendente",
            "Em Análise",
            "Concluído"});
            this.cbPredio.Location = new System.Drawing.Point(6, 262);
            this.cbPredio.Name = "cbPredio";
            this.cbPredio.Size = new System.Drawing.Size(121, 21);
            this.cbPredio.TabIndex = 15;
            this.cbPredio.TextChanged += new System.EventHandler(this.CbPredio_TextChanged);
            // 
            // GridOcorrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 412);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbPredio);
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
            this.Name = "GridOcorrencia";
            this.Text = "Ocorrências";
            this.Load += new System.EventHandler(this.GridOcorrencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOcorrenciaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbExcluir;
        private System.Windows.Forms.ToolStripButton tsbPesquisar;
        private System.Windows.Forms.ToolStripTextBox txtPesquisar;
        private System.Windows.Forms.BindingSource gridOcorrenciaBindingSource;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cbPrioridade;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbLaboratorio;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.Button TsbSalvar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DateTimePicker dtpAbertura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPredio;
    }
}