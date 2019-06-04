using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ocorrencia_de_Manutenção
{
    public class Operações
    {
        private Dados MeusDados;

        public Operações()
        {
            MeusDados = new Dados(); 
        }

        public bool InserirUsuario(int codigo,string nome, string email, string senha, string tipo)
        {
            bool gravação = false;
            bool verifica = true;

            Usuarios NovoUsuario;

            verifica = ValidaUsuario(nome,codigo);

            if(verifica == false)
            {
                NovoUsuario = new Usuarios();

                NovoUsuario.Codigo = codigo;
                NovoUsuario.Username = nome;
                NovoUsuario.Email = email;
                NovoUsuario.Password = senha;
                NovoUsuario.Tipo = tipo;


                //MeusDados.Inserir(NovoUsuario);
                MeusDados.GravarUsuarios(NovoUsuario);

                gravação = true;

            }

            return gravação;

        }

        public bool ValidaUsuario(string usuario, int codigo)
        {
            bool verifica = MeusDados.ValidaUsuarios(usuario,codigo); 

            return verifica; 
        }
    }
}
