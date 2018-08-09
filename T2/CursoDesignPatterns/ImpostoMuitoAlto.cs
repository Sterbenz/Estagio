using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class ImpostoMuitoAlto : Impostos
    {
        public ImpostoMuitoAlto(Impostos outroImposto) : base(outroImposto) { }
        public ImpostoMuitoAlto() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoOutroImposto(orcamento);
        }
    }
}
