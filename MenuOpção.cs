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
        Form1 PainelLogin; 
        public MenuOpção(Form1 F,string user) 
        {
            InitializeComponent();

            PainelLogin = F; 
            lblUser.Text = user; 

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
