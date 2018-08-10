using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Finalizado : EstadosDosOrcamentos
    {
        public void DescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Não é possivel receber descontos no estado de finalizado");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamentos finalizados não podem ser aprovados novamente");
        }


        public void Recusa(Orcamento orcamento)
        {
            throw new Exception("Orcamentos finalizados não podem ser recusados novamente");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
