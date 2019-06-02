using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocorrencia_de_Manutenção
{
    public abstract class Usuarios
    {
        private string _Codigo;

        public string Codigo
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

        public virtual void GeraCodigo()
        {
            Codigo = Guid.NewGuid().ToString().Substring(9, 4).ToUpper(); // gera código único
            
        }

        public abstract void ListaOcorrencia();



    }
}
