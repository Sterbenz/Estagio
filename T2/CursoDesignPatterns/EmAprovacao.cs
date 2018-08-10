using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class EmAprovacao : EstadosDosOrcamentos
    {
        public bool descontoExtraAplicado = false;
        public void DescontoExtra(Orcamento orcamento)
        {
            if (descontoExtraAplicado) throw new Exception("Desconto já foi aplicado");
            else orcamento.Valor -= orcamento.Valor * 0.05;            
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }

        public void Recusa(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamentos em aprovação não podem ser finalizados direto");
        }
    }
}