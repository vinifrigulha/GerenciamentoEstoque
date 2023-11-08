
using GerenciamentoEstoque.Dominio.Genericos;
using GerenciamentoEstoque.Dominio.Genericos.Enumeradores;
using GerenciamentoEstoque.Dominio.Util;
using NHibernate;
using System.Linq.Dynamic.Core;


namespace GerenciamentoEstoque.Infra.Genericos
{
    public class GenericoRepositorio<T> : IGenericoRepositorio<T> where T : class
    {
        private readonly ISession session;

        public GenericoRepositorio(ISession session)
        {
            this.session = session;
        }
 
        public T Editar(T entidade)
        {
            session.Update(entidade);
            return entidade;
        }

        public void Excluir(T entidade)
        {
            session.Delete(entidade);
            
        }

        public T Inserir(T entidade)
        {
            session.Save(entidade);
            return entidade;
        }

        public PaginacaoConsulta<T> Listar(IQueryable<T> query, int qt, int pg, string cpOrd, TipoOrdenacaoEnum tpOrd)
        {
            try
            {
                query = query.OrderBy(cpOrd + " " + tpOrd.ToString());

                return Paginar(query, qt, pg);
            }
            catch{

                throw new ArgumentException("Campo de ordenação não informado");
            }
        }

        private static PaginacaoConsulta<T> Paginar(IQueryable<T> query, int qt, int pg)
        {
            return new PaginacaoConsulta<T>
            {
                Registros = query.Skip((pg -1 ) * qt).Take(qt).ToList(),
                Total = query.LongCount()
            };
        }

        public IQueryable<T> Query()
        {
            return session.Query<T>();
        }

        public T Recuperar(int id)
        {
            return session.Get<T>(id);
        }
    }
}