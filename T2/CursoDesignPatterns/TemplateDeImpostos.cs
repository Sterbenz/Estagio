using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public abstract class TemplateDeImpostos : Impostos
    {
        public TemplateDeImpostos(Impostos outroImposto) : base(outroImposto) { }
        public TemplateDeImpostos() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            if (usarTaxaMaxima(orcamento))
            {
                return TaxaMaxima(orcamento);
            }
            else
            {
                return TaxaMinima(orcamento);
            }           

        }
        public abstract bool usarTaxaMaxima(Orcamento orcamento);
        public abstract double TaxaMaxima(Orcamento orcamento);
        public abstract double TaxaMinima(Orcamento orcamento);
    }
}