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
    public partial class CadastroLaboratório : Form
    {
        Operações MinhasOperações = new Operações();
        Laboratório l = new Laboratório();

        MenuOpção OpçãoCadastro;
        public CadastroLaboratório(MenuOpção opc)
        {
            InitializeComponent();
            OpçãoCadastro = opc;
            txtCodLab.Text = l.CodigoLab.ToString();
        }

        private void BtnSalvarUsuario_Click(object sender, EventArgs e)
        {
            string TextoMsg = "Laboratório cadastrado com sucesso";
            string TituloMsg = "Acesso Concedido";
            string TituloMsg2 = "Acesso Negado";

            MessageBoxButtons BotaoMsg = MessageBoxButtons.RetryCancel;
            MessageBoxIcon IconeMsg = MessageBoxIcon.Exclamation;

            int codigo = int.Parse(txtCodLab.Text);
            string adm = txtAdm.Text;
            string status = txtStatus.Text;
            int predio = int.Parse(txtPrédio.Text);
            

            //bool retorno = MinhasOperações.InserirUsuario(codigo, nomeusuario, email, senha, tipo);

            //if (retorno == true)
            //{

            //    MessageBox.Show(TextoMsg, TituloMsg);

            //    this.Close();

            //}
            //else
            //{
            //    MessageBox.Show("Não foi possível cadastrar seu usuário, escolha outro nome", TituloMsg2, BotaoMsg, IconeMsg); // MessageBox que será exibido com o texto, botão e ícone que está declarado acima


            //    textNome.Clear();
            //    textEmail.Clear();
            //    textSenha.Clear();
            //    textConfirmarSenha.Clear();


            //}
        }
    }
}
