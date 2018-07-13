﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string rg;
        public string cpf; 
        public string endereco;
        public int idade;

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente() { }

        public bool ehMaiorDeIdade()
        {
            return this.idade >= 18;
        }
    }
}