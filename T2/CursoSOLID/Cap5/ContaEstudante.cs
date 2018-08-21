using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSOLID.Cap5
{
    class ContaEstudante : ContaComum
    {
        private ManipuladorDeSaldo m;
        public int Milhas { get; private set; }

        public ContaEstudante()
        {
            m = new ManipuladorDeSaldo();
        }
        public void Deposita(double valor)
        {
            m.Deposita(valor);
            this.Milhas += (int)valor;
        }
    }
}
