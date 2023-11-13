CREATE DATABASE gerenciaEstoque;

USE gerenciaEstoque;

CREATE TABLE funcionario (
    idFuncionario INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(45),
    cpf CHAR(11),
    email VARCHAR(45),
    senha VARCHAR(45),
    telefone VARCHAR(45),
    endereco VARCHAR(45),
    tipoFuncionario CHAR(1),
    PRIMARY KEY (idFuncionario)
);

CREATE TABLE produto (
    idProduto INT NOT NULL AUTO_INCREMENT,
    preco DOUBLE,
    quantidadeEstoque INT,
    localizacaoEstoque INT,
    unidadeVenda VARCHAR(45),
    validade DATETIME,
    PRIMARY KEY (idProduto)
);

CREATE TABLE requisicao (
    idRequisicao INT NOT NULL AUTO_INCREMENT,
    idProduto INT NOT NULL,  -- Adicione a coluna idProduto
    checado BOOLEAN,
    PRIMARY KEY (idRequisicao, idProduto),
    FOREIGN KEY (idProduto) REFERENCES produto(idProduto)  -- Adicione a chave estrangeira
);

CREATE TABLE cotacao (
    idCotacao INT NOT NULL AUTO_INCREMENT,
    idComprador INT NOT NULL,
    finalizado BOOLEAN,
    PRIMARY KEY (idCotacao, idComprador),
    FOREIGN KEY (idComprador) REFERENCES funcionario(idFuncionario)
);

CREATE TABLE ordemCompra (
    idOrdemCompra INT PRIMARY KEY NOT NULL
);

CREATE TABLE cliente (
    idCliente INT NOT NULL AUTO_INCREMENT,
    nome VARCHAR(45),
    PRIMARY KEY (idCliente)
);

CREATE TABLE pedido (
    idPedido INT NOT NULL AUTO_INCREMENT,
    idCliente INT NOT NULL,
    finalizado BOOLEAN,
    PRIMARY KEY (idPedido),
    FOREIGN KEY (idCliente) REFERENCES cliente(idCliente)
);

CREATE TABLE ordemVenda (
    idOrdemVenda INT NOT NULL AUTO_INCREMENT,
    idVendedor INT NOT NULL,
    PRIMARY KEY (idOrdemVenda),
    FOREIGN KEY (idVendedor) REFERENCES funcionario(idFuncionario)
);

CREATE TABLE fornecedor (
    idFornecedor INT NOT NULL AUTO_INCREMENT,
    nomeFornecedor VARCHAR(45),
    PRIMARY KEY (idFornecedor)
);

CREATE TABLE ProdutoReq (
    idRequisicao INT NOT NULL,
    idFuncionario INT NOT NULL,
    idCotacao INT NOT NULL,
    idProduto INT NOT NULL,
    FOREIGN KEY (idRequisicao, idProduto) REFERENCES requisicao(idRequisicao, idProduto),
    FOREIGN KEY (idFuncionario) REFERENCES funcionario(idFuncionario),
    FOREIGN KEY (idCotacao) REFERENCES cotacao(idCotacao)
);
