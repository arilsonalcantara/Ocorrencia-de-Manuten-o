namespace Ocorrencia_de_Manutenção
{
    partial class CadastroUsuario
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
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textConfirmarSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(123, 32);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(152, 20);
            this.textNome.TabIndex = 0;
            this.textNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextNome_KeyPress);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(123, 77);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(152, 20);
            this.textEmail.TabIndex = 1;
            this.textEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextEmail_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(123, 126);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(152, 20);
            this.textSenha.TabIndex = 5;
            this.textSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSenha_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirmar Senha";
            // 
            // textConfirmarSenha
            // 
            this.textConfirmarSenha.Location = new System.Drawing.Point(123, 169);
            this.textConfirmarSenha.Name = "textConfirmarSenha";
            this.textConfirmarSenha.Size = new System.Drawing.Size(152, 20);
            this.textConfirmarSenha.TabIndex = 7;
            this.textConfirmarSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextConfirmarSenha_KeyPress);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCadastrar.Location = new System.Drawing.Point(230, 233);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(104, 29);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // cbTipoUsuario
            // 
            this.cbTipoUsuario.FormattingEnabled = true;
            this.cbTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Usuário Padrão"});
            this.cbTipoUsuario.Location = new System.Drawing.Point(384, 168);
            this.cbTipoUsuario.Name = "cbTipoUsuario";
            this.cbTipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.cbTipoUsuario.TabIndex = 9;
            this.cbTipoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbTipoUsuario_KeyPress);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(381, 142);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(96, 13);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo do Usuário";
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 319);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cbTipoUsuario);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.textConfirmarSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNome);
            this.Name = "CadastroUsuario";
            this.Text = "CadastroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textConfirmarSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cbTipoUsuario;
        private System.Windows.Forms.Label lblTipo;
    }
}