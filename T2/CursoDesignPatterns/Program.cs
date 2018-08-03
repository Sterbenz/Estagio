using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Program
    {
        

        static void Main(string[] args)
        {
            

        Impostos iss = new ISS();
        Impostos icms = new ICMS();
        Impostos iccc = new ICCC();
        Orcamento orcamento = new Orcamento(500.00);
        Orcamento orcamento2 = new Orcamento(1500.00);
        Orcamento orcamento3 = new Orcamento(3500.00);

        CalculadorDeImpostos calcula = new CalculadorDeImpostos();

       
        }
    }
}