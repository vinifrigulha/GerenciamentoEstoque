
using GerenciamentoEstoque.DataTransfer.Produtos.Request;
using GerenciamentoEstoque.DataTransfer.Produtos.Response;
using GerenciamentoEstoque.Dominio.Enumeradores;
using GerenciamentoEstoque.Dominio.Produtos;
using GerenciamentoEstoque.Dominio.Produtos.Enumeradores;
using GerenciamentoEstoque.Dominio.Produtos.Repositorios.Filtro;
using GerenciamentoEstoque.Dominio.Produtos.Servicos.Comandos;
using AutoMapper;

namespace GerenciamentoEstoque.Aplicacao.Produtos.Profiles
{
    public class ProdutosProfile : Profile
    {
        public ProdutosProfile()
        {
            CreateMap<Produto, ProdutoResponse>();
            CreateMap<ProdutoAlterarSituacaoRequest, ProdutoAlterarSituacaoComando>();
            CreateMap<ProdutoListarRequest, ProdutosListarFiltro>();
            CreateMap<ProdutoEditarRequest, ProdutosEditarComando>();
            CreateMap<ProdutoInserirRequest, ProdutosInstanciarComando>();
            CreateMap<ProdutoSituacaoEnum, EnumValue>().ConvertUsing(src => src.GetValue());
        }
    }
}
