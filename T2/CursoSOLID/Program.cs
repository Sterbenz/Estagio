using CursoSOLID.Cap3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Compra compra = new Compra(500, "Sao Paulo");
            CalculadoraDePrecos calc = new CalculadoraDePrecos(new Frete(), new TabelaDePrecoPadrao());

            Console.WriteLine("Valor da compra: " + calc.Calcula(compra));
            Console.ReadKey();
        }
    }
}
