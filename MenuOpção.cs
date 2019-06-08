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

        string verificatipo;

        public MenuOpção(Form1 F,string user, string tipo) 
        {
            InitializeComponent();

            PainelLogin = F;

            label1.Text += user.ToString();

            verificatipo = tipo;
        }

        private void Label1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            CadastroLaboratório x = new CadastroLaboratório(this);

            x.Show();
        }

        private void MenuOpção_Load(object sender, EventArgs e)
        {
            if (verificatipo == "Padrão")
            {
                btnVisualizaOcorrencias.Location = new Point(117, 98);
            }
            else
            {
                btnLaboratoriosSistemas.Visible = true;
                btnUsuariosSistemas.Visible = true;
                button2.Visible = true;
            }
        }

        private void BtnVisualizaOcorrencias_Click(object sender, EventArgs e)
        {
            GridOcorrencia x = new GridOcorrencia(this);

            x.Show();
        }
    }
}
