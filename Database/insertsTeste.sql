-- INSERÇÔES PARA TESTES

INSERT INTO funcionario (idFuncionario, nome, cpf, email, senha, telefone, endereco, tipoFuncionario)
VALUES
(1, 'João Silva', '12345678901', 'joao@email.com', 'senha123', '123-456-7890', 'Rua A, Cidade', 'A'),
(2, 'Maria Santos', '98765432101', 'maria@email.com', 'senha456', '987-654-3210', 'Rua B, Cidade', 'B'),
(3, 'Pedro Lima', '45612378901', 'pedro@email.com', 'senha789', '456-123-7890', 'Rua C, Cidade', 'C'),
(4, 'Ana Ferreira', '78945612301', 'ana@email.com', 'senhaABC', '789-456-1230', 'Rua D, Cidade', 'A'),
(5, 'Lucas Oliveira', '65498712301', 'lucas@email.com', 'senhaXYZ', '654-987-1230', 'Rua E, Cidade', 'B');

INSERT INTO produto (idProduto, preco, quantidadeEstoque, localizacaoEstoque, unidadeVenda, validade)
VALUES
(1, 10.99, 100, 1, 'Unidade', '2023-12-31'),
(2, 15.49, 75, 2, 'Unidade', '2023-11-30'),
(3, 8.75, 120, 3, 'Unidade', '2024-01-15'),
(4, 12.99, 50, 4, 'Unidade', '2023-12-20'),
(5, 9.99, 90, 5, 'Unidade', '2024-02-28');

INSERT INTO requisicao (idRequisicao, idProduto, checado)
VALUES
(1, 1, 1),
(2, 3, 0),
(3, 2, 1),
(4, 4, 0),
(5, 5, 1);

INSERT INTO cotacao (idCotacao, idComprador, finalizado)
VALUES
(1, 1, 0),
(2, 2, 1),
(3, 3, 0),
(4, 4, 1),
(5, 5, 1);

INSERT INTO ordemCompra (idOrdemCompra)
VALUES
(1),
(2),
(3),
(4),
(5);

INSERT INTO cliente (idCliente, nome)
VALUES
(1, 'Carlos Pereira'),
(2, 'Mariana Alves'),
(3, 'Rodrigo Santos'),
(4, 'Isabela Ferreira'),
(5, 'Luciana Silva');


INSERT INTO pedido (idPedido, idCliente, finalizado)
VALUES
(1, 1, 1),
(2, 2, 0),
(3, 3, 1),
(4, 4, 0),
(5, 5, 1);

INSERT INTO ordemVenda (idOrdemVenda, idVendedor)
VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

INSERT INTO fornecedor (idFornecedor, nomeFornecedor)
VALUES
(1, 'Fornecedor A'),
(2, 'Fornecedor B'),
(3, 'Fornecedor C'),
(4, 'Fornecedor D'),
(5, 'Fornecedor E');

INSERT INTO ProdutoReq (idRequisicao, idFuncionario, idCotacao, idProduto)
VALUES
(1, 1, 1, 1),
(2, 2, 2, 3),
(3, 3, 3, 2),
(4, 4, 4, 4),
(5, 5, 5, 5);
