using GerenciamentoEstoque.DataTransfer.Produtos.Request;
using GerenciamentoEstoque.DataTransfer.Produtos.Response;
using GerenciamentoEstoque.Dominio.Produtos.Enumeradores;
using GerenciamentoEstoque.Dominio.Util;

namespace GerenciamentoEstoque.Aplicacao.Produtos.Servicos.Interfaces;

public interface IProdutosAppServico
{
    PaginacaoConsulta<ProdutoResponse> Listar(ProdutoListarRequest request);
    ProdutoResponse Recuperar(int codigo);
    ProdutoResponse Inserir(ProdutoInserirRequest request);
    ProdutoResponse Editar(int codigo, ProdutoEditarRequest request);
    public void AlterarSituacaoProduto(ProdutoAlterarSituacaoRequest request, ProdutoSituacaoEnum situacao);
    void Excluir(int codigo);
     
}
