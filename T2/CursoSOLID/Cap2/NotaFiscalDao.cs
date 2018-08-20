using System;

namespace CursoSOLID.Cap2
{
    public class NotaFiscalDao : IAcaoPosGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Persistindo nota");
        }
    }
}