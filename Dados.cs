using System;
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
    class Dados
    {
        XmlSerializer Serialização;

        private ArrayList CadastroUsuarios;

        //public Dados()
        //{
        //    CadastroUsuarios = new ArrayList(); NÃO VAMOS MAIS PRECISAR
        //}

        public void Inserir(Usuarios x)
        {
            CadastroUsuarios.Add(x);

        }

        public void GravarUsuarios(Usuarios p)
        {

            XElement x = new XElement("Usuarios"); // aqui ele cria um container pai com o Nome Usuarios


            x.Add(new XAttribute("Código", p.Codigo.ToString())); //ele está criando atributos com o nome entre aspas, e pegando a váriavel que eu passei por parametro que é do tipo Usuarios
            x.Add(new XAttribute("Username", p.Username));
            x.Add(new XAttribute("Email", p.Email));
            x.Add(new XAttribute("Password", p.Password));
            x.Add(new XAttribute("Tipo", p.Tipo));

            XElement xml = XElement.Load("Usuarios.xml"); // carrega o arquivo

            xml.Add(x); // pega tudo que está na varíavel x (como no arraylist) e adiciona ao final

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

        public bool ValidaUsuarios(string usuario, string senha)
        {
            bool user = false;

            try
            {
                XElement p = XElement.Load(@"Usuarios.xml");
                IEnumerable<XElement> pesquisa = from e in p.Elements("Usuarios")
                                                 where (string)e.Attribute("Username") == usuario //Troquei Element por Atribute
                                                 select e;

                foreach (XElement e in pesquisa)
                {

                    if ((string)e.Attribute("Username") == usuario && (string)e.Attribute("Password") == senha)
                        user = true;
                }


            }

            catch (FileNotFoundException e) //excessão caso o arquivo XML não exista
            {
                MessageBox.Show(e.Message);
                FileStream Arquivo = new FileStream(@"Usuarios.xml", FileMode.OpenOrCreate);
                Arquivo.Close();
            }

            catch (System.Xml.XmlException e) // caso o arquivo esteja vazio
            {
                MessageBox.Show(e.Message);

            }

            return user;
        }

        XmlSerializer Serialização2; //criando um objeto para serializar o XML

        private ArrayList CadastroLab; //criando um ArrayList para (não sei se vamos precisar, mas tá aí)

        //public Dados()
        //{
        //    CadastroLab = new ArrayList(); NÃO VAMOS MAIS PRECISAR!!!!!
        //}

        public void Inserir(Laboratório x)
        {
            CadastroLab.Add(x);
        }

        public void GravarLaboratórios()
        {

            TextWriter MeuWriter2 = new StreamWriter(@"Laboratório.xml");

            Laboratório[] LabVetor = (Laboratório[])CadastroLab.ToArray(typeof(Laboratório));

            //primeiro aparece Elemento Raiz inexistente e depois aponta para a linha abaixo. 

            XmlSerializer Serialização2 = new XmlSerializer(LabVetor.GetType());// Erro. Tá dando que é inacessível. Não sei se deixei algum em private e nem percebi. 

            Serialização2.Serialize(MeuWriter2, LabVetor);

            MeuWriter2.Close();
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
