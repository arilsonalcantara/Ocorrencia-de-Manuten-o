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


        public bool InserirLab(int codigo, string adm, int codadm, int ocorrencia, int predio)
        {
            bool gravação = false;
            bool verifica = true;

            Laboratório NovoLaboratorio;

            verifica = ValidaLab(codigo, predio);

            if (verifica == false)
            {
                NovoLaboratorio = new Laboratório();

                NovoLaboratorio.CodigoLab = codigo;
                NovoLaboratorio.Administrador = adm;
                NovoLaboratorio.CodAdm = codigo;
                NovoLaboratorio.Ocorrencias = ocorrencia;
                NovoLaboratorio.Prédio = predio;


                MeusDados.InserirLab(NovoLaboratorio);
                MeusDados.GravarLab(NovoLaboratorio);

                gravação = true;

            }

            return gravação;

        }


        public bool ValidaLab(int codigo, int predio)
        {
            bool lab = false;

            try
            {
                XElement p = XElement.Load(@"Laboratorio.xml");
                IEnumerable<XElement> pesquisa = from e in p.Elements("Laboratorios")
                                                 where (int)e.Attribute("Predio") == predio 
                                                 select e;

                foreach (XElement e in pesquisa)
                {

                    if ((int)e.Attribute("Laboratorio") == codigo && (int)e.Attribute("Predio") == predio)
                        lab = true;
                }


            }

            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
                FileStream Arquivo = new FileStream(@"Laboratorio.xml", FileMode.OpenOrCreate);
                Arquivo.Close();
            }

            catch (System.Xml.XmlException e)
            {
                MessageBox.Show(e.Message);

            }

            return lab;
        }




        public void InserirOcorrencia(Ocorrencia x)
        {
            MeusDados.InserirOcorrencia(x);
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

        

    }
}
