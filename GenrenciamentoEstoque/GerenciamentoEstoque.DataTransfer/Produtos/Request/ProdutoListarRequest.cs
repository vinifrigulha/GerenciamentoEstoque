
using GerenciamentoEstoque.Dominio.Genericos.Enumeradores;
using GerenciamentoEstoque.Dominio.Produtos.Enumeradores;
using GerenciamentoEstoque.Dominio.Util;

namespace GerenciamentoEstoque.DataTransfer.Produtos.Request
{
    public class ProdutoListarRequest : PaginacaoFiltro
    {
        public ProdutoListarRequest() : base(cpOrd:"Descricao", tpOrd:TipoOrdenacaoEnum.Asc)
        {
        }
        public int Codigo {get; set;}
        public  string Descricao { get;  set; }
        public  ProdutoSituacaoEnum Situacao { get;  set; }
        public   decimal Preco { get;  set; }
        public   DateTime Validade { get;  set; }
        public  decimal QtdEstoque { get; set; }
        public  decimal UnidadeVenda { get;  set; }
        public  string LocalizacaoEstoque { get;  set; }
        
    }
}