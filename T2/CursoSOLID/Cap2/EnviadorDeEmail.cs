using System;

namespace CursoSOLID.Cap2
{
    public class EnviadorDeEmail : IAcaoPosGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviando email");
        }
    }
}