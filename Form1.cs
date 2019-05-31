using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ocorrencia_de_Manutenção
{
    public partial class Form1 : Form
    {
        Operações MinhasOperações = new Operações();
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
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DialogResult resp = new DialogResult();

            string TextoMsg = "Bemv - Vindo ao RML";
            string TituloMsg = "Acesso Concedido";
            string TituloMsg2 = "Acesso Negado";

            MessageBoxButtons BotaoMsg = MessageBoxButtons.RetryCancel;
            MessageBoxIcon IconeMsg = MessageBoxIcon.Exclamation;

            do
            {

                string usuario = txtUsername.Text;
                string senha = txtPassword.Text;

                bool verifica = MinhasOperações.ValidaUsuario(usuario, senha);

                if (verifica == true)
                {

                    MessageBox.Show(TextoMsg, TituloMsg);
                    MenuOpção x = new MenuOpção(this);

                     x.Show();
                }
                else
                {
                    MessageBox.Show("Usuario não cadastrado", TituloMsg2, BotaoMsg, IconeMsg);

                    txtUsername.Text = "";
                    txtPassword.Text = "";

                }
            } while (resp != DialogResult.Retry);

            
        }
    }
}
