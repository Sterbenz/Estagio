using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class ICMS : Impostos
    {
        public ICMS(Impostos outroImposto) : base(outroImposto) { }
        public ICMS() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoOutroImposto(orcamento);
        }
    }
}
