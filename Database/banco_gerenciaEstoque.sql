CREATE DATABASE gerenciaEstoque;

USE gerenciaEstoque;

CREATE TABLE funcionario (
    idFuncionario INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(45),
    cpf CHAR(11),
    email VARCHAR(45),
    senha VARCHAR(45),
    telefone VARCHAR(45),
    endereco VARCHAR(45),
    tipoFuncionario CHAR(1)
);

CREATE TABLE requisicao (
    idRequisicao INT AUTO_INCREMENT,
    idProduto VARCHAR(45),
    checado BOOL,
    PRIMARY KEY(idRequisicao, idProduto)
);

CREATE TABLE produto (
    idProduto INT AUTO_INCREMENT PRIMARY KEY,
    preco DOUBLE,
    descricao VARCHAR(100),
    qtdEstoque INT,
    localizacaoEstoque VARCHAR(200),
    unidadeVenda VARCHAR(20),
    validade DATE
);

CREATE TABLE cotacao (
    idCotacao INT AUTO_INCREMENT,
    idComprador INT,
    finalizado BOOL,
    PRIMARY KEY(idCotacao, idComprador)
);

CREATE TABLE ordemCompra (
    idOrdemCompra INT AUTO_INCREMENT PRIMARY KEY
);

CREATE TABLE pedido (
    idPedido INT AUTO_INCREMENT,
    idCliente INT,
    finalizado BOOL,
    PRIMARY KEY(idPedido, idCliente)
);

CREATE TABLE ordemVenda (
    idOrdemVenda INT AUTO_INCREMENT,
    idVendedor INT,
    PRIMARY KEY(idOrdemVenda, idVendedor)
);

CREATE TABLE fornecedor (
    idFornecedor INT AUTO_INCREMENT PRIMARY KEY,
    nomeFornecedor VARCHAR(100)
);

CREATE TABLE cliente (
    idCliente INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100)
);
