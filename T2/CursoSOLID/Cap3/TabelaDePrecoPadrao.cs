namespace CursoSOLID.Cap3
{
    public class TabelaDePrecoPadrao : ITabelasDeDescontos
    {
        public double Desconto(double valor)
        {
            if (valor > 5000) return 0.05;
            if (valor > 1000) return 0.05;
            return 0;
        }
    }
}