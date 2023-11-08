
using GerenciamentoEstoque.Dominio.Produtos;
using GerenciamentoEstoque.Dominio.Produtos.Enumeradores;
using FluentNHibernate.Mapping;
using NHibernate.Type;

namespace GerenciamentoEstoque.Infra.Produtos.Mapeamentos
{
    public class ProdutosMap : ClassMap<Produto>
    {
        public ProdutosMap()
        {
            Schema("gerenciaEstoque");
            Table("produto");
            Id(produto => produto.Codigo).Column("idProduto");
            Map(produto => produto.Descricao).Column("descricao");
            Map(produto => produto.Preco).Column("preco");
            Map(produto => produto.QtdEstoque).Column("qtdEstoque");
            Map(produto => produto.LocalizacaoEstoque).Column("localizacaoEstoque");
            Map(produto => produto.UnidadeVenda).Column("unidadeVenda");
            Map(produto => produto.Validade).Column("validade");
            // Map(produto => produto.Situacao).Column("situacao").CustomType<EnumType<ProdutoSituacaoEnum>>();

        }
    }
}

// create table produto(
//     idProduto integer,
//     preco double,
//     qtdEstoque integer,
//     localizacaoEstoque integer,
//     unidadeVenda varchar(20),
//     validade date,
//     primary key(idProduto)
// );
