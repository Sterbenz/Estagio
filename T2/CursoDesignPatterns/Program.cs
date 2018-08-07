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

            CalculadorDeDesconto calculador = new CalculadorDeDesconto();

            Orcamento orcamento = new Orcamento(500.0);
            orcamento.AdicionaItens(new Item("CANETA", 250.0));
            orcamento.AdicionaItens(new Item("LAPIS", 250.0));
            
            double desconto = calculador.CalculaDesconto(orcamento);

            Console.WriteLine(desconto);
            Console.ReadKey();

        }
    }
}