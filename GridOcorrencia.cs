using System;
using System.Collections;
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
    public partial class GridOcorrencia : Form
    {
        private List<Ocorrencia> CadOcorrencias = new List<Ocorrencia>();

        Operações MinhasOperações = new Operações();

        MenuOpção GridView;

        public GridOcorrencia(MenuOpção x)
        {
            InitializeComponent();

            GridView = x;
        }

        private void GridOcorrencia_Load(object sender, EventArgs e)
        {
            MinhasOperações.CarregaGrid(dgvDados);
        }


    }
}
