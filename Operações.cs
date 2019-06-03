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

                MeusDados.GravarUsuarios(NovoUsuario);

                gravação = true;

            }

            return gravação;

        }

        public bool ValidaUsuario(string usuario, string senha) //Método de validação, recebendo os parâmetros
        {
            bool verifica = MeusDados.ValidaUsuarios(usuario,senha); //Chamando a classe dados, e passando mais uma vez usuario e senha

            return verifica; // retorna para o Form1 TRUE (se existir o usuario) ou FALSE
        }

        private Dados MeusDados1;

       

        public bool InserirLaboratório(string Adm, string Status, string Prédio)
        {
            bool Gravação = false;
            bool Verifica = true;

            Laboratório xLab;
            Laboratório Lab1 = new Laboratório(); //Instância da classe laboratório para pegar o código
            string CódigoL = Lab1.CódigoLab; //pega o Código

            Verifica = ValidaLab(CódigoL, Prédio); //Valida Código e o Prédio para não ter repetição.

            if (Verifica == false)
            {
                xLab = new Laboratório();

                xLab.Administrador = Adm;
                xLab.Status = Status;
                xLab.Prédio = Prédio;


                MeusDados1.Inserir(xLab);

                MeusDados1.GravarLaboratórios();
                Gravação = true;

            }

            return Gravação;

        }

        public bool ValidaLab(string CódigoLab, string Prédio) //Método de validação, recebendo os parâmetros
        {
            bool Verifica = MeusDados1.ValidaLaboratórios(CódigoLab, Prédio); //Chamando a classe dados, e passando mais uma vez usuario e senha

            return Verifica; // retorna para o Form1 TRUE (se existir o usuario) ou FALSE

        }
    }
}
