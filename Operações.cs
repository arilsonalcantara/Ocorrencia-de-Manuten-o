using System;
using System.Collections.Generic;
using System.IO;
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


                MeusDados.InserirUsuario(NovoUsuario);
                MeusDados.GravarUsuarios(NovoUsuario);

                gravação = true;

            }

            return gravação;

        }

        public bool ValidaUsuario(string usuario, int codigo)
        {
            //bool verifica = MeusDados.ValidaUsuarios(usuario,codigo); 

            //return verifica; 

            bool user = false;

            try
            {
                XElement p = XElement.Load(@"Usuarios.xml");
                IEnumerable<XElement> pesquisa = from e in p.Elements("Usuarios")
                                                 where (string)e.Attribute("Username") == usuario
                                                 select e;

                foreach (XElement e in pesquisa)
                {

                    if ((string)e.Attribute("Username") == usuario || (int)e.Attribute("Codigo") == codigo)
                        user = true;
                }


            }

            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
                FileStream Arquivo = new FileStream(@"Usuarios.xml", FileMode.OpenOrCreate);
                Arquivo.Close();
            }

            catch (System.Xml.XmlException e)
            {
                MessageBox.Show(e.Message);

            }

            return user;
        }

        public bool ValidaLogin(string usuario, string senha)
        {
            //bool verifica = MeusDados.ValidaLogin(usuario,senha);

            //return verifica;

            bool user = false;

            try
            {
                XElement p = XElement.Load(@"Usuarios.xml");
                IEnumerable<XElement> pesquisa = from e in p.Elements("Usuarios")
                                                 where (string)e.Attribute("Username") == usuario
                                                 select e;

                foreach (XElement e in pesquisa)
                {

                    if ((string)e.Attribute("Username") == usuario && (string)e.Attribute("Password") == senha)
                        user = true;
                }


            }

            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
                FileStream Arquivo = new FileStream(@"Usuarios.xml", FileMode.OpenOrCreate);
                Arquivo.Close();
            }

            catch (System.Xml.XmlException e)
            {
                MessageBox.Show(e.Message);

            }

            return user;
        }

        public int PesquisaCodigoAdm(string adm)
        {
            //int codadm;

            //codadm = MeusDados.PesquisaCodigoAdm(adm);

            //return codadm;

            int codadm = 0;

            try
            {
                XElement p = XElement.Load(@"Usuarios.xml");
                IEnumerable<XElement> pesquisa = from e in p.Elements("Usuarios")
                                                 where (string)e.Attribute("Username") == adm
                                                 select e;

                foreach (XElement e in pesquisa)
                {
                    codadm = int.Parse(e.Attribute("Codigo").Value);

                }


            }

            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
                FileStream Arquivo = new FileStream(@"Usuarios.xml", FileMode.OpenOrCreate);
                Arquivo.Close();
            }

            catch (System.Xml.XmlException e)
            {
                MessageBox.Show(e.Message);

            }

            return codadm;

        }

        public void EnviaEmail(string email, string nomeusuario, string senha)
        {
            MeusDados.EnviaEmail(email,nomeusuario,senha);
        }
       public string VerificaTipo(string user)
        {
            //string tipo = MeusDados.VerificaTipo(user);

            // return tipo;

            string tipo = "";

            XElement p = XElement.Load(@"Usuarios.xml");
            IEnumerable<XElement> pesquisa = from e in p.Elements("Usuarios")
                                             where (string)e.Attribute("Username") == user
                                             select e;

            foreach (XElement e in pesquisa)
            {
                tipo = e.Attribute("Tipo").Value.ToString();

            }


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

            dgvDados.DataSource = null;

            dgvDados.DataSource = MeusDados.ListaOcorrencia();

            dgvDados.ClearSelection();

        }

    }
}
