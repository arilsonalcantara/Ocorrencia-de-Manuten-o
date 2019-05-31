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
            MeusDados.GravarUsuarios();
        }

        public bool ValidaUsuario(string usuario, string senha)
        {
            bool verifica = MeusDados.ValidaUsuarios(usuario,senha);

            return verifica;
        }
    }
}
