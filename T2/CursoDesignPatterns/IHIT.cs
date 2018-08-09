using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class IHIT : Impostos
    {
        public IHIT(Impostos outroImposto) : base(outroImposto) { }
        public IHIT() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            foreach (Item item1 in orcamento.Itens)
            {
                foreach (Item item2 in orcamento.Itens)
                {
                    if (item1.Nome.Equals(item2.Nome))
                        return orcamento.Valor * 0.13 + 100 + CalculoOutroImposto(orcamento);
                }
            }

            return orcamento.Valor * (0.01 * orcamento.Itens.Count) + CalculoOutroImposto(orcamento);
        }
    }
}
