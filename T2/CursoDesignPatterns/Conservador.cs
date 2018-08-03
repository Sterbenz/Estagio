using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Conservador : Investimentos
    {
        public double Investe(Orcamento orcamento)
        {
            return orcamento.Valor * 0.08;
        }

    }
}
