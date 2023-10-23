create database gerenciaEstoque;

use gerenciaEstoque;

create table funcionario(
    idFuncionario integer,
    nome varchar(45),
    cpf char(11),
    email varchar(45),
    senha varchar(45),
    telefone varchar(45),
    endereco varchar(45),
    tipoFuncionario char(1),
    primary key(idFuncionario)
);

create table requisicao(
    idRequisicao integer,
    idProduto varchar(45),
    checado bool,
    primary key(idRequisicao,idProduto)
);

create table produto(
    idProduto integer,
    preco double,
    qtdEstoque integer,
    localizacaoEstoque integer,
    unidadeVenda varchar(20),
    validade date,
    primary key(idProduto)
);

create table cotacao(
    idCotacao integer,
    idComprador integer,
    finalizado bool,
    primary key(idCotacao, idComprador)
);

create table ordemCompra(
    idOrdemCompra integer primary key
);

create table pedido(
    idPedido integer,
    idCliente integer,
    finalizado bool,
    primary key(idPedido, idCliente)
);

create table ordemVenda(
    idOrdemVenda integer,
    idVendedor integer,
    primary key(idOrdemVenda, idVendedor)
);

create table produto(
    idProduto integer ,
    preco double,
    quantidadeEstoque integer,
    localizacaoEstoque integer,
    unidadeVenda string,
    validade datetime,
    primary key(idProduto)
);

create table fornecedor(
    idFornecedor integer,
    nomeFornecedor string,
    primary key(idFornecedor)
);

create table cliente(
    idCliente integer,
    nome string,
    primary key(idCliente)
);
