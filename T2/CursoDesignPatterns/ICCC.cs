using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class ICCC : Impostos

    {
        public ICCC(Impostos outroImposto) : base(outroImposto) { }
        public ICCC() : base() { }

        public override  double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor<=1000.0)
            {
                return orcamento.Valor * 0.05 + CalculoOutroImposto(orcamento);
            }

            else if (orcamento.Valor > 1000.0 && orcamento.Valor<=3000.0)
            {
                return orcamento.Valor * 0.07 + CalculoOutroImposto(orcamento);
            }
            else if (orcamento.Valor > 3000.0)
            {
                return orcamento.Valor * 0.08 + 30 + CalculoOutroImposto(orcamento);
            }
            return orcamento.Valor;
        }
    }
}
