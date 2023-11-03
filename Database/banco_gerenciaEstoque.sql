create database gerenciaEstoque;

use gerenciaEstoque;

create table funcionario(
    idFuncionario integer not null,
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
    idRequisicao integer not null,
    idProduto varchar(45),
    checado bool,
    primary key(idRequisicao,idProduto)
);

create table produto(
    idProduto integer not null,
    preco double,
    qtdEstoque integer,
    localizacaoEstoque integer,
    unidadeVenda varchar(20),
    validade date,
    primary key(idProduto)
);

create table cotacao(
    idCotacao integer not null,
    idComprador integer not null,
    finalizado bool,
    primary key(idCotacao, idComprador)
);

create table ordemCompra(
    idOrdemCompra integer primary key not null
);

create table pedido(
    idPedido integer not null,
    idCliente integer not null,
    finalizado bool,
    primary key(idPedido, idCliente)
);

create table ordemVenda(
    idOrdemVenda integer not null,
    idVendedor integer not null,
    primary key(idOrdemVenda, idVendedor)
);

create table produto(
    idProduto integer not null,
    preco double,
    quantidadeEstoque integer,
    localizacaoEstoque integer,
    unidadeVenda varchar(45),
    validade datetime,
    primary key(idProduto)
);

create table fornecedor(
    idFornecedor integer not null,
    nomeFornecedor varchar(45),
    primary key(idFornecedor)
);

create table cliente(
    idCliente integer not null,
    nome varchar(45),
    primary key(idCliente)
);

CREATE TABLE ProdutoReq (
    idRequisicao integer not null,
    idFuncionario integer not null,
    idCotacao integer not null,
    idProduto integer not null,
    foreign key (idRequisicao) references requisicao(idRequisicao),
    foreign key (idFuncionario) references funcionario(idFuncionario),
    foreign key (idCotacao) references cotacao(idCotacao),
    foreign key (idProduto) references produto(idProduto)
);

alter table requisicao
add constraint idFuncionario
foreign key (idFuncionario)
references funcionario(idFuncionario);

alter table requisicao
add constraint idCotacao
foreign key (idCotacao)
references cotacao(idCotacao);

alter table produto
add constraint idFuncionario
foreign key (idFuncionario)
references funcionario(idFuncionario);

alter table pedido
add constraint idFuncionario
foreign key (idFuncionario)
references funcionario(idFuncionario);

alter table pedido
add constraint idOrdemVenda
foreign key (idOrdemVenda)
references ordemVenda(idOrdemVenda);

alter table cliente
add constraint idFuncionario
foreign key (idFuncionario)
references funcionario(idFuncionario);

alter table cliente
add constraint idPedido
foreign key (idPedido)
references pedido(idPedido);

alter table cliente
add constraint idOrdemVenda
foreign key (idOrdemVenda)
references ordemVenda(idOrdemVenda);

/*
ALTER TABLE tabela_filha
ADD CONSTRAINT nome_da_chave_estrangeira
FOREIGN KEY (coluna_referencia)
REFERENCES tabela_pai(coluna_referenciada);

*/
