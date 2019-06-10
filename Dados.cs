using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Ocorrencia_de_Manutenção
{
    public class Dados
    {

        public List<Usuarios> CadastroUsuarios;
        public List<Ocorrencia> CadOcorrencias;
        public List<Laboratório> CadLaboratorio;


        public Dados()
        {
            CadastroUsuarios = new List<Usuarios>();
            CadOcorrencias = new List<Ocorrencia>();
            CadLaboratorio = new List<Laboratório>();
        }

        public void InserirUsuario(Usuarios x)
        {
            CadastroUsuarios.Add(x);

        }

        public void InserirOcorrencia(Ocorrencia x)
        {
            CadOcorrencias.Add(x);

        }

        public void InserirLab(Laboratório x)
        {
            CadLaboratorio.Add(x);

        }

        public void GravarUsuarios(Usuarios p)
        {
            try
            {
                XElement x = new XElement("Usuarios");

                x.Add(new XAttribute("Codigo", p.Codigo.ToString()));
                x.Add(new XAttribute("Username", p.Username));
                x.Add(new XAttribute("Email", p.Email));
                x.Add(new XAttribute("Password", p.Password));
                x.Add(new XAttribute("Tipo", p.Tipo));

                XElement xml = XElement.Load(@"Usuarios.xml");

                xml.Add(x);

                xml.Save("Usuarios.xml");
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

        }

        public void GravarLab(Laboratório l)
        {
            try
            {
                XElement x = new XElement("Laboratorios");

                x.Add(new XAttribute("Codigo", l.CodigoLab.ToString()));
                x.Add(new XAttribute("Administrador", l.Administrador));
                x.Add(new XAttribute("CodAdm", l.CodAdm));
                x.Add(new XAttribute("Ocorrencias", l.Ocorrencias));

                XElement xml = XElement.Load(@"Laboratorio.xml");

                xml.Add(x);

                xml.Save("Laboratorio.xml");
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
        }

        public void GravarOcorrenciaXML(Ocorrencia o)
        {
            try
            {
                XElement x = new XElement("Ocorrencias");

                x.Add(new XAttribute("Id", o.ID.ToString()));
                x.Add(new XAttribute("Descricao", o.Descriçao));
                x.Add(new XAttribute("Prioridade", o.Prioridade));
                x.Add(new XAttribute("Status", o.Status));
                x.Add(new XAttribute("UltimaModicacao", o.DataUpdate));
                x.Add(new XAttribute("DataDeAbertura", o.DateInicio));
                x.Add(new XAttribute("Laboratorio", o.Laboratorio));
                x.Add(new XAttribute("Usuario", o.Usuario));


                XElement xml = XElement.Load(@"Ocorrencias.xml");

                xml.Add(x);

                xml.Save(@"Ocorrencias.xml");
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
                FileStream Arquivo = new FileStream(@"Ocorrencias.xml", FileMode.OpenOrCreate);
                Arquivo.Close();
            }

            catch (System.Xml.XmlException e)
            {
                MessageBox.Show(e.Message);

                TextWriter MeuWriter = new StreamWriter(@"Ocorrencias.xml");

                List<Ocorrencia> ListaOcorrencia = CadOcorrencias;

                XmlSerializer Serialização = new XmlSerializer(ListaOcorrencia.GetType());

                Serialização.Serialize(MeuWriter, ListaOcorrencia);

                MeuWriter.Close();

            }
        }

        public bool ValidaLaboratórios(string CódigoLab, string Prédio)
        {
            bool Lab = false;

            try
            {
                XElement Z = XElement.Load(@"Laboratorio.xml");
                IEnumerable<XElement> Pesquisar = from x in Z.Elements("Laboratório")
                                                  where (string)x.Element("CódigoLab") == CódigoLab
                                                  select x;

                foreach (XElement e in Pesquisar)
                {

                    if ((string)e.Element("Codigo") == CódigoLab && (string)e.Element("Predio") == Prédio)
                        Lab = true;
                }

            }

            catch (FileNotFoundException e) //excessão caso o arquivo XML não exista
            {
                MessageBox.Show(e.Message);
                FileStream Arquivo1 = new FileStream(@"Laboratorio.xml", FileMode.OpenOrCreate);
                Arquivo1.Close();
            }

            catch (System.Xml.XmlException e) // caso o arquivo esteja vazio
            {
                MessageBox.Show(e.Message);

            }

            return Lab;
        }



        public void EnviaEmail(string email, string nomeusuario, string senha)
        {
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("registroocorrencialab@gmail.com", "R@inh@337890");

            MailMessage mail = new MailMessage();
            mail.Sender = new System.Net.Mail.MailAddress("registroocorrencialab@gmail.com", "Gestão de Laboratório de Informática");
            mail.From = new MailAddress("registroocorrencialab@gmail.com", "GLI");
            mail.To.Add(new MailAddress(email, nomeusuario));

            mail.Subject = "Contato";
            mail.Body = "Usuario cadastrado com sucesso! Usuario: \n" + nomeusuario + "\n Senha: " + senha;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            try
            {
                smtp.Send(mail);
            }
            catch (InvalidOperationException erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                mail = null;
            }
        }


        public List<Ocorrencia> ListaOcorrencia()
        {

            CadOcorrencias = new List<Ocorrencia>();
            try
            {

                XElement xml = XElement.Load("Ocorrencias.xml");
                foreach (XElement x in xml.Elements())
                {
                    Ocorrencia o = new Ocorrencia()
                    {
                        ID = int.Parse(x.Attribute("Id").Value),
                        Descriçao = x.Attribute("Descricao").Value,
                        Prioridade = x.Attribute("Prioridade").Value,
                        Status = x.Attribute("Status").Value,
                        DataUpdate = x.Attribute("UltimaModicacao").Value,
                        DateInicio = x.Attribute("DataDeAbertura").Value,
                        Laboratorio = int.Parse(x.Attribute("Laboratorio").Value),
                        Usuario = x.Attribute("Usuario").Value

                    };
                    CadOcorrencias.Add(o);

                }

            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
                FileStream Arquivo = new FileStream(@"Ocorrencias.xml", FileMode.OpenOrCreate);
                Arquivo.Close();
            }

            catch (System.Xml.XmlException e)
            {
                MessageBox.Show(e.Message);


            }

            CadOcorrencias = CadOcorrencias.OrderBy(x => x.DateInicio).ToList();

            return CadOcorrencias;
        }

        public List<Ocorrencia> ListaOcorrenciaOrdenada(string a)
        {

            CadOcorrencias = new List<Ocorrencia>();
            try
            {

                XElement xml = XElement.Load("Ocorrencias.xml");

                foreach (XElement x in xml.Elements())
                {
                    Ocorrencia o = new Ocorrencia()
                    {
                        ID = int.Parse(x.Attribute("Id").Value),
                        Descriçao = x.Attribute("Descricao").Value,
                        Prioridade = x.Attribute("Prioridade").Value,
                        Status = x.Attribute("Status").Value,
                        DataUpdate = x.Attribute("UltimaModicacao").Value,
                        DateInicio = x.Attribute("DataDeAbertura").Value,
                        Laboratorio = int.Parse(x.Attribute("Laboratorio").Value),
                        Usuario = x.Attribute("Usuario").Value

                    };
                    CadOcorrencias.Add(o);

                }

            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
                FileStream Arquivo = new FileStream(@"Ocorrencias.xml", FileMode.OpenOrCreate);
                Arquivo.Close();
            }

            catch (System.Xml.XmlException e)
            {
                MessageBox.Show(e.Message);


            }
            if (a == "Prioridade")
                CadOcorrencias = CadOcorrencias.OrderBy(x => x.Prioridade).ThenBy(p => p.DateInicio).ToList();

            if (a == "DatadeAbertura")
                CadOcorrencias = CadOcorrencias.OrderBy(x => x.DateInicio).ToList();

            if (a == "Status")
                CadOcorrencias = CadOcorrencias.OrderBy(x => x.Status).ThenBy(p => p.Prioridade).ToList();

            if (a == "Laboratorio")
                CadOcorrencias = CadOcorrencias.OrderBy(x => x.Laboratorio).ToList();

            if (a == "ID")
                CadOcorrencias = CadOcorrencias.OrderBy(x => x.ID).ToList();

            return CadOcorrencias;
        }

        public List<Laboratório> ListaLaboratorios()
        {

            CadLaboratorio = new List<Laboratório>();
            try
            {

                XElement xml = XElement.Load("Laboratorio.xml");
                foreach (XElement x in xml.Elements())
                {
                    Laboratório l = new Laboratório()
                    {
                        CodigoLab = int.Parse(x.Attribute("Codigo").Value),
                        Administrador = x.Attribute("Administrador").Value,
                        CodAdm = int.Parse(x.Attribute("CodAdm").Value),
                        Ocorrencias = int.Parse(x.Attribute("Ocorrencias").Value)


                    };
                    CadLaboratorio.Add(l);

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

            CadLaboratorio = CadLaboratorio.OrderBy(x => x.CodigoLab).ToList();

            return CadLaboratorio;
        }

        public List<Laboratório> ListaLaboratorioordenado(string a)
        {

            CadLaboratorio = new List<Laboratório>();
            try
            {

                XElement xml = XElement.Load("Laboratorio.xml");

                foreach (XElement x in xml.Elements())
                {
                    Laboratório l = new Laboratório()
                    {
                        CodigoLab = int.Parse(x.Attribute("Codigo").Value),
                        Administrador = x.Attribute("Administrador").Value,
                        CodAdm = int.Parse(x.Attribute("CodAdm").Value),
                        Ocorrencias = int.Parse(x.Attribute("Ocorrencias").Value)

                    };
                    CadLaboratorio.Add(l);

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
            if (a == "Codigo")
                CadLaboratorio = CadLaboratorio.OrderBy(x => x.CodigoLab).ToList();

            if (a == "Administrador")
                CadLaboratorio = CadLaboratorio.OrderBy(x => x.Administrador).ToList();

            if (a == "CodAdm")
                CadLaboratorio = CadLaboratorio.OrderBy(x => x.CodAdm).ToList();

            if (a == "Ocorrencias")
                CadLaboratorio = CadLaboratorio.OrderBy(x => x.Ocorrencias).ToList();

            return CadLaboratorio;
        }

        public List<Usuarios> ListaUsuarios()
        {

            CadastroUsuarios = new List<Usuarios>();
            try
            {

                XElement xml = XElement.Load("Usuarios.xml");
                foreach (XElement x in xml.Elements())
                {
                    Usuarios u = new Usuarios()
                    {
                        Codigo = int.Parse(x.Attribute("Codigo").Value),
                        Username = x.Attribute("Username").Value,
                        Email = x.Attribute("Email").Value,
                        Password = x.Attribute("Password").Value,
                        Tipo = x.Attribute("Tipo").Value


                    };
                    CadastroUsuarios.Add(u);

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

            CadastroUsuarios = CadastroUsuarios.OrderBy(x => x.Codigo).ToList();

            return CadastroUsuarios;
        }

        public List<Usuarios> ListaUsuariosOrdenado(string a)
        {

            CadastroUsuarios = new List<Usuarios>();
            try
            {

                XElement xml = XElement.Load("Usuarios.xml");

                foreach (XElement x in xml.Elements())
                {
                    Usuarios u = new Usuarios()
                    {
                        Codigo = int.Parse(x.Attribute("Codigo").Value),
                        Username = x.Attribute("Username").Value,
                        Email = x.Attribute("Email").Value,
                        Password = x.Attribute("Password").Value,
                        Tipo = x.Attribute("Tipo").Value

                    };
                    CadastroUsuarios.Add(u);

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
            if (a == "Codigo")
                CadastroUsuarios = CadastroUsuarios.OrderBy(x => x.Codigo).ToList();

            if (a == "Username")
                CadastroUsuarios = CadastroUsuarios.OrderBy(x => x.Username).ToList();

            if (a == "Tipo")
                CadastroUsuarios = CadastroUsuarios.OrderBy(x => x.Tipo).ToList();

            return CadastroUsuarios;
        }
        public void ExcluirOcorrencia(int codigo)
        {

            XElement xml = XElement.Load("Ocorrencias.xml");
            XElement x = xml.Elements().Where(p => p.Attribute("Id").Value.Equals(codigo.ToString())).First();
            if (x != null)
            {
                x.Remove();
            }
            xml.Save("Ocorrencias.xml");

        }

        public void ExcluirLaboratorio(int codigo)
        {

            XElement xml = XElement.Load("Laboratorio.xml");
            XElement x = xml.Elements().Where(p => p.Attribute("Codigo").Value.Equals(codigo.ToString())).First();
            if (x != null)
            {
                x.Remove();
            }
            xml.Save("Laboratorio.xml");

        }

        public void ExcluirUsuario(string user)
        {

            XElement xml = XElement.Load("Usuarios.xml");
            XElement x = xml.Elements().Where(p => p.Attribute("Username").Value.Equals(user.ToString())).First();
            if (x != null)
            {
                x.Remove();
            }
            xml.Save("Usuarios.xml");

        }

    }
}
