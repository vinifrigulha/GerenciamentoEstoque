using GerenciamentoEstoque.Dominio.Excecoes;
using GerenciamentoEstoque.Dominio.Produtos.Enumeradores;


namespace GerenciamentoEstoque.Dominio.Produtos
{
    public class Produto
    {
        public virtual int Codigo { get; protected set; }
        public virtual string Descricao { get; protected set; }
        public virtual ProdutoSituacaoEnum Situacao { get; protected set; }
        public virtual decimal Preco { get; protected set; }
        public virtual decimal QtdEstoque { get; protected set; }
        public virtual string LocalizacaoEstoque { get; protected set; }
        public virtual decimal UnidadeVenda { get; protected set; }
        public virtual DateTime Validade { get; protected set; }

        protected Produto() { }

        public Produto(string descricao, decimal qtdEstoque, string localizacaoEstoque, decimal unidadeVenda, DateTime validade, decimal preco)
        {
            SetDescricao(descricao);
            SetSituacao(ProdutoSituacaoEnum.Ativo);
            SetQtdEstoque(qtdEstoque);
            SetLocalizacaoEstoque(localizacaoEstoque);
            SetUnidadeVenda(unidadeVenda);
            SetValidade(validade);
            SetPreco(preco);
        }

        public virtual void SetSituacao(ProdutoSituacaoEnum situacao)
        {
            Situacao = situacao;
        }

        public virtual void SetDescricao(string descricao)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                throw new AtributoObrigatorioExcecao("descricao");

            if (descricao.Length > 255)
                throw new TamanhoDeAtributoInvalidoExcecao("descricao", null, 255);

            Descricao = descricao;
        }

        public virtual void SetLocalizacaoEstoque(string localizacaoEstoque)
        {
                 if (string.IsNullOrWhiteSpace(localizacaoEstoque))
                throw new AtributoObrigatorioExcecao("localizacaoEstoque");

            if (localizacaoEstoque.Length > 255)
                throw new TamanhoDeAtributoInvalidoExcecao("localizacaoEstoque", null, 255);


            LocalizacaoEstoque = localizacaoEstoque;
        }

        public virtual void SetQtdEstoque(decimal qtdEstoque)
        {
            if (qtdEstoque < 0)
                throw new AtributoInvalidoExcecao("qtdEstoque");

            QtdEstoque = qtdEstoque;
        }

        public virtual void SetUnidadeVenda(decimal unidadeVenda)
        {
            if (unidadeVenda < 0)
                throw new AtributoInvalidoExcecao("unidadeVenda");

            UnidadeVenda = unidadeVenda;
        }

        public virtual void SetValidade(DateTime validade)
        {
        
            Validade = validade;
        }

        public virtual void SetPreco(decimal preco)
        {
            if (preco <= 0)
                throw new AtributoInvalidoExcecao("preco");

            Preco = preco;
        }
    }
}