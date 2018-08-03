using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class RealizadorDeInvestimentos
    {
        public void RealizaCalculoInvestimento(Orcamento orcamento, Investimentos investimento)
        {
            double inv = investimento.Investe(orcamento);
            orcamento.Deposita(inv * 0.75);
            Console.WriteLine ( "Novo saldo: " + orcamento.Valor);
        }
    }
}