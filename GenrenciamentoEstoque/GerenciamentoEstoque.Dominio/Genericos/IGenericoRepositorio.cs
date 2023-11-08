
using GerenciamentoEstoque.Dominio.Genericos.Enumeradores;
using GerenciamentoEstoque.Dominio.Util;

namespace GerenciamentoEstoque.Dominio.Genericos
{
    public interface IGenericoRepositorio<T> where T: class
    {
        T Recuperar(int codigo);

        T Inserir(T entidade);

        T Editar(T entidade);

        void Excluir(T entidade);

        PaginacaoConsulta<T> Listar(IQueryable<T> query, int qt, int pg,string cpOrd,TipoOrdenacaoEnum tpOrd);
        IQueryable<T> Query();
    }
}