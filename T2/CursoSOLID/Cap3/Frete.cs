namespace CursoSOLID.Cap3
{
    public class Frete : IServicoEntrega
    {
        public double EntregaPara(string cidade)
        {

            if ("SAO PAULO".Equals(cidade.ToUpper()))
            {
                return 15;
            }
            return 30;
        }
    }
}