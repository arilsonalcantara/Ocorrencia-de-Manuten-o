﻿using System.Windows.Forms;

namespace Ocorrencia_de_Manutenção
{
    partial class CadastroLaboratório
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
            this.txtAdm = new System.Windows.Forms.TextBox();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrédio = new System.Windows.Forms.Label();
            this.txtPrédio = new System.Windows.Forms.TextBox();
            this.btnSalvarUsuario = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodLab = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAdm
            // 
            this.txtAdm.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdm.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtAdm.Location = new System.Drawing.Point(187, 70);
            this.txtAdm.Name = "txtAdm";
            this.txtAdm.Size = new System.Drawing.Size(114, 20);
            this.txtAdm.TabIndex = 0;
            this.txtAdm.Text = "Administrador";
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.Location = new System.Drawing.Point(26, 70);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(91, 14);
            this.lblAdministrador.TabIndex = 2;
            this.lblAdministrador.Text = "Admnistrador";
            // 
            // txtStatus
            // 
            this.txtStatus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtStatus.Location = new System.Drawing.Point(187, 116);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(114, 20);
            this.txtStatus.TabIndex = 5;
            this.txtStatus.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status";
            // 
            // lblPrédio
            // 
            this.lblPrédio.AutoSize = true;
            this.lblPrédio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrédio.Location = new System.Drawing.Point(28, 176);
            this.lblPrédio.Name = "lblPrédio";
            this.lblPrédio.Size = new System.Drawing.Size(43, 15);
            this.lblPrédio.TabIndex = 8;
            this.lblPrédio.Text = "Prédio";
            // 
            // txtPrédio
            // 
            this.txtPrédio.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPrédio.Location = new System.Drawing.Point(187, 176);
            this.txtPrédio.Name = "txtPrédio";
            this.txtPrédio.Size = new System.Drawing.Size(114, 20);
            this.txtPrédio.TabIndex = 9;
            this.txtPrédio.Text = "  Prédio";
            // 
            // btnSalvarUsuario
            // 
            this.btnSalvarUsuario.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarUsuario.Location = new System.Drawing.Point(245, 261);
            this.btnSalvarUsuario.Name = "btnSalvarUsuario";
            this.btnSalvarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarUsuario.TabIndex = 10;
            this.btnSalvarUsuario.Text = "Salvar";
            this.btnSalvarUsuario.UseVisualStyleBackColor = true;
            this.btnSalvarUsuario.Click += new System.EventHandler(this.BtnSalvarUsuario_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(361, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(33, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Laboratório";
            // 
            // txtCodLab
            // 
            this.txtCodLab.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodLab.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCodLab.Location = new System.Drawing.Point(268, 20);
            this.txtCodLab.Name = "txtCodLab";
            this.txtCodLab.Size = new System.Drawing.Size(33, 20);
            this.txtCodLab.TabIndex = 14;
            // 
            // CadastroLaboratório
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 336);
            this.Controls.Add(this.txtCodLab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSalvarUsuario);
            this.Controls.Add(this.txtPrédio);
            this.Controls.Add(this.lblPrédio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblAdministrador);
            this.Controls.Add(this.txtAdm);
            this.Enabled = false;
            this.Name = "CadastroLaboratório";
            this.Text = "CadastroLaboratório";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdm;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrédio;
        private System.Windows.Forms.TextBox txtPrédio;
        private Button btnSalvarUsuario;
        private TextBox textBox1;
        private Label label1;
        private Label label4;
        private TextBox txtCodLab;
    }
}