using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoEstoque.DataTransfer.Produtos.Request
{
    public class ProdutoAlterarSituacaoRequest
    {
        public IList<int> IdProdutos { get; set; }
    }
}
