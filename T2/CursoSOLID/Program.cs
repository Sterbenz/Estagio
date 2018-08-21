using CursoSOLID.Cap3;
using CursoSOLID.Cap5;
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
            IList<ContaComum> contas = ContasDoBanco();

            foreach (ContaComum conta in contas)
            {
                conta.SomaInvestimento();

                Console.WriteLine("Novo saldo: " + conta.Saldo);
            }

            Console.ReadLine();
        }
        private static IList<ContaComum> ContasDoBanco()
        {
            List<ContaComum> contas = new List<ContaComum>();
            contas.Add(UmaContaComum(100));
            contas.Add(UmaContaComum(150));
            contas.Add(UmaContaEstudante(100));
            return contas;
        }

        private static ContaEstudante UmaContaEstudante(double saldo)
        {
            ContaEstudante conta = new ContaEstudante();
            conta.Deposita(saldo);
            return conta;
        }

        private static ContaComum UmaContaComum(double saldo)
        {
            ContaComum conta = new ContaComum();
            conta.Deposita(saldo);
            return conta;
        }
    }
}
