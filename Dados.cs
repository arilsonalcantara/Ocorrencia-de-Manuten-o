﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        XmlSerializer Serialização;

        public ArrayList CadastroUsuarios;

        public Dados()
        {
            CadastroUsuarios = new ArrayList();
        }

        public void Inserir(Usuarios x)
        {
            CadastroUsuarios.Add(x);

        }

        public void GravarUsuarios(Usuarios p)
        {
            try
            {
                XElement x = new XElement("Usuarios"); 

                x.Add(new XAttribute("Código", p.Codigo.ToString())); 
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

        public void LerXMLUsuarios()
        {
            CadastroUsuarios.Clear();

            FileStream Arquivo = new FileStream(@"Usuarios.xml", FileMode.Open);

            Usuarios[] ListaUsuariosVetor = (Usuarios[])Serialização.Deserialize(Arquivo);

            CadastroUsuarios.Clear();
            CadastroUsuarios.AddRange(ListaUsuariosVetor);



            /* foreach (Usuarios xe in ListaUsuariosVetor) //
             {

             }*/


            Arquivo.Close();
        }

        public bool ValidaUsuarios(string usuario, int codigo)
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
    }
}
