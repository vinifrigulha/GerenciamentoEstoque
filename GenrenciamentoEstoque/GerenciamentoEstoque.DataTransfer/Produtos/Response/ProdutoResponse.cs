
using GerenciamentoEstoque.Dominio.Enumeradores;

namespace GerenciamentoEstoque.DataTransfer.Produtos.Response
{
    public class ProdutoResponse
    {
        public int Codigo {get; set;}
        public  string Descricao { get;  set; }
        public  EnumValue Situacao { get;  set; }
        public   decimal Preco { get;  set; }
        public   DateTime Validade { get;  set; }
        public  decimal QtdEstoque { get; set; }
        public  decimal UnidadeVenda { get;  set; }
        public  string LocalizacaoEstoque { get;  set; }
    }
}