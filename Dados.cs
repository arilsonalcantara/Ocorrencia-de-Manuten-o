using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
                x.Add(new XAttribute("Status", l.Ocorrencias));
                x.Add(new XAttribute("Predio", l.Prédio));

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
                x.Add(new XAttribute("Descrição", o.Descriçao));
                x.Add(new XAttribute("Status", o.Status));
                x.Add(new XAttribute("UltimaModicacao", o.DataUpdate));
                x.Add(new XAttribute("DataDeAbertura", o.DateInicio));
                x.Add(new XAttribute("Predio", o.Predio));
                x.Add(new XAttribute("Laboratorio", o.Laboratorio));
                x.Add(new XAttribute("Usuario", o.Usuario));


                XElement xml = XElement.Load(@"Ocorrencias.xml");

                xml.Add(x);

                xml.Save("Ocorrencias.xml");
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
        }

        public bool ValidaLaboratórios(string CódigoLab, string Prédio)
        {
            bool Lab = false;

            try
            {
                XElement Z = XElement.Load(@"Laboratório.xml");
                IEnumerable<XElement> Pesquisar = from x in Z.Elements("Laboratório")
                                                  where (string)x.Element("CódigoLab") == CódigoLab
                                                  select x;

                foreach (XElement e in Pesquisar)
                {

                    if ((string)e.Element("CódigoLab") == CódigoLab && (string)e.Element("Prédio") == Prédio)
                        Lab = true;
                }

            }

            catch (FileNotFoundException e) //excessão caso o arquivo XML não exista
            {
                MessageBox.Show(e.Message);
                FileStream Arquivo1 = new FileStream(@"Laboratório.xml", FileMode.OpenOrCreate);
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
                        ID = int.Parse(x.Attribute("ID").Value),
                        Descriçao = x.Attribute("Descriçao").Value,
                        Status = x.Attribute("Status").Value,
                        DateInicio = x.Attribute("DateInicio").Value,
                        DataUpdate = x.Attribute("DataUpdate").Value,
                        Predio = x.Attribute("Predio").Value,
                        Laboratorio = int.Parse(x.Attribute("Laboratorio").Value),
                        Usuario = x.Attribute("Usuario").Value,
                        Prioridade = x.Attribute("Prioridade").Value
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

                TextWriter MeuWriter = new StreamWriter(@"Ocorrencias.xml");

                List<Ocorrencia> ListaOcorrencia = CadOcorrencias;

                XmlSerializer Serialização = new XmlSerializer(ListaOcorrencia.GetType());

                Serialização.Serialize(MeuWriter, ListaOcorrencia);

                MeuWriter.Close();
            }

            return CadOcorrencias;
        }

    }
}
