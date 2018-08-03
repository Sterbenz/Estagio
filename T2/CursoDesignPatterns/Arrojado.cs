using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Arrojado : Investimentos
    {
        private Random random;

        public Arrojado()
        {
            this.random = new Random();
        }
        public double Investe(Orcamento orcamento)
        {
            int chute = random.Next(10);
            if (chute >= 0 && chute <= 1) return orcamento.Valor * 0.5;
            else if (chute >= 2 && chute <= 4) return orcamento.Valor * 0.3;
            else return orcamento.Valor * 0.006;
        }
    }
}
