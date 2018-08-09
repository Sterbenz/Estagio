using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ICPP : TemplateDeImpostos
    {
        public ICPP(Impostos outroImposto) : base(outroImposto) { }

        public ICPP() : base() { }

        public override bool usarTaxaMaxima(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }
        public override double TaxaMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07 + CalculoOutroImposto(orcamento);
        }
        public override double TaxaMinima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + CalculoOutroImposto(orcamento);
        }
    }
}
