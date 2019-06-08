using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ocorrencia_de_Manutenção
{
    public partial class CadastroUsuario : Form
    {
        Operações MinhasOperações = new Operações();


        Usuarios u = new Usuarios();

        Form1 ChamadaDeTela;
        public CadastroUsuario(Form1 Chamada)
        {
            InitializeComponent();

            ChamadaDeTela = Chamada;

            txtCodUsu.Text = u.Codigo.ToString();

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            string TextoMsg = "Usuário cadastrado com sucesso";
            string TituloMsg = "Acesso Concedido";
            string TituloMsg2 = "Acesso Negado";

            MessageBoxButtons BotaoMsg = MessageBoxButtons.RetryCancel;
            MessageBoxIcon IconeMsg = MessageBoxIcon.Exclamation;

            int codigo = int.Parse(txtCodUsu.Text);
            string nomeusuario = textNome.Text;
            string email = textEmail.Text;
            string senha = textSenha.Text;
            string confirmasenha = textConfirmarSenha.Text;
            string tipo = cbTipoUsuario.Text;

            bool retorno = MinhasOperações.InserirUsuario(codigo, nomeusuario, email, senha, tipo);

            if (retorno == true)
            {

                MinhasOperações.EnviaEmail(email, nomeusuario, senha);

                MessageBox.Show(TextoMsg, TituloMsg);

                this.Close();

            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar seu usuário, escolha outro nome", TituloMsg2, BotaoMsg, IconeMsg); // MessageBox que será exibido com o texto, botão e ícone que está declarado acima


                textNome.Clear();
                textEmail.Clear();
                textSenha.Clear();
                textConfirmarSenha.Clear();


            }


        }

        private void TextNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textEmail.Focus();
            }
        }

        private void TextEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                textSenha.Focus();
            }
        }

        private void TextSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                textConfirmarSenha.Focus();
            }
        }

        private void TextConfirmarSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {

                if (textSenha.Text.Equals(textConfirmarSenha.Text))
                {
                    cbTipoUsuario.Focus();
                }
                else
                {
                    string TxtErro = "As senhas não conferem, digite novamente";
                    string TituloMsg = "Senha inválida";

                    MessageBoxButtons BotaoMsg = MessageBoxButtons.RetryCancel;
                    MessageBoxIcon IconeMsg = MessageBoxIcon.Exclamation;

                    MessageBox.Show(TxtErro, TituloMsg, BotaoMsg, IconeMsg);

                    textSenha.Clear();
                    textConfirmarSenha.Clear();

                }

            }
        }

        private void CbTipoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                btnCadastrar.Focus();
                btnCadastrar.PerformClick();
            }
        }

        private void TxtCodUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;

            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void TextSenha_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textSenha.Text))
            {
                textSenha.UseSystemPasswordChar = true;
            }
        }

        private void TextConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textConfirmarSenha.Text))
            {
                textConfirmarSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
