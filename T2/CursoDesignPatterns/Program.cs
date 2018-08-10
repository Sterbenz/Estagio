using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Program
    {

        static void Main(string[] args)
        {

            NotaFiscalBuilder criador = new NotaFiscalBuilder()
                .ParaEmpresas("Caelum")
                .ComCnpj("123.456.789/0001-10")
                .ComItem(new ItemDaNotaFiscal("item 1", 100.0))
                .ComItem(new ItemDaNotaFiscal("item 2", 200.0))
                //.ComItem(new ItemDaNotaFiscal("item 3", 300.0))
                .ComObservacoes("entregar nf pessoalmente")
                .NaDataAtual();

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);
            Console.ReadKey();

        }
    }
}