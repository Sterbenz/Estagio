using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap7
{
    class Pedido
    {
        public string Cliente { get; private set; }

        public double Valor { get; private set; }

        public DateTime DataFinal { get; private set; }


        public Status Status { get; private set; }


        public Pedido(string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Status = Status.Novo;
        }

        public void Paga()
        {
            this.Status = Status.Pago;
        }

        public void Finalizado()
        {
            this.Status = Status.Entregue;
            this.DataFinal = DateTime.Now;
        }
    }
}
