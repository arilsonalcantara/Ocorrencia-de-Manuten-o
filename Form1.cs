using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Ocorrencia_de_Manutenção
{
    public partial class Form1 : Form
    {
        Operações MinhasOperações = new Operações();

        Usuarios u = new Usuarios();

        public Form1()
        {
            InitializeComponent();

        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }

            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string usuario;
            string senha;



            string TextoMsg = "Bemv - Vindo ao GOL";
            string TituloMsg = "Acesso Concedido";
            string TituloMsg2 = "Acesso Negado";

            MessageBoxButtons BotaoMsg = MessageBoxButtons.RetryCancel;
            MessageBoxIcon IconeMsg = MessageBoxIcon.Exclamation;



            usuario = txtUsername.Text;
            senha = txtPassword.Text;



            bool verifica = MinhasOperações.ValidaLogin(usuario,senha);

            if (verifica == true)
            {

                MessageBox.Show(TextoMsg, TituloMsg);

                string tipo = MinhasOperações.VerificaTipo(usuario);

                MenuOpção x = new MenuOpção(this, usuario, tipo);

                x.Show();


            }
            else
            {
                MessageBox.Show("Usuario não cadastrado", TituloMsg2, BotaoMsg, IconeMsg); // MessageBox que será exibido com o texto, botão e ícone que está declarado acima


                txtUsername.Clear();
                txtPassword.Clear();

            }




        }

        private void TxtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.Focus();
                btnLogin.PerformClick();
            }
        }

        private void btnCadastre_Click(object sender, EventArgs e)
        {

        }

        private void Form1_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void BtnCadastre_MouseEnter(object sender, EventArgs e)
        {
            btnCadastre.ForeColor = Color.White;
        }

        private void BtnCadastre_MouseLeave(object sender, EventArgs e)
        {
            btnCadastre.ForeColor = SystemColors.ControlDarkDark;
        }

        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = SystemColors.ControlDarkDark;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastre_Click_1(object sender, EventArgs e)
        {
            CadastroUsuario x = new CadastroUsuario(this);

            x.Show();
        }
    }
}
