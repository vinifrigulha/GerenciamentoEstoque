using GerenciamentoEstoque.Dominio.Produtos;
using GerenciamentoEstoque.Dominio.Produtos.Enumeradores;
using GerenciamentoEstoque.Dominio.Produtos.Servicos.Comandos;

namespace GerenciamentoEstoque.Dominio.Produtos.Servicos.Interfaces
{
    public interface IProdutosServico
    {
        Produto Validar(int codigo);

        Produto Inserir(ProdutosInstanciarComando comando);

        Produto Instanciar(ProdutosInstanciarComando comando);

        Produto Editar(int codigo, ProdutosEditarComando comando);
        
        void AlterarSituacaoProduto(ProdutoAlterarSituacaoComando comando, ProdutoSituacaoEnum situacao);
    }

}
