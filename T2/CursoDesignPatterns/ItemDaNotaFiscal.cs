using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class ItemDaNotaFiscal
    {
        public String Nome { get; set; }
        public Double Valor { get; set; }

        public ItemDaNotaFiscal(String nome, Double valor)
        {
            this.Nome = nome;
            this.Valor = valor;
        }
    }
}
