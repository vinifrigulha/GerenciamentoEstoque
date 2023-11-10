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

CREATE TABLE produto (
    idProduto INT AUTO_INCREMENT PRIMARY KEY,
    preco DOUBLE,
    descricao VARCHAR(100),
    qtdEstoque INT,
    localizacaoEstoque VARCHAR(200),
    unidadeVenda VARCHAR(20),
    validade DATE
);

CREATE TABLE requisicao (
    idRequisicao INT AUTO_INCREMENT PRIMARY KEY,
    checado BOOL
);

CREATE TABLE requisicao_produto (
    idRequisicao INT,
    idProduto INT,
    PRIMARY KEY(idRequisicao, idProduto),
    FOREIGN KEY (idRequisicao) REFERENCES requisicao(idRequisicao),
    FOREIGN KEY (idProduto) REFERENCES produto(idProduto)
);

CREATE TABLE cotacao (
    idCotacao INT AUTO_INCREMENT PRIMARY KEY,
    idComprador INT,
    finalizado BOOL,
    FOREIGN KEY (idComprador) REFERENCES funcionario(idFuncionario)
);

CREATE TABLE ordemCompra (
    idOrdemCompra INT AUTO_INCREMENT PRIMARY KEY
);

CREATE TABLE cliente (
    idCliente INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100)
);

CREATE TABLE pedido (
    idPedido INT AUTO_INCREMENT PRIMARY KEY,
    idCliente INT,
    finalizado BOOL,
    FOREIGN KEY (idCliente) REFERENCES cliente(idCliente)
);

CREATE TABLE fornecedor (
    idFornecedor INT AUTO_INCREMENT PRIMARY KEY,
    nomeFornecedor VARCHAR(100)
);

CREATE TABLE ProdutoReq (
    idRequisicao INT,
    idFuncionario INT,
    idCotacao INT,
    FOREIGN KEY (idRequisicao) REFERENCES requisicao(idRequisicao),
    FOREIGN KEY (idFuncionario) REFERENCES funcionario(idFuncionario),
    FOREIGN KEY (idCotacao) REFERENCES cotacao(idCotacao)
);
