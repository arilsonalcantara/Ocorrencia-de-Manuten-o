using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public override string ToString()
        {
            return this.CodigoLab.ToString();
        }

        public void RegistraOcorrencia(int Lab)
        {
            int ocorrencia = 0;
            Laboratório l = new Laboratório();

            XElement arquivo = XElement.Load(@"Laboratorio.xml");
            IEnumerable<XElement> pesquisa = from e in arquivo.Elements("Laboratorios")
                                             where (int)e.Attribute("Codigo") == Lab
                                             select e;

            foreach (XElement e in pesquisa)
            {
                 ocorrencia = int.Parse(e.Attribute("Ocorrencias").Value);

            }

            l.Ocorrencias = ++ocorrencia;

            XElement xml = XElement.Load("Laboratorio.xml");
            XElement x = xml.Elements().Where(p => p.Attribute("Codigo").Value.Equals(Lab.ToString())).First();
            if (x != null)
            {
                x.Attribute("Ocorrencias").SetValue(l.Ocorrencias);

            }
            xml.Save("Laboratorio.xml");
        }

        public void RemoveOcorrencia(int Lab)
        {
            int ocorrencia = 0;
            Laboratório l = new Laboratório();

            XElement arquivo = XElement.Load(@"Laboratorio.xml");
            IEnumerable<XElement> pesquisa = from e in arquivo.Elements("Laboratorios")
                                             where (int)e.Attribute("Codigo") == Lab
                                             select e;

            foreach (XElement e in pesquisa)
            {
                ocorrencia = int.Parse(e.Attribute("Ocorrencias").Value);

            }

            l.Ocorrencias = --ocorrencia;

            XElement xml = XElement.Load("Laboratorio.xml");
            XElement x = xml.Elements().Where(p => p.Attribute("Codigo").Value.Equals(Lab.ToString())).First();
            if (x != null)
            {
                x.Attribute("Ocorrencias").SetValue(l.Ocorrencias);

            }
            xml.Save("Laboratorio.xml");
        }

        public List<Laboratório> ListarPredios()
        {
            List<Laboratório> lab = new List<Laboratório>();
            try
            {
                XElement xml = XElement.Load("Laboratorio.xml");
                foreach (XElement x in xml.Elements())
                {
                    Laboratório l = new Laboratório()
                    {
                        CodigoLab = int.Parse(x.Attribute("Codigo").Value)
                    };
                    lab.Add(l);
                }
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
                FileStream Arquivo = new FileStream(@"Laboratorio.xml", FileMode.OpenOrCreate);
                Arquivo.Close();
            }

            catch (System.Xml.XmlException e)
            {
                MessageBox.Show(e.Message);

            }
            return lab;
        }

        
    }
}
