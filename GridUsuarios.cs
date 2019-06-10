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
    public partial class GridUsuarios : Form
    {
        Laboratório l = new Laboratório();

        Usuarios u = new Usuarios();

        Operações MinhasOperações = new Operações();

        Dados d = new Dados();

        MenuOpção usertela;
        public GridUsuarios(MenuOpção x)
        {
            InitializeComponent();

            usertela = x;
        }

        private void GridUsuarios_Load(object sender, EventArgs e)
        {
            cbUsuarios.Items.Clear();
            foreach (Usuarios usuarios in u.ListarUsuarios())
            {
                cbUsuarios.Items.Add(usuarios);
            }
            cbExcluirUser.Items.Clear();
            foreach (Usuarios usuarios in u.ListarUsuarios())
            {
                cbExcluirUser.Items.Add(usuarios);
            }

            CarregaGrid();
        }

        private void CarregaGrid()
        {
            dgvDados.DataSource = null;
            dgvDados.DataSource = d.ListaUsuarios();
            dgvDados.ClearSelection();
        }

        private void CarregaGridOrdenado(string a)
        {
            dgvDados.DataSource = null;
            dgvDados.DataSource = d.ListaUsuariosOrdenado(a);
            dgvDados.ClearSelection();
        }

        private void TsbOrdena_Click(object sender, EventArgs e)
        {
            string ordena = cbOrdena.Text;

            if (ordena == "Codigo")
            {

                CarregaGridOrdenado(ordena);
            }
            else if (ordena == "Username")
            {
                CarregaGridOrdenado(ordena);
            }
            else if (ordena == "Tipo")
            {
                CarregaGridOrdenado(ordena);
            }

            
        }

        private void TsbPesquisaUser_Click(object sender, EventArgs e)
        {
            string Nome = tsbPesquisar.Text;

            tsbPesquisar.Text = "";

            dgvDados.ClearSelection();

            for (int i = 0; i < dgvDados.RowCount; i++)
            {
                if (dgvDados.Rows[i].Cells[0].Value.ToString() == Nome)
                {
                    dgvDados.CurrentCell = dgvDados.Rows[i].Cells[0];
                }
            }
        }

        private void BtnExcluiLab_Click(object sender, EventArgs e)
        {
            string user = cbExcluirUser.Text;

            d.ExcluirUsuario(user);

            CarregaGrid();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            string novoUsername;
            string novaSenha;
            string novoEmail;
            string novoTipo;
            if (txtNovoUsername.Text.Equals("Novo username"))
            {
               novoUsername = cbUsuarios.Text;
            }
            else
            {
                novoUsername = txtNovoUsername.Text;
            }

            if(txtNovaSenha.Text.Equals("Nova Senha"))
            {
                 novaSenha = "";
            }
            else
            {
                 novaSenha = txtNovaSenha.Text;
            }

            if (txtEmail.Text.Equals("Email@gmail.com"))
            {
                 novoEmail = "";
            }
            else
            {
                 novoEmail = txtEmail.Text;
            }

            if (cbTipoUsuario.Text.Equals(""))
            {
                novoTipo = u.Tipo;
            }
            else
            {
                novoTipo = cbTipoUsuario.Text;
            }
            MinhasOperações.EditarUsuario(novoUsername,novoEmail,novaSenha,novoTipo);

            

            CarregaGrid();
        }
    }
}
