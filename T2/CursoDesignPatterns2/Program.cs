using CursoDesignPatterns2.Cap1;
using CursoDesignPatterns2.Cap2;
using CursoDesignPatterns2.Cap4;
using CursoDesignPatterns2.Cap7;
using CursoDesignPatterns2.Cap8;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = "Caio";
            cliente.Endereco = "Rua Chapeco";
            cliente.DataDeNascimento = DateTime.Now;

            String xml = new GeradorXml().GeraXml(cliente);
            Console.WriteLine(xml);
            Console.ReadKey();
        }
    }
}
