using CursoDesignPatterns2.Cap1;
using CursoDesignPatterns2.Cap2;
using CursoDesignPatterns2.Cap4;
using CursoDesignPatterns2.Cap6;
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
            IEnvia enviador = new EnviaPorEmail();
            IMensagem mensagem = new MensagemParaAdministracao("victor");
            mensagem.Enviador = enviador;

            mensagem.Envia();
        }
    }
}
