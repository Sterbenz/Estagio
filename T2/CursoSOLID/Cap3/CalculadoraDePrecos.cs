using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoSOLID.Cap3
{
    class CalculadoraDePrecos
    {
        private IServicoEntrega entrega;
        private ITabelasDeDescontos tabela;

        public CalculadoraDePrecos(IServicoEntrega entrega, ITabelasDeDescontos desconto)
        {
            this.entrega = entrega;
            this.tabela = desconto;
        }
        public double Calcula(Compra produto)
        {            

            double desconto = tabela.Desconto(produto.Valor);
            double frete = entrega.EntregaPara(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }
    }
}
