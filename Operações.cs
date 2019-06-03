using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ocorrencia_de_Manutenção
{
    class Operações
    {
        private Dados MeusDados;

        public Operações()
        {
            MeusDados = new Dados(); // instancia a classe dados
        }

        public bool InserirUsuario(string nome, string email, string senha, string tipo)
        {
            bool gravação = false;
            bool verifica = true;

            Usuarios NovoUsuario;

            verifica = ValidaUsuario(nome, senha);

            if(verifica == false)
            {
                NovoUsuario = new Usuarios();

                NovoUsuario.Username = nome;
                NovoUsuario.Email = email;
                NovoUsuario.Password = senha;
                NovoUsuario.Tipo = tipo;

                MeusDados.Inserir(NovoUsuario);

                MeusDados.GravarUsuarios();

                gravação = true;

            }

            return gravação;

        }

        public bool ValidaUsuario(string usuario, string senha) //Método de validação, recebendo os parâmetros
        {
            bool verifica = MeusDados.ValidaUsuarios(usuario,senha); //Chamando a classe dados, e passando mais uma vez usuario e senha

            return verifica; // retorna para o Form1 TRUE (se existir o usuario) ou FALSE
        }
    }
}
