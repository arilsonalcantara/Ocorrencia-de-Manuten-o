using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocorrencia_de_Manutenção
{
    class Ocorrencia:IControler
    {

        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Descriçao;

        public string Descriçao
        {
            get { return _Descriçao; }
            set { _Descriçao = value; }
        }

        private string _Status;

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        //private Data _DateInicio;   || Comentado para lembrar de implmentar

        //public Data DateInicio
        //{
        //    get { return _DateInicio; }
        //    set { _DateInicio = value; }
        //}

        //private Data _DataUpdate;

        //public Data DataUpdate
        //{
        //    get { return _DataUpdate; }
        //    set { _DataUpdate = value; }
        //}

        private int _Laboratorio;

        public int  Laboratorio
        {
            get { return _Laboratorio; }
            set { _Laboratorio = value; }
        }

        private string _Usuario;

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public int CodUniq()
        {
            Random random = new Random();

            int cod = random.Next(1, 100);

            return cod;
        }
    }
}
