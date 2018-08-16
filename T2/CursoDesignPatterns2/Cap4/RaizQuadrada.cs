using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap4
{
    class RaizQuadrada : IExpressao
    {
        public IExpressao Numero { get; set; }       

        public RaizQuadrada(IExpressao numero)
        {
            this.Numero = numero;
            
        }

        public int Avalia()
        {
            int valorNumero = Numero.Avalia();            
            return (int) Math.Sqrt(valorNumero);
        }


    }
}
