using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            foreach(Item item1 in orcamento.Itens)
            {
                foreach (Item item2 in orcamento.Itens)
                {
                    if (item1.Nome.Equals("CANETA") && item2.Nome.Equals("LAPIS"))
                        return orcamento.Valor * 0.05;
                }
            }
            
            return Proximo.Desconta(orcamento);
        }
    }
}
