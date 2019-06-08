using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ocorrencia_de_Manutenção
{
    public class Operações
    {
        GridOcorrencia MeuGrid;

        private Dados MeusDados;

        public Operações()
        {
            MeusDados = new Dados(); 
        }

        public bool InserirUsuario(int codigo,string nome, string email, string senha, string tipo)
        {
            bool gravação = false;
            bool verifica = true;

            Usuarios NovoUsuario;

            verifica = ValidaUsuario(nome,codigo);

            if(verifica == false)
            {
                NovoUsuario = new Usuarios();

                NovoUsuario.Codigo = codigo;
                NovoUsuario.Username = nome;
                NovoUsuario.Email = email;
                NovoUsuario.Password = senha;
                NovoUsuario.Tipo = tipo;


                MeusDados.Inserir(NovoUsuario);
                MeusDados.GravarUsuarios(NovoUsuario);

                gravação = true;

            }

            return gravação;

        }

        public bool ValidaUsuario(string usuario, int codigo)
        {
            bool verifica = MeusDados.ValidaUsuarios(usuario,codigo); 

            return verifica; 
        }

        public bool ValidaLogin(string usuario, string senha)
        {
            bool verifica = MeusDados.ValidaLogin(usuario,senha);

            return verifica;
        }

        public int PesquisaCodigoAdm(string adm)
        {
            int codadm;

            codadm = MeusDados.PesquisaCodigoAdm(adm);

            return codadm;

        }

        public void EnviaEmail(string email, string nomeusuario, string senha)
        {
            MeusDados.EnviaEmail(email,nomeusuario,senha);
        }
       public string VerificaTipo(string user)
        {
           string tipo = MeusDados.VerificaTipo(user);

            return tipo;
        }

        public void CarregaGrid(DataGridView dgvDados)
        {

            dgvDados.ColumnCount = 8;

            dgvDados.Columns[0].Name = "Id";
            dgvDados.Columns[1].Name = "Descrição";
            dgvDados.Columns[2].Name = "Prioridade";
            dgvDados.Columns[3].Name = "Status";
            dgvDados.Columns[4].Name = "Última Modificação";
            dgvDados.Columns[5].Name = "Data de Abertura";
            dgvDados.Columns[6].Name = "Laboratório";
            dgvDados.Columns[7].Name = "Usuário";


        }

    }
}
