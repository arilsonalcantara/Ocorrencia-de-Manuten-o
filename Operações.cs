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

        public bool InserirUsuario(int codigo, string nome, string email, string senha, string tipo)
        {
            bool gravação = false;
            bool verifica = true;

            Usuarios NovoUsuario;

            verifica = ValidaUsuario(nome, codigo);

            if (verifica == false)
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


        public bool InserirLab(int codigo, string adm, int codadm, int ocorrencia)
        {
            bool gravação = false;
            bool verifica = true;

            Laboratório NovoLaboratorio;

            verifica = ValidaLab(codigo);

            if (verifica == false)
            {
                NovoLaboratorio = new Laboratório();

                NovoLaboratorio.CodigoLab = codigo;
                NovoLaboratorio.Administrador = adm;
                NovoLaboratorio.CodAdm = codigo;
                NovoLaboratorio.Ocorrencias = ocorrencia;



                MeusDados.InserirLab(NovoLaboratorio);
                MeusDados.GravarLab(NovoLaboratorio);

                gravação = true;

            }

            return gravação;

        }

        public bool InserirOcorrencia(string descricao, string prioridade, string status, string atualizado, string inicio, int lab, string user)
        {
            bool gravação = false;

            Ocorrencia NovaOcorrencia;


            NovaOcorrencia = new Ocorrencia();

            NovaOcorrencia.ID = NovaOcorrencia.ID;
            NovaOcorrencia.Descriçao = descricao;
            NovaOcorrencia.Prioridade = prioridade;
            NovaOcorrencia.Status = status;
            NovaOcorrencia.DataUpdate = atualizado;
            NovaOcorrencia.DateInicio = inicio;
            NovaOcorrencia.Laboratorio = lab;
            NovaOcorrencia.Usuario = user;



            MeusDados.InserirOcorrencia(NovaOcorrencia);
            MeusDados.GravarOcorrenciaXML(NovaOcorrencia);

            gravação = true;



            return gravação;

        }


        public bool ValidaLab(int codigo)
        {
            bool lab = false;

            try
            {
                XElement p = XElement.Load(@"Laboratorio.xml");
                IEnumerable<XElement> pesquisa = from e in p.Elements("Laboratorios")
                                                 where (int)e.Attribute("Codigo") == codigo
                                                 select e;

                foreach (XElement e in pesquisa)
                {

                    if ((int)e.Attribute("Codigo") == codigo)
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






        public bool ValidaUsuario(string usuario, int codigo)
        {

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
            MeusDados.EnviaEmail(email, nomeusuario, senha);
        }

        public string VerificaTipo(string user)
        {

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


        public void EditarOcorrencias(int id, string descriçao, string Prioridade, string Status, string DataUpdate, string DateInicio, int Laboratorio, string Usuario)
        {
            Ocorrencia NovaOcorrencia = new Ocorrencia();

            NovaOcorrencia.Descriçao = descriçao;
            NovaOcorrencia.Prioridade = Prioridade;
            NovaOcorrencia.Status = Status;
            NovaOcorrencia.DataUpdate = DataUpdate;
            NovaOcorrencia.DateInicio = DateInicio;
            NovaOcorrencia.Laboratorio = Laboratorio;
            NovaOcorrencia.Usuario = Usuario;

            XElement xml = XElement.Load("Ocorrencias.xml");
            XElement x = xml.Elements().Where(p => p.Attribute("Id").Value.Equals(id.ToString())).First();
            if (x != null)
            {
                x.Attribute("Descricao").SetValue(NovaOcorrencia.Descriçao);
                x.Attribute("Prioridade").SetValue(NovaOcorrencia.Prioridade);
                x.Attribute("Status").SetValue(NovaOcorrencia.Status);
                x.Attribute("UltimaModicacao").SetValue(NovaOcorrencia.DataUpdate);
                x.Attribute("DataDeAbertura").SetValue(NovaOcorrencia.DateInicio);
                x.Attribute("Laboratorio").SetValue(NovaOcorrencia.Laboratorio);
                x.Attribute("Usuario").SetValue(NovaOcorrencia.Usuario);
            }
            xml.Save("Ocorrencias.xml");

        }

        public void EditarLaboratorio(int id, string novoadm, int novocodAdm)
        {
            Laboratório l = new Laboratório();

            l.Administrador = novoadm;
            l.CodAdm = novocodAdm;

            XElement xml = XElement.Load("Laboratorio.xml");
            XElement x = xml.Elements().Where(p => p.Attribute("Codigo").Value.Equals(id.ToString())).First();
            if (x != null)
            {
                x.Attribute("Administrador").SetValue(l.Administrador);
                x.Attribute("CodAdm").SetValue(l.CodAdm);
                
            }
            xml.Save("Laboratorio.xml");

        }

        public void EditarUsuario(string username, string email, string password, string tipo)
        {
            Usuarios u = new Usuarios();

            u.Username = username;
            if (!email.Equals(""))
            {
                u.Email = email;
            }
            if (!password.Equals(""))
            {
                u.Password = password;
            }
            u.Tipo = tipo;

            XElement xml = XElement.Load("Usuarios.xml");
            XElement x = xml.Elements().Where(p => p.Attribute("Username").Value.Equals(username.ToString())).First();
            if (x != null)
            {
                x.Attribute("Username").SetValue(u.Username);
                if (!email.Equals(""))
                    x.Attribute("Email").SetValue(u.Email);
                if (!password.Equals(""))
                    x.Attribute("Password").SetValue(u.Password);
                x.Attribute("Tipo").SetValue(u.Tipo);


            }
            xml.Save("Usuarios.xml");

        }
    }
}
