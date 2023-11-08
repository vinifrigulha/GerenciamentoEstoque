
using GerenciamentoEstoque.Dominio.Genericos;
using GerenciamentoEstoque.Dominio.Produtos;
using GerenciamentoEstoque.Dominio.Produtos.Repositorios.Filtro;

namespace GerenciamentoEstoque.Dominio.Produtos.Repositorios
{
    public interface IProdutosRepositorio : IGenericoRepositorio<Produto>
    {
        IQueryable<Produto> Filtrar(ProdutosListarFiltro filtro);
    }
}