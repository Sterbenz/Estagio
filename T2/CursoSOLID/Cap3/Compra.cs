namespace CursoSOLID.Cap3
{
    public class Compra
    {
        public string Cidade { get; set; }
        public double Valor { get; set; }

        public Compra(double valor, string cidade)
        {
            this.Cidade = cidade;
            this.Valor = valor;
        }
    }
}