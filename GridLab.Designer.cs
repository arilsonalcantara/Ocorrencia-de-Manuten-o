namespace Ocorrencia_de_Manutenção
{
    partial class GridLab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridLab));
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbOrdena = new System.Windows.Forms.ToolStripComboBox();
            this.tsbOrdena = new System.Windows.Forms.ToolStripButton();
            this.txtPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.tsbPesquisaLab = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAlterarAdmLab = new System.Windows.Forms.ComboBox();
            this.btnAlteraAdm = new System.Windows.Forms.Button();
            this.cbAlteraAdm = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcluiLab = new System.Windows.Forms.Button();
            this.cbExcluirLab = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(329, 28);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(423, 214);
            this.dgvDados.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbOrdena,
            this.tsbOrdena,
            this.txtPesquisar,
            this.tsbPesquisaLab});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(754, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbOrdena
            // 
            this.cbOrdena.Items.AddRange(new object[] {
            "Codigo",
            "Administrador",
            "CodAdm",
            "Ocorrencias"});
            this.cbOrdena.Name = "cbOrdena";
            this.cbOrdena.Size = new System.Drawing.Size(140, 25);
            this.cbOrdena.Text = "Ordenar por...";
            // 
            // tsbOrdena
            // 
            this.tsbOrdena.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOrdena.Image = ((System.Drawing.Image)(resources.GetObject("tsbOrdena.Image")));
            this.tsbOrdena.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrdena.Name = "tsbOrdena";
            this.tsbOrdena.Size = new System.Drawing.Size(23, 22);
            this.tsbOrdena.Text = "toolStripButton1";
            this.tsbOrdena.Click += new System.EventHandler(this.TsbOrdena_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Font = new System.Drawing.Font("Verdana", 7F);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(116, 25);
            this.txtPesquisar.Text = "Pesquisar Laboratório";
            // 
            // tsbPesquisaLab
            // 
            this.tsbPesquisaLab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPesquisaLab.Image = ((System.Drawing.Image)(resources.GetObject("tsbPesquisaLab.Image")));
            this.tsbPesquisaLab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPesquisaLab.Name = "tsbPesquisaLab";
            this.tsbPesquisaLab.Size = new System.Drawing.Size(23, 22);
            this.tsbPesquisaLab.ToolTipText = "Pesquisar";
            this.tsbPesquisaLab.Click += new System.EventHandler(this.TsbPesquisaLab_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbAlterarAdmLab);
            this.groupBox1.Controls.Add(this.btnAlteraAdm);
            this.groupBox1.Controls.Add(this.cbAlteraAdm);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(14, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alterar o Administrador";
            // 
            // cbAlterarAdmLab
            // 
            this.cbAlterarAdmLab.FormattingEnabled = true;
            this.cbAlterarAdmLab.Location = new System.Drawing.Point(8, 20);
            this.cbAlterarAdmLab.Name = "cbAlterarAdmLab";
            this.cbAlterarAdmLab.Size = new System.Drawing.Size(94, 21);
            this.cbAlterarAdmLab.Sorted = true;
            this.cbAlterarAdmLab.TabIndex = 2;
            this.cbAlterarAdmLab.Text = "Laboratorio";
            // 
            // btnAlteraAdm
            // 
            this.btnAlteraAdm.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAlteraAdm.Location = new System.Drawing.Point(156, 40);
            this.btnAlteraAdm.Name = "btnAlteraAdm";
            this.btnAlteraAdm.Size = new System.Drawing.Size(70, 23);
            this.btnAlteraAdm.TabIndex = 1;
            this.btnAlteraAdm.Text = "Alterar";
            this.btnAlteraAdm.UseVisualStyleBackColor = true;
            this.btnAlteraAdm.Click += new System.EventHandler(this.BtnAlteraAdm_Click);
            // 
            // cbAlteraAdm
            // 
            this.cbAlteraAdm.FormattingEnabled = true;
            this.cbAlteraAdm.Location = new System.Drawing.Point(8, 42);
            this.cbAlteraAdm.Name = "cbAlteraAdm";
            this.cbAlteraAdm.Size = new System.Drawing.Size(140, 21);
            this.cbAlteraAdm.Sorted = true;
            this.cbAlteraAdm.TabIndex = 0;
            this.cbAlteraAdm.Text = "[Selecione]";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnExcluiLab);
            this.groupBox2.Controls.Add(this.cbExcluirLab);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(14, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 82);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excluir Laboratório";
            // 
            // btnExcluiLab
            // 
            this.btnExcluiLab.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnExcluiLab.Location = new System.Drawing.Point(156, 40);
            this.btnExcluiLab.Name = "btnExcluiLab";
            this.btnExcluiLab.Size = new System.Drawing.Size(70, 23);
            this.btnExcluiLab.TabIndex = 1;
            this.btnExcluiLab.Text = "Excluir";
            this.btnExcluiLab.UseVisualStyleBackColor = true;
            this.btnExcluiLab.Click += new System.EventHandler(this.BtnExcluiLab_Click);
            // 
            // cbExcluirLab
            // 
            this.cbExcluirLab.FormattingEnabled = true;
            this.cbExcluirLab.Location = new System.Drawing.Point(8, 42);
            this.cbExcluirLab.Name = "cbExcluirLab";
            this.cbExcluirLab.Size = new System.Drawing.Size(140, 21);
            this.cbExcluirLab.Sorted = true;
            this.cbExcluirLab.TabIndex = 0;
            this.cbExcluirLab.Text = "[Selecione]";
            // 
            // GridLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(754, 243);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDados);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GridLab";
            this.Text = "GridLab";
            this.Load += new System.EventHandler(this.GridLab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cbOrdena;
        private System.Windows.Forms.ToolStripButton tsbOrdena;
        private System.Windows.Forms.ToolStripTextBox txtPesquisar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlteraAdm;
        private System.Windows.Forms.ComboBox cbAlteraAdm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExcluiLab;
        private System.Windows.Forms.ComboBox cbExcluirLab;
        private System.Windows.Forms.ToolStripButton tsbPesquisaLab;
        private System.Windows.Forms.ComboBox cbAlterarAdmLab;
    }
}