using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocorrencia_de_Manutenção
{
    class Operações
    {
        private Dados MeusDados;

        public Operações()
        {
            MeusDados = new Dados(); // instancia a classe dados
        }

        public void InserirUsuario()
        {
            MeusDados.GravarUsuarios(); //chamando método GravarUsuarios da classe Dados
        }

        public bool ValidaUsuario(string usuario, string senha) //Método de validação, recebendo os parâmetros
        {
            bool verifica = MeusDados.ValidaUsuarios(usuario,senha); //Chamando a classe dados, e passando mais uma vez usuario e senha

            return verifica; // retorna para o Form1 TRUE (se existir o usuario) ou FALSE
        }
    }
}
