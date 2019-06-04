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
        Operações MOperações = new Operações();

        MenuOpção OpçãoCadastro;
        public CadastroLaboratório(MenuOpção opc)
        {
            InitializeComponent();
            OpçãoCadastro = opc;
        }

        private void BtnSalvarUsuario_Click(object sender, EventArgs e)
        {
            /*DialogResult Resp = new DialogResult();

            string Adm; //Para capturar o que o usuário digitou.
            string Status;
            string Prédio;

            Adm = txtAdm.Text; //Recebe o que o usuário digitou.
            Status = txtStatus.Text;
            Prédio = txtPrédio.Text;

            string TextoMsg = "Cadastro Efetuado com Sucesso!";
            string TítuloMsg = "Aviso do Sistema";
            string TituloMsg2 = "Cadastro Negado";
            MessageBoxButtons BotãoMsg = MessageBoxButtons.OK;
            MessageBoxIcon ÍconeMsg = MessageBoxIcon.Information;
            MessageBoxButtons BotaoMsg2 = MessageBoxButtons.RetryCancel;
            MessageBoxIcon IconeMsg2 = MessageBoxIcon.Exclamation;


            bool Retorno = MOperações.InserirLaboratório(Adm, Status, Prédio);

            if (Retorno == true)
            {
                Resp = MessageBox.Show(TextoMsg, TítuloMsg, BotãoMsg, ÍconeMsg);



                if (Resp == DialogResult.OK)
                {
                    Application.Exit();
                }
            }

            else
            {
                MessageBox.Show("Cadastro não realizado.Tente Novamente", TituloMsg2, BotaoMsg2, IconeMsg2); // MessageBox que será exibido com o texto, botão e ícone que está declarado acima

         
            }*/
        }
    }
}
