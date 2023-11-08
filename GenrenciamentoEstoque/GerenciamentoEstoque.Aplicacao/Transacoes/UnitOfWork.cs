
using GerenciamentoEstoque.Aplicacao.Transacoes.Interfaces;
using NHibernate;

namespace GerenciamentoEstoque.Aplicacao.Transacoes
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ISession session;
        private ITransaction transaction;
        public UnitOfWork(ISession session)
        {
            this.session = session;
        }
         
        public void BeginTransaction()
        {
            this.transaction = session.BeginTransaction();
        }

        public void Commit()
        {
            if(transaction != null && transaction.IsActive)
            transaction.Commit();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            if(transaction != null && transaction.IsActive)
            transaction.Rollback();
            
        }
    }
}