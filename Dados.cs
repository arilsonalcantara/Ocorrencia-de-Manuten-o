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

        private ArrayList CadastroUsuarios;

        public Dados()
        {
            CadastroUsuarios = new ArrayList();
        }

        public void GravarUsuarios()
        {
            TextWriter MeuWriter = new StreamWriter(@"D:\\Usuarios.xml");

            Usuarios[] UsuariosVetor = (Usuarios[])CadastroUsuarios.ToArray(typeof(Usuarios));

            XmlSerializer Serialização = new XmlSerializer(UsuariosVetor.GetType());

            Serialização.Serialize(MeuWriter, UsuariosVetor);

            MeuWriter.Close();
        }

        public void LerXMLUsuarios()
        {
            CadastroUsuarios.Clear();

            FileStream Arquivo = new FileStream(@"D:\\Usuarios.xml", FileMode.Open);

            Usuarios[] ListaUsuariosVetor = (Usuarios[])Serialização.Deserialize(Arquivo); 

            CadastroUsuarios.Clear();  
            CadastroUsuarios.AddRange(ListaUsuariosVetor);   



            foreach (Usuarios xe in ListaUsuariosVetor)
            {

            }


            Arquivo.Close();
        }

        public bool ValidaUsuarios(string usuario, string senha)
        {
            bool user = false;

            try
            {
                XElement p = XElement.Load(@"D:\\Usuarios.xml");
                IEnumerable<XElement> pesquisa = from m in p.Elements("Usuarios")
                                                 where (string)m.Element("_Username") == usuario
                                                 select m;

                foreach (XElement m in pesquisa)
                {
                    if ((string)m.Element("_Username") == usuario && (string)m.Element("_Password") == senha)
                        user = true;
                }

                return user;
            }

            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
                FileStream Arquivo = new FileStream(@"D:\\Usuarios.xml", FileMode.OpenOrCreate);
                Arquivo.Close();

                return user;
            }

            catch (System.Xml.XmlException e)
            {
                MessageBox.Show(e.Message);
                return user;
            }

        }
    }
}
