using System.Diagnostics.CodeAnalysis;
using GerenciamentoEstoque.Dominio.Genericos.Enumeradores;
using GerenciamentoEstoque.Dominio.Produtos.Enumeradores;
using GerenciamentoEstoque.Dominio.Util;

namespace GerenciamentoEstoque.Dominio.Produtos.Repositorios.Filtro
{
    [ExcludeFromCodeCoverage]
    public class ProdutosListarFiltro : PaginacaoFiltro
    {
        public ProdutosListarFiltro() : base(cpOrd:"Descricao", tpOrd:TipoOrdenacaoEnum.Asc)
        {
        }
        public int Codigo {get; set;}
        public  string Descricao { get;  set; }
        public  ProdutoSituacaoEnum? Situacao { get;  set; }
        public   decimal? Preco { get;  set; }
        public  decimal? QtdEstoque { get; set; }
        public  string LocalizacaoEstoque { get;  set; }
        public  decimal? UnidadeVenda { get;  set; }
        public  DateTime Validade { get;  set; }
        
    }
}
