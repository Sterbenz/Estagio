using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Moderado : Investimentos
    {
        private Random random;
        public Moderado()
        {
            this.random = new Random();
        }
        public double Investe(Orcamento orcamento)
        {
            if (random.Next(2) == 0)
                return orcamento.Valor * 0.025;
            else
                return orcamento.Valor * 0.007;
        }
    }
}
