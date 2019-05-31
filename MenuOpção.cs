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
        public MenuOpção(Form1 F)
        {
            InitializeComponent();

            PainelLogin = F;
        }

        private void Label1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
