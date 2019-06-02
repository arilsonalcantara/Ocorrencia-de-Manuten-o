using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocorrencia_de_Manutenção
{
    class Laboratório
    {
        private string _Adiministrador; // Pensei que cada laboratório tem um responsável, logo um administrador.

        public string Administrador
        {
            get { return _Adiministrador; }
            set { _Adiministrador = value; }
        }

        private string _CódigoLab; // Cada laboratório possui um identificador que é o código.

        public string CódigoLab
        {
            get { return _CódigoLab; }
            set { _CódigoLab = value; }
        }

        // Pensei que isso seria útil para a listagem, 
        //porque ele pode querer listar os laboratórios e saber qual tá disponíivel e qual tá em manutenção.
        // Ou modificar o status do laboratório depois. Podemos criar esse botão no Menu Principal

        private string _Status;

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        // Mudança para prédio. Para identificar o local do labortório 

        private string _Prédio;

        public string Prédio
        {
            get { return _Prédio; }
            set { _Prédio = value; }
        }

        //Pensei em colocar código do usuário também lá na tela.

    }
}
