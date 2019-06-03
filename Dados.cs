using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Ocorrencia_de_Manutenção
{
    class Dados
    {
        XmlSerializer Serialização; 

        private ArrayList CadastroUsuarios; //criando um ArrayList para (não sei se vamos precisar, mas tá aí)

        public Dados()
        {
            CadastroUsuarios = new ArrayList();
        }

        public void Inserir(Usuarios x)
        {
            CadastroUsuarios.Add(x);
        }

        public void GravarUsuarios(string nome, string email, string senha, string tipo) //abaixo método para escrever no XML (olhem um projeto do Bernardo de XML no SGA, está explicando cada linha abaixo)
        {

                TextWriter MeuWriter = new StreamWriter(@"Usuarios.xml");

                Usuarios[] UsuariosVetor = (Usuarios[])CadastroUsuarios.ToArray(typeof(Usuarios));

                XmlSerializer Serialização = new XmlSerializer(UsuariosVetor.GetType());

                Serialização.Serialize(MeuWriter, UsuariosVetor);

                MeuWriter.Close();
        }

        public void LerXMLUsuarios() // Façam a mesma coisa, olhem no SGA
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
                                                 where (string)e.Element("Username") == usuario
                                                 select e;

                foreach (XElement e in pesquisa)
                {
                    
                    if ((string)e.Element("Username") == usuario && (string)e.Element("Password") == senha)
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
    }
}
