﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Item
    {

        public String Nome { get; set; }
        public double Valor { get; set; }

        public Item(String item, double valor)
        {
            this.Nome = item;
            this.Valor = valor;
        }

    }
}