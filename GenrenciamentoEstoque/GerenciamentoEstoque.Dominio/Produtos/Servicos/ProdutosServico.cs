using GerenciamentoEstoque.Dominio.Excecoes;
using GerenciamentoEstoque.Dominio.Produtos;
using GerenciamentoEstoque.Dominio.Produtos.Enumeradores;
using GerenciamentoEstoque.Dominio.Produtos.Repositorios;
using GerenciamentoEstoque.Dominio.Produtos.Servicos.Comandos;
using GerenciamentoEstoque.Dominio.Produtos.Servicos.Interfaces;

namespace GerenciamentoEstoque.Dominio.Produtos.Servicos
{
    public class ProdutosServico : IProdutosServico
    {
        private readonly IProdutosRepositorio produtosRepositorio;

        public ProdutosServico(IProdutosRepositorio produtosRepositorio)
        {
            this.produtosRepositorio = produtosRepositorio;
        }

        public void AlterarSituacaoProduto(ProdutoAlterarSituacaoComando comando, ProdutoSituacaoEnum situacao)
        {
            foreach(var IdProduto in comando.IdProdutos)
            {
                var produto = Validar(IdProduto);
                produto.SetSituacao(situacao);
                produtosRepositorio.Editar(produto);
            }
        }

        public Produto Editar(int codigo, ProdutosEditarComando comando)
        {
            Produto produto = Validar(codigo);
            produto.SetDescricao(comando.Descricao);
            produto.SetPreco(comando.Preco);
            produto.SetQtdEstoque(comando.QtdEstoque);
            produto.SetLocalizacaoEstoque(comando.LocalizacaoEstoque);
            produto.SetUnidadeVenda(comando.UnidadeVenda);
            produto.SetValidade(comando.Validade);
            produto.SetSituacao(comando.Situacao);

            return produto = produtosRepositorio.Editar(produto);
        }
    
        public Produto Inserir(ProdutosInstanciarComando comando)
        {
            Produto produto = Instanciar(comando);
            return produtosRepositorio.Inserir(produto);
        }


        public Produto Instanciar(ProdutosInstanciarComando comando)
        {
            return new Produto(comando.Descricao, comando.QtdEstoque, comando.LocalizacaoEstoque, comando.UnidadeVenda, comando.Validade, comando.Preco);
        }

        public Produto Validar(int codigo)
        {
            Produto produto = produtosRepositorio.Recuperar(codigo);
            if (produto == null)
                throw new RegraDeNegocioExcecao("Produto não encontrado");
            
            return produto;
        }
    }
}
