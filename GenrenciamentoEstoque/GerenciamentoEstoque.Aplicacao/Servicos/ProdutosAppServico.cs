using GerenciamentoEstoque.Aplicacao.Produtos.Servicos.Interfaces;
using GerenciamentoEstoque.Aplicacao.Transacoes.Interfaces;
using GerenciamentoEstoque.DataTransfer.Produtos.Request;
using GerenciamentoEstoque.DataTransfer.Produtos.Response;
using GerenciamentoEstoque.Dominio.Produtos;
using GerenciamentoEstoque.Dominio.Produtos.Enumeradores;
using GerenciamentoEstoque.Dominio.Produtos.Repositorios;
using GerenciamentoEstoque.Dominio.Produtos.Repositorios.Filtro;
using GerenciamentoEstoque.Dominio.Produtos.Servicos.Comandos;
using GerenciamentoEstoque.Dominio.Produtos.Servicos.Interfaces;
using GerenciamentoEstoque.Dominio.Util;
using AutoMapper;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace GerenciamentoEstoque.Aplicacao.Produtos.Servicos
{
    public class ProdutosAppServico : IProdutosAppServico
    {
        private readonly IProdutosServico produtosServico;
        private readonly IMapper mapper;
        private readonly IProdutosRepositorio produtosRepositorio;
        private readonly IUnitOfWork unitOfWork;

        public ProdutosAppServico(IProdutosServico produtosServico, IMapper mapper, IProdutosRepositorio produtosRepositorio, IUnitOfWork unitOfWork)
        {
            this.produtosServico = produtosServico;
            this.mapper = mapper;
            this.produtosRepositorio = produtosRepositorio;
            this.unitOfWork = unitOfWork;
        }

        public ProdutoResponse Editar(int codigo, ProdutoEditarRequest request)
        {
            var comando = mapper.Map<ProdutosEditarComando>(request);

            try
            {
                unitOfWork.BeginTransaction();

                Produto produto = produtosServico.Editar(codigo, comando);

                unitOfWork.Commit();

                return mapper.Map<ProdutoResponse>(produto);
            }
            catch
            {
                unitOfWork.Rollback();
                throw;
            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                unitOfWork.BeginTransaction();
                Produto produto = produtosServico.Validar(codigo);
                produtosRepositorio.Excluir(produto);
                unitOfWork.Commit();
            }
            catch
            {
                unitOfWork.Rollback();
                throw;
            }
        }
        public ProdutoResponse Inserir(ProdutoInserirRequest request)
        {
            var comando = mapper.Map<ProdutosInstanciarComando>(request);
            try
            {
                unitOfWork.BeginTransaction();

                Produto produto = produtosServico.Inserir(comando);

                unitOfWork.Commit();

                return mapper.Map<ProdutoResponse>(produto);
            }
            catch
            {
                unitOfWork.BeginTransaction();
                throw;
            }
        }

        public PaginacaoConsulta<ProdutoResponse> Listar(ProdutoListarRequest request)
        {
            ProdutosListarFiltro filtros = mapper.Map<ProdutosListarFiltro>(request);

            IQueryable<Produto> query = produtosRepositorio.Filtrar(filtros);

            PaginacaoConsulta<Produto> produtos = produtosRepositorio.Listar(query, request.Qt, request.Pg, request.CpOrd, request.TpOrd);

            PaginacaoConsulta<ProdutoResponse> response;

            response = mapper.Map<PaginacaoConsulta<ProdutoResponse>>(produtos);

            return response;
        }

        public ProdutoResponse Recuperar(int codigo)
        {
            try
            {
                unitOfWork.BeginTransaction();

                Produto produto = produtosServico.Validar(codigo);

                return mapper.Map<ProdutoResponse>(produto);

            }
            catch
            {
                unitOfWork.Rollback();

                throw;
            }
        }

        
        public void AlterarSituacaoProduto(ProdutoAlterarSituacaoRequest request, ProdutoSituacaoEnum situacao)
        {
            var comando = mapper.Map<ProdutoAlterarSituacaoComando>(request);
            try
            {
                unitOfWork.BeginTransaction();
                produtosServico.AlterarSituacaoProduto(comando, situacao);
                unitOfWork.Commit();
            }
            catch 
            {
                unitOfWork.Rollback();
                throw;
            }
        }
    }
}
