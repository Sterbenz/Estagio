namespace CursoSOLID
{
    public abstract class Cargo
    {

        public IDescontos RegraDesconto { get; private set; }


        public Cargo(IDescontos regraDesconto)
        {
            this.RegraDesconto = regraDesconto;            
        }
    }
}