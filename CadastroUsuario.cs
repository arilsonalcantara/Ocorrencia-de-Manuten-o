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
    public partial class CadastroUsuario : Form
    {
        Operações MinhasOperações = new Operações();

        Form1 ChamadaDeTela;
        public CadastroUsuario(Form1 Chamada)
        {
            InitializeComponent();

            ChamadaDeTela = Chamada;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            string TextoMsg = "Usuário cadastrado com sucesso";
            string TituloMsg = "Acesso Concedido";
            string TituloMsg2 = "Acesso Negado";

            MessageBoxButtons BotaoMsg = MessageBoxButtons.RetryCancel;
            MessageBoxIcon IconeMsg = MessageBoxIcon.Exclamation;


            string nomeusuario = textNome.Text;
            string email = textEmail.Text;
            string senha = textSenha.Text;
            string confirmasenha = textConfirmarSenha.Text;
            string tipo = cbTipoUsuario.Text;

            bool retorno = MinhasOperações.InserirUsuario(nomeusuario, email, senha, tipo);

            if (retorno == true)
            {

                MessageBox.Show(TextoMsg, TituloMsg);
                
                Form1 x = new Form1();

                x.Show();


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
            if (e.KeyChar == (char)Keys.Enter)
            {
                textSenha.Focus();
            }
        }

        private void TextSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textConfirmarSenha.Focus();
            }
        }

        private void TextConfirmarSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
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
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnCadastrar.Focus();
            }
        }


    }
}
