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

            Impostos i = new ISS(new ImpostoMuitoAlto());
            Orcamento orcamento = new Orcamento(500);

            double valor = i.Calcula(orcamento);

            Console.WriteLine(valor);
            Console.ReadKey();

        }
    }
}