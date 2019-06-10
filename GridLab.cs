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
    public partial class GridLab : Form
    {
        Laboratório l = new Laboratório();

        Usuarios u = new Usuarios();

        Operações MinhasOperações = new Operações();

        Dados d = new Dados();

        MenuOpção tela;
        public GridLab(MenuOpção Lab)
        {
            InitializeComponent();

            tela = Lab;
        }

        private void GridLab_Load(object sender, EventArgs e)
        {
            cbExcluirLab.Items.Clear();
            foreach (Laboratório lab in l.ListarPredios())
            {
                cbExcluirLab.Items.Add(lab);
            }

            cbAlterarAdmLab.Items.Clear();
            foreach (Laboratório lab in l.ListarPredios())
            {
                cbAlterarAdmLab.Items.Add(lab);
            }

            cbAlteraAdm.Items.Clear();
            foreach (Usuarios user in u.ListarUsuarios())
            {
                cbAlteraAdm.Items.Add(user).ToString();
            }

            CarregaGrid();
        }

        private void CarregaGrid()
        {
            dgvDados.DataSource = null;
            dgvDados.DataSource = d.ListaLaboratorios();
            dgvDados.ClearSelection();
        }

        private void CarregaGridOrdenado(string a)
        {
            dgvDados.DataSource = null;
            dgvDados.DataSource = d.ListaLaboratorioordenado(a);
            dgvDados.ClearSelection();
        }

        private void TsbOrdena_Click(object sender, EventArgs e)
        {
            string ordena = cbOrdena.Text;

            if (ordena == "Codigo")
            {

                CarregaGridOrdenado(ordena);
            }
            else if (ordena == "Administrador")
            {
                CarregaGridOrdenado(ordena);
            }
            else if (ordena == "CodAdm")
            {
                CarregaGridOrdenado(ordena);
            }

            else if (ordena == "Ocorrencias")
            {
                CarregaGridOrdenado(ordena);
            }

            cbOrdena.Text ="Ordenar por...";
            cbExcluirLab.Text="[Selecione]";
            cbAlteraAdm.Text="[Selecione]";
            cbAlterarAdmLab.Text="Laboratorio";
            txtPesquisar.Text = "";

        }

        private void TsbPesquisaLab_Click(object sender, EventArgs e)
        {
            string Nome = txtPesquisar.Text;

            txtPesquisar.Text = "";

            dgvDados.ClearSelection();

            for (int i = 0; i < dgvDados.RowCount; i++)
            {
                if (dgvDados.Rows[i].Cells[0].Value.ToString() == Nome)
                {
                    dgvDados.CurrentCell = dgvDados.Rows[i].Cells[0];
                }
            }

            cbOrdena.Text = "Ordenar por...";
            cbExcluirLab.Text = "[Selecione]";
            cbAlteraAdm.Text = "[Selecione]";
            cbAlterarAdmLab.Text = "Laboratorio";
            txtPesquisar.Text = "";
        }

        private void BtnExcluiLab_Click(object sender, EventArgs e)
        {
           
            int id = int.Parse(cbExcluirLab.Text);

             d.ExcluirLaboratorio(id);

            cbOrdena.Text = "Ordenar por...";
            cbExcluirLab.Text = "[Selecione]";
            cbAlteraAdm.Text = "[Selecione]";
            cbAlterarAdmLab.Text = "Laboratorio";
            txtPesquisar.Text = "";

            CarregaGrid();
            
        }

        private void BtnAlteraAdm_Click(object sender, EventArgs e)
        {
            string novoAdm = cbAlteraAdm.Text;
            int id = int.Parse(cbAlterarAdmLab.Text);
            int novoCodAdm = MinhasOperações.PesquisaCodigoAdm(novoAdm);


            MinhasOperações.EditarLaboratorio(id, novoAdm, novoCodAdm);

            cbOrdena.Text = "Ordenar por...";
            cbExcluirLab.Text = "[Selecione]";
            cbAlteraAdm.Text = "[Selecione]";
            cbAlterarAdmLab.Text = "Laboratorio";
            txtPesquisar.Text = "";

            CarregaGrid();
        }
    }
}
