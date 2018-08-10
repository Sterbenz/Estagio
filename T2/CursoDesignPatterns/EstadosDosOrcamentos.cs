namespace CursoDesignPatterns
{
    public interface EstadosDosOrcamentos
    {
        void DescontoExtra(Orcamento orcamento);

        void Aprova(Orcamento orcamento);
        void Recusa(Orcamento orcamento);
        void Finaliza(Orcamento orcamento);

    }
}