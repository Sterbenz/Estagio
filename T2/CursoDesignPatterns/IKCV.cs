using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class IKCV : TemplateDeImpostos
    {
        public IKCV(Impostos outroImposto) : base(outroImposto) { }
        public IKCV() : base() { }

        public override bool usarTaxaMaxima(Orcamento orcamento)
        {           
            return orcamento.Valor > 500 && ItemMaior100Reais(orcamento);
        }
        public override double TaxaMaxima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoOutroImposto(orcamento); 
        }       

        public override double TaxaMinima(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoOutroImposto(orcamento);
        }


        private bool ItemMaior100Reais(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100)
                    return true;                
            }
            return false;
        }
    }
}
