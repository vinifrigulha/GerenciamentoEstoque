using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciamentoEstoque.Dominio.Produtos.Enumeradores;

namespace GerenciamentoEstoque.DataTransfer.Produtos.Request
{
    public class ProdutoEditarRequest
    {       
         public  string Descricao { get;  set; }
        public  ProdutoSituacaoEnum Situacao { get;  set; }
        public   decimal Preco { get;  set; }
        public   DateTime Validade { get;  set; }
        public  decimal QtdEstoque { get; set; }
        public  decimal UnidadeVenda { get;  set; }
        public  string LocalizacaoEstoque { get;  set; }
        
    }
}