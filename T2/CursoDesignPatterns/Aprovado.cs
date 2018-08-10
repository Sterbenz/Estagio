using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Aprovado : EstadosDosOrcamentos
    {
        private bool descontoExtraAplicado = false;
        public void DescontoExtra(Orcamento orcamento)
        {
            if (descontoExtraAplicado) throw new Exception("Desconto já foi aplicado");
            else orcamento.Valor -= orcamento.Valor * 0.02; 
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamentos aprovados não podem ser aprovados novamente");
        }


        public void Recusa(Orcamento orcamento)
        {
            throw new Exception("Orcamentos Aprovados não podem mais ser recusados");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
