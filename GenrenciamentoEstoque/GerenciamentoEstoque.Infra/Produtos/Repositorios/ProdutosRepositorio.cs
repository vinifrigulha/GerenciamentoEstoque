
using GerenciamentoEstoque.Dominio.Produtos;
using GerenciamentoEstoque.Dominio.Produtos.Repositorios;
using GerenciamentoEstoque.Dominio.Produtos.Repositorios.Filtro;
using GerenciamentoEstoque.Infra.Genericos;
using NHibernate;

namespace GerenciamentoEstoque.Infra.Produtos.Repositorios
{
    public class ProdutosRepositorio : GenericoRepositorio<Produto>, IProdutosRepositorio
    {
        public ProdutosRepositorio(ISession session) : base(session)
        {
        }

        public IQueryable<Produto> Filtrar(ProdutosListarFiltro filtro)
        {
            IQueryable<Produto> query = Query();

            if (filtro.Codigo != 0)
            {
                query = query.Where(p => p.Codigo == filtro.Codigo);
            }

            if (!string.IsNullOrEmpty(filtro.Descricao))
            {
                query = query.Where(p => p.Descricao.Contains(filtro.Descricao));
            }

            if (!string.IsNullOrEmpty(filtro.LocalizacaoEstoque))
            {
                query = query.Where(p => p.LocalizacaoEstoque.Contains(filtro.LocalizacaoEstoque));
            }

            if (filtro.Preco.HasValue)
            {
                query = query.Where(p => p.Preco == filtro.Preco.Value);
            }

            if (filtro.QtdEstoque.HasValue)
            {
                query = query.Where(p => p.QtdEstoque == filtro.QtdEstoque.Value);
            }

            if (filtro.UnidadeVenda.HasValue)
            {
                query = query.Where(p => p.UnidadeVenda == filtro.UnidadeVenda.Value);
            }

            if (filtro.Situacao.HasValue)
            {
                query = query.Where(p => p.Situacao == filtro.Situacao.Value);
            }

            return query;
        }
    }
}