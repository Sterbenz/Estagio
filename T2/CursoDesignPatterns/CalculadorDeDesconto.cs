using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class CalculadorDeDesconto
    {

        public double CalculaDesconto(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoMaisDe5Itens();
            IDesconto d2 = new DescontoCompraMaiorQue500Reais();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto semDesconto = new SemDesconto();
            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = semDesconto;

            return d1.Desconta(orcamento);
        }
       

    }
}
