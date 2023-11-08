namespace GerenciamentoEstoque.Aplicacao.Transacoes.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTransaction();
        void Commit();
        void Rollback();

        
    }
}