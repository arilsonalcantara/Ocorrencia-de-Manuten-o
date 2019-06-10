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
        Laboratório l = new Laboratório();

        Usuarios u = new Usuarios();

        Ocorrencia o = new Ocorrencia();

        Operações MinhasOperações = new Operações();

        Dados d = new Dados();

        MenuOpção GridView;

        string verificatipo;
        public GridOcorrencia(MenuOpção x, string tipo)
        {
            InitializeComponent();

            GridView = x;

            verificatipo = tipo;
        }

        private void GridOcorrencia_Load(object sender, EventArgs e)
        {
            cbLaboratorio.Items.Clear();
            foreach (Laboratório lab in l.ListarPredios())
            {
                cbLaboratorio.Items.Add(lab);
            }

            cbUsuario.Items.Clear();
            foreach (Usuarios user in u.ListarUsuarios())
            {
                cbUsuario.Items.Add(user).ToString();
            }

            if (verificatipo == "Administrador")
            {
                cbStatus.Enabled = true;
            }

            CarregaGrid();
        }

        private void CarregaGrid()
        {
            dgvDados.DataSource = null;
            dgvDados.DataSource = d.ListaOcorrencia();
            dgvDados.ClearSelection();
        }


        private void CarregaGridOrdenado(string i)
        {
            dgvDados.DataSource = null;
            dgvDados.DataSource = d.ListaOcorrenciaOrdenada(i);

            dgvDados.ClearSelection();
        }


        private void TsbSalvar_Click(object sender, EventArgs e)
        {
            string TextoMsg = "Ocorrência cadastrada com sucesso";
            string TituloMsg = "Acesso Concedido";
            string TituloMsg2 = "Acesso Negado";

            MessageBoxButtons BotaoMsg = MessageBoxButtons.RetryCancel;
            MessageBoxIcon IconeMsg = MessageBoxIcon.Exclamation;



            string descriçao = txtDescricao.Text;
            string Prioridade = cbPrioridade.Text;
            string Status = cbStatus.Text;
            string DataUpdate = dtpAtualizado.Text;
            string DateInicio = dtpAbertura.Text;
            int Laboratorio = int.Parse(cbLaboratorio.Text);
            string Usuario = cbUsuario.Text;


            bool retorno = MinhasOperações.InserirOcorrencia(descriçao, Prioridade, Status, DataUpdate, DateInicio, Laboratorio, Usuario);


            l.RegistraOcorrencia(Laboratorio);

            if (retorno == true)
            {

                MessageBox.Show(TextoMsg, TituloMsg);

                txtDescricao.Clear();
                cbPrioridade.SelectedIndex = -1;
                cbStatus.SelectedIndex = -1;
                cbLaboratorio.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Não foi possível cadastrar sua ocorrencia", TituloMsg2, BotaoMsg, IconeMsg); // MessageBox que será exibido com o texto, botão e ícone que está declarado acima


                txtDescricao.Clear();
                cbPrioridade.Items.Clear();
                cbStatus.Items.Clear();
                cbLaboratorio.Items.Clear();


            }

            CarregaGrid();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            

            int id = int.Parse(txtIdSetup.Text);
            string opc = cbSelecione.Text;

            if (cbSelecione.Text.Equals("Excluir"))
            {
                d.ExcluirOcorrencia(id);
                l.RemoveOcorrencia(id);
                CarregaGrid();
            }
            else if (cbSelecione.Text.Equals("Editar"))
            {
                string descriçao = txtDescricao.Text;
                string Prioridade = cbPrioridade.Text;
                string Status = cbStatus.Text;
                string DataUpdate = dtpAtualizado.Text;
                string DateInicio = dtpAbertura.Text;
                int Laboratorio = int.Parse(cbLaboratorio.Text);
                string Usuario = cbUsuario.Text;



                MinhasOperações.EditarOcorrencias(id, descriçao, Prioridade, Status, DataUpdate, DateInicio, Laboratorio, Usuario);
                CarregaGrid();
            }

        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            string ordena = cbOrdena.Text;

            if (ordena == "Prioridade")
            {
               
                CarregaGridOrdenado(ordena);
            }
            else if(ordena == "DatadeAbertura")
            {
                CarregaGridOrdenado(ordena);
            }
            else if (ordena == "Status")
            {
                CarregaGridOrdenado(ordena);
            }

            else if (ordena == "Laboratorio")
            {
                CarregaGridOrdenado(ordena);
            }

            else if (ordena == "ID")
            {
                CarregaGridOrdenado(ordena);
            }

        }

        private void DgvDados_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void TsbPesquisar_Click(object sender, EventArgs e)
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
        }
    }
}
