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
        Operações MinhasOperações = new Operações(); // Instanciando a classe operações, pois aqui dentro eu preciso chama-la (para validar o usuario, clique na classe operações para entender melhor)
        public Form1()
        {
            InitializeComponent();

           
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e) // TextChanged é algo que vai fazer quando houver alteração no TextBox
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text)) //condição que verifica se os dois TextBox estão preenchidos
            {
                btnLogin.Enabled = true; // se estiverem preenchidos, o botão de login fica ativo
            }
            else
            {
                btnLogin.Enabled = false; // se somente um estiver preenchido, o botão fica inacessível.
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text)) //mesma coisa acima
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }

            if (!string.IsNullOrEmpty(txtPassword.Text)) //condição para verificar se o campo de senha está preenchido
            {
                txtPassword.UseSystemPasswordChar = true; // sendo assim sua propriedade muda, em vez de aparecer a senha, vai aparecer caracter de password
            }
            else
            {
                btnLogin.Enabled = false; // se não estiver preenchido, nada acontece
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e) // evento de click do botão de login
        {
            int cont = 0;

            string usuario;
            string senha;


            DialogResult resp = new DialogResult(); // vai capturar a resposta do usuário  em determinado MessageBox

            string TextoMsg = "Bemv - Vindo ao RML"; //As 3 linhas abaixo são textos que serão usados no MessageBox
            string TituloMsg = "Acesso Concedido";
            string TituloMsg2 = "Acesso Negado";

            MessageBoxButtons BotaoMsg = MessageBoxButtons.RetryCancel; //Definindo qual tipo de botão vai aparecer quando exibir o MessageBox (No caso, vai ser RETRY e CANCEL)
            MessageBoxIcon IconeMsg = MessageBoxIcon.Exclamation; //Definindo qual ícone vai aparecer no MessageBox



            usuario = txtUsername.Text; //recebendo o que o usuario digitou no campo
            senha = txtPassword.Text;


            /*Abaixo está chamando um método da classe Operações que terá um valor de retorno TRUE or FALSE
             * E também está passando como parâmetro o usuario e a senha que preciso validar no XML */
            bool verifica = MinhasOperações.ValidaUsuario(usuario, senha);

            if (verifica == true)
            {
                //abaixo é o trecho de código que chama a segunda tela, pois o usuário está correto
                MessageBox.Show(TextoMsg, TituloMsg);
                MenuOpção x = new MenuOpção(this,usuario);

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
    }
}
