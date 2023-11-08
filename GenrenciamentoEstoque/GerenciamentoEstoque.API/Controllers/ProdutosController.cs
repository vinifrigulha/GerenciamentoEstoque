using GerenciamentoEstoque.Aplicacao.Produtos.Servicos.Interfaces;
using GerenciamentoEstoque.DataTransfer.Produtos.Request;
using GerenciamentoEstoque.DataTransfer.Produtos.Response;
using GerenciamentoEstoque.Dominio.Produtos.Enumeradores;
using GerenciamentoEstoque.Dominio.Util;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoEstoque.API.Controllers.Produtos
{
    [ApiController]
    [Route("api/produtos")]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutosAppServico produtosAppServico;

        public ProdutosController(IProdutosAppServico produtosAppServico)
        {
            this.produtosAppServico = produtosAppServico;
        }

        ///<summary>
        /// Recuperar  produto por codigo.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpGet("{codigo}")]
        public ActionResult<ProdutoResponse> Recuperar(int codigo)
        {
            var response = produtosAppServico.Recuperar(codigo);
           
            return Ok(response);
        }


        /// <summary>
        /// Recuperar  produtos paginados.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<PaginacaoConsulta<ProdutoResponse>> Listar([FromQuery] ProdutoListarRequest request)
        {
            var response = produtosAppServico.Listar(request);
            return Ok(response);
        }

        ///<summary>
        /// Criar  produto.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<ProdutoResponse> Inserir ([FromBody] ProdutoInserirRequest request)
        {
            var response = produtosAppServico.Inserir(request);
            return Ok(response);
        }

        ///<summary>
        /// Editar  produto por codigo.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("{codigo}")]
        public ActionResult Editar(int codigo, [FromBody] ProdutoEditarRequest request)
        {
            produtosAppServico.Editar(codigo, request);
            return Ok();
        }

        ///<summary>
        /// Excluir produto por codigo.
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        [HttpDelete("{codigo}")]
        public ActionResult Excluir(int codigo)
        {
            produtosAppServico.Excluir(codigo);
            return Ok();
        }


        /// <summary>
        /// Altera a situacao de um ou mais produtos
        /// </summary>
        /// <param name="situacao"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("{situacao}")]
        public ActionResult AlterarSituacao(ProdutoSituacaoEnum situacao, [FromBody]ProdutoAlterarSituacaoRequest request)
        {
            produtosAppServico.AlterarSituacaoProduto(request, situacao);
            return Ok();
        }
    }
}
