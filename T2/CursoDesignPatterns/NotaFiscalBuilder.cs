using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class NotaFiscalBuilder
    {
        private String RazaoSocial { get; set; }
        private String Cnpj { get; set; }
        private double ValorBruto { get; set; }
        public String Observacoes { get; set; }
        public DateTime Data { get; set; }
        private double Impostos { get; set; }
        private IList<ItemDaNotaFiscal> todosItens = new List<ItemDaNotaFiscal>();
        private IList<AcoesPosNotaFiscal> todasAcoes = new List<AcoesPosNotaFiscal>();
        public NotaFiscal Constroi()
        {
             NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, ValorBruto, Impostos, todosItens, Observacoes);

            foreach (AcoesPosNotaFiscal acao in todasAcoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        public void AdicionaAcao(AcoesPosNotaFiscal acao)
        {
            todasAcoes.Add(acao);
        }

        public NotaFiscalBuilder ParaEmpresas(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;

            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;

            return this;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;

            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNotaFiscal item)
        {
            todosItens.Add(item);
            ValorBruto += item.Valor;
            Impostos += item.Valor * 0.05;

            return this;
        }


    }
}
