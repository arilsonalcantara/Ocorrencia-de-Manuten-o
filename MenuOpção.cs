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
    public partial class MenuOpção : Form
    {
        Form1 PainelLogin; // aqui estou criando um objeto para poder enviar da Tela 1 (Painel de Login) para a Tela 2 (MenuOpção)
        public MenuOpção(Form1 F,string user) // Este metódo está recebendo um paramêtro do tipo Form1 (que é a primeira tel)
        {
            InitializeComponent();

            PainelLogin = F; //Aqui é basicamente o recebimento da chamada da tela
            lblUser.Text = user; //Para mostrar o usuario que está usando

        }

        private void Label1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CadastroLaboratório x = new CadastroLaboratório(this);

            x.Show();
        }
    }
}
