﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }
        public EstadosDosOrcamentos EstadoAtual { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
        }

        public void Deposita(double valor)
        {
            this.Valor += valor;
        }

        public void AdicionaItens(Item item)
        {
            Itens.Add(item);
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.DescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }


        public void Recusa()
        {
            EstadoAtual.Recusa(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
