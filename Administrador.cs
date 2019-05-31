using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocorrencia_de_Manutenção
{
    public class Administrador:Usuarios
    {
        public void AlteraOcorrencia()
        {

        }

        public override void GeraCodigo()
        {
            base.GeraCodigo();
        }

        public override void ListaOcorrencia()
        {
            throw new NotImplementedException();
        }
    }
}
