namespace Ocorrencia_de_Manutenção
{
    partial class GridUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GridUsuarios));
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbOrdena = new System.Windows.Forms.ToolStripComboBox();
            this.tsbOrdena = new System.Windows.Forms.ToolStripButton();
            this.tsbPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.tsbPesquisaUser = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcluiLab = new System.Windows.Forms.Button();
            this.cbExcluirUser = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNovoUsername = new System.Windows.Forms.TextBox();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(331, 34);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(539, 283);
            this.dgvDados.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbOrdena,
            this.tsbOrdena,
            this.tsbPesquisar,
            this.tsbPesquisaUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(318, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbOrdena
            // 
            this.cbOrdena.BackColor = System.Drawing.SystemColors.Menu;
            this.cbOrdena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOrdena.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cbOrdena.Items.AddRange(new object[] {
            "Codigo",
            "Tipo",
            "Username"});
            this.cbOrdena.Name = "cbOrdena";
            this.cbOrdena.Size = new System.Drawing.Size(140, 25);
            this.cbOrdena.Sorted = true;
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
            // tsbPesquisar
            // 
            this.tsbPesquisar.BackColor = System.Drawing.SystemColors.Menu;
            this.tsbPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tsbPesquisar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tsbPesquisar.Name = "tsbPesquisar";
            this.tsbPesquisar.Size = new System.Drawing.Size(116, 25);
            this.tsbPesquisar.Text = "Pesquisar";
            // 
            // tsbPesquisaUser
            // 
            this.tsbPesquisaUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPesquisaUser.Image = ((System.Drawing.Image)(resources.GetObject("tsbPesquisaUser.Image")));
            this.tsbPesquisaUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPesquisaUser.Name = "tsbPesquisaUser";
            this.tsbPesquisaUser.Size = new System.Drawing.Size(23, 22);
            this.tsbPesquisaUser.ToolTipText = "Pesquisar";
            this.tsbPesquisaUser.Click += new System.EventHandler(this.TsbPesquisaUser_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnExcluiLab);
            this.groupBox2.Controls.Add(this.cbExcluirUser);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(14, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 82);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Excluir Usuario";
            // 
            // btnExcluiLab
            // 
            this.btnExcluiLab.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnExcluiLab.Location = new System.Drawing.Point(182, 40);
            this.btnExcluiLab.Name = "btnExcluiLab";
            this.btnExcluiLab.Size = new System.Drawing.Size(82, 23);
            this.btnExcluiLab.TabIndex = 1;
            this.btnExcluiLab.Text = "Excluir";
            this.btnExcluiLab.UseVisualStyleBackColor = true;
            this.btnExcluiLab.Click += new System.EventHandler(this.BtnExcluiLab_Click);
            // 
            // cbExcluirUser
            // 
            this.cbExcluirUser.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cbExcluirUser.FormattingEnabled = true;
            this.cbExcluirUser.Location = new System.Drawing.Point(9, 42);
            this.cbExcluirUser.Name = "cbExcluirUser";
            this.cbExcluirUser.Size = new System.Drawing.Size(163, 21);
            this.cbExcluirUser.Sorted = true;
            this.cbExcluirUser.TabIndex = 0;
            this.cbExcluirUser.Text = "[Selecione]";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbTipoUsuario);
            this.groupBox1.Controls.Add(this.cbUsuarios);
            this.groupBox1.Controls.Add(this.txtConfirmaSenha);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtNovoUsername);
            this.groupBox1.Controls.Add(this.txtNovaSenha);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(14, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 186);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atualizar Usuarios";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAtualizar.Location = new System.Drawing.Point(147, 157);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(139, 23);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Confirmar Alterações";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tipo do Usuario";
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Padrão"});
            this.cbTipoUsuario.Location = new System.Drawing.Point(147, 33);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(138, 21);
            this.cbTipoUsuario.TabIndex = 5;
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(7, 33);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(116, 21);
            this.cbUsuarios.TabIndex = 4;
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtConfirmaSenha.Location = new System.Drawing.Point(147, 107);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.Size = new System.Drawing.Size(139, 21);
            this.txtConfirmaSenha.TabIndex = 3;
            this.txtConfirmaSenha.Text = "Confirmar nova senha";
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtEmail.Location = new System.Drawing.Point(7, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(116, 21);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Text = "Email@gmail.com";
            // 
            // txtNovoUsername
            // 
            this.txtNovoUsername.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtNovoUsername.Location = new System.Drawing.Point(7, 68);
            this.txtNovoUsername.Name = "txtNovoUsername";
            this.txtNovoUsername.Size = new System.Drawing.Size(116, 21);
            this.txtNovoUsername.TabIndex = 1;
            this.txtNovoUsername.Text = "Novo username";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtNovaSenha.Location = new System.Drawing.Point(7, 108);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(116, 21);
            this.txtNovaSenha.TabIndex = 0;
            this.txtNovaSenha.Text = "Nova Senha";
            // 
            // GridUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(943, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDados);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GridUsuarios";
            this.Text = "GridUsuarios";
            this.Load += new System.EventHandler(this.GridUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cbOrdena;
        private System.Windows.Forms.ToolStripTextBox tsbPesquisar;
        private System.Windows.Forms.ToolStripButton tsbOrdena;
        private System.Windows.Forms.ToolStripButton tsbPesquisaUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExcluiLab;
        private System.Windows.Forms.ComboBox cbExcluirUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNovoUsername;
        private System.Windows.Forms.TextBox txtNovaSenha;
    }
}