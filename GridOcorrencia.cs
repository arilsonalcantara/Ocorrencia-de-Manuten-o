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

        Laboratório l = new Laboratório();

        Usuarios u = new Usuarios();

        Operações MinhasOperações = new Operações();

        Dados d = new Dados();

        MenuOpção GridView;

        public GridOcorrencia(MenuOpção x)
        {
            InitializeComponent();

            GridView = x;
        }

        private void GridOcorrencia_Load(object sender, EventArgs e)
        {
            cbPredio.Items.Clear();
            foreach (Laboratório predio in l.ListarPredios())
            {
                cbPredio.Items.Add(predio).ToString();
            }

            cbUsuario.Items.Clear();
            foreach (Usuarios user in u.ListarUsuarios())
            {
                cbUsuario.Items.Add(user).ToString();
            }

            CarregaGrid();
        }

        private void CarregaGrid()
        {
            dgvDados.DataSource = null; 
            dgvDados.DataSource = d.ListaOcorrencia();

            dgvDados.ClearSelection();
        }

        private void TsbSalvar_Click(object sender, EventArgs e)
        {
            Ocorrencia x = new Ocorrencia();

            x.ID = x.ID;
            x.Descriçao = txtDescricao.Text;
            x.Prioridade = cbPrioridade.Text;
            x.Status = cbStatus.Text;
            x.DataUpdate = "";
            x.DateInicio = dtpAbertura.Text;
            x.Predio = cbPredio.Text;
            x.Laboratorio = int.Parse(cbLaboratorio.Text);
            x.Usuario = cbUsuario.Text;

            CadOcorrencias.Add(x);
            MinhasOperações.InserirOcorrencia(x);

            CarregaGrid();

            dgvDados.CurrentCell = dgvDados.Rows[dgvDados.RowCount - 1].Cells[0];
        }

        private void CbPredio_TextChanged(object sender, EventArgs e)
        {
            cbLaboratorio.Items.Clear();
            foreach (Laboratório lab in l.ListarLab(cbPredio.Text))
            {
                cbLaboratorio.Items.Add(lab).ToString();
            }

        }
    }
}
