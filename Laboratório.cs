using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        private int _Ocorrencias;

        public int Ocorrencias
        {
            get { return _Ocorrencias; }
            set { _Ocorrencias = value; }
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
            Ocorrencias = 0;
        }

        public List<Laboratório> ListarPredios()
        {
            List<Laboratório> predios = new List<Laboratório>();
            XElement xml = XElement.Load("Laboratorios.xml");
            foreach (XElement x in xml.Elements())
            {
                Laboratório l = new Laboratório()
                {
                    Prédio = int.Parse(x.Attribute("Predio").Value)
                };
                predios.Add(l);
            }
            return predios;
        }

        public List<Laboratório> ListarLab(string predio)
        {
            List<Laboratório> lab = new List<Laboratório>();
            XElement xml = XElement.Load("Laboratorios.xml");
            IEnumerable<XElement> pesquisa = from e in xml.Elements("Laboratorios")
                                             where (string)e.Attribute("Predios") == predio
                                             select e;
            foreach (XElement e in xml.Elements())
            {
                Laboratório l = new Laboratório()
                {
                    CodigoLab = int.Parse(e.Attribute("Laboratorio").Value)
                };
                lab.Add(l);
            }
            return lab;
        }
    }
}
