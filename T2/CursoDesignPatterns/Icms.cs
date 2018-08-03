using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class ICMS : Impostos
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + 50.0;
        }
    }
}
