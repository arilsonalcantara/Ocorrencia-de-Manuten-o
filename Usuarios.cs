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
    public class Usuarios: IControler
    {
        private int _Codigo;

        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        private string _Username;

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        private string _Tipo;

        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }



        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        public int CodUniq()
        {
            Random random = new Random();

            int cod = random.Next(1, 100);

            return cod;
            
        }
        public  Usuarios()
        {
            Codigo = CodUniq();
        }

        public override string ToString()
        {
            return this.Username;
        }

        public  List<Usuarios> ListarUsuarios()
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            XElement xml = XElement.Load("Usuarios.xml");
            foreach (XElement x in xml.Elements())
            {
                Usuarios u = new Usuarios()
                {
                    Username = x.Attribute("Username").Value
                };
                usuarios.Add(u);
            }
            return usuarios;
        }


        
        



    }
}
