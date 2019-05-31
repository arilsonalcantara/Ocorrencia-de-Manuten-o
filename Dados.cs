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
        XmlSerializer Serialização; //criando um objeto para serializar o XML

        private ArrayList CadastroUsuarios; //criando um ArrayList para (não sei se vamos precisar, mas tá aí)

        public Dados()
        {
            CadastroUsuarios = new ArrayList();
        }

        public void GravarUsuarios() //abaixo método para escrever no XML (olhem um projeto do Bernardo de XML no SGA, está explicando cada linha abaixo)
        {
            TextWriter MeuWriter = new StreamWriter(@"D:\\Usuarios.xml");

            Usuarios[] UsuariosVetor = (Usuarios[])CadastroUsuarios.ToArray(typeof(Usuarios));

            XmlSerializer Serialização = new XmlSerializer(UsuariosVetor.GetType());

            Serialização.Serialize(MeuWriter, UsuariosVetor);

            MeuWriter.Close();
        }

        public void LerXMLUsuarios() // Façam a mesma coisa, olhem no SGA
        {
            CadastroUsuarios.Clear();

            FileStream Arquivo = new FileStream(@"D:\\Usuarios.xml", FileMode.Open);

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
            bool user = false; //Já acusando que o usário não existe

            //Abaixo coloquei um TRY CATCH, pois caso não exista o arquivo, vai tratar o erro,
            //e também quando o arquivo estiver vazio, quando rodar a primeira vez.

            try
            {
                //Abaixo estou usando uma interface que IEnumerable que me possibilita fazer uma pesquisa numa lista
                //de um tipo específico (XElement). 
                //A consulta que fiz diz o seguinte: "Procure em todos os elementos filhos (ou seja, que estão dentro da tag Usuarios no XML)
                //o elemento (Element | com a tag _Username) o valor usuario(que estará com o usuario que eu digitei), e seleciona todos que corresponderem (select e)

                XElement p = XElement.Load(@"D:\\Usuarios.xml"); 
                IEnumerable<XElement> pesquisa = from e in p.Elements("Usuarios")
                                                 where (string)e.Element("_Username") == usuario
                                                 select e;

                foreach (XElement e in pesquisa)
                {
                    //O foreach vai percorrer a lista, e com a condição abaixo estou fazendo:
                    // Se o elemento usuario que eu selecionei e a senha for exatamente igual a senha que digitei,
                    //então o usuário existe, logo a variável USER, recebe TRUE
                    // Reparem que na consulta eu não preciso colocar o Element _Password

                    if ((string)e.Element("_Username") == usuario && (string)e.Element("_Password") == senha)
                        user = true;
                }

                return user; // retorna a validação
            }

            catch (FileNotFoundException e) //excessão caso o arquivo XML não exista
            {
                MessageBox.Show(e.Message);
                FileStream Arquivo = new FileStream(@"D:\\Usuarios.xml", FileMode.OpenOrCreate);
                Arquivo.Close();

                return user; // retorna FALSE
            }

            catch (System.Xml.XmlException e) // caso o arquivo esteja vazio
            {
                MessageBox.Show(e.Message);
                return user; // retorna falso
            }

        }
    }
}
