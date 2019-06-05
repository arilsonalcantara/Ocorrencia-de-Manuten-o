using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocorrencia_de_Manutenção
{
    public class Laboratório: IControler
    {
        private string _Adiministrador; 

        public string Administrador
        {
            get { return _Adiministrador; }
            set { _Adiministrador = value; }
        }

        private int _CodigoLab; 

        public int CodigoLab
        {
            get { return _CodigoLab; }
            set { _CodigoLab = value; }
        }

        private string _Status;

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }


        private int _Prédio;

        public int Prédio
        {
            get { return _Prédio; }
            set { _Prédio = value; }
        }

        private int _CodAdm;

        public int CodAdm
        {
            get { return _CodAdm; }
            set { _CodAdm = value; }
        }


        public int CodUniq()
        {
            Random random = new Random();

            int cod = random.Next(1, 100);

            return cod;

        }
        public Laboratório()
        {
            CodigoLab = CodUniq();
        }
    }
}
