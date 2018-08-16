using CursoDesignPatterns2.Cap1;
using CursoDesignPatterns2.Cap2;
using CursoDesignPatterns2.Cap4;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpressao esquerda = new Subtracao(new Numero(10), new Numero(1));
            IExpressao direita = new Soma(new Numero(10), new Numero(0));

            IExpressao conta = new Multiplicacao(esquerda, direita);
            IExpressao conta2 = new RaizQuadrada(esquerda);

            int resultado = conta.Avalia();
            int res = conta2.Avalia();
            Console.WriteLine(resultado);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
