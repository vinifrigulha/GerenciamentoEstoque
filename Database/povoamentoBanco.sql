INSERT INTO funcionario (nome, cpf, email, senha, telefone, endereco, tipoFuncionario)
VALUES
    ('João Silva', '12345678901', 'joao@example.com', 'senha123', '(11) 1234-5678', 'Rua A, 123', 'C'),
    ('Maria Santos', '23456789012', 'maria@example.com', 'senha456', '(12) 2345-6789', 'Rua B, 456', 'V'),
    ('Pedro Oliveira', '34567890123', 'pedro@example.com', 'senha789', '(13) 3456-7890', 'Rua C, 789', 'C'),
    ('Ana Souza', '45678901234', 'ana@example.com', 'senhaABC', '(14) 4567-8901', 'Rua D, 901', 'V'),
    ('Breno Cardoso', '12345607222', 'benin@example.com', 'senhaLOL', '(27) 9983-4567', 'Rua B, 022', 'C'),
    ('Gabriel Freire', '37845907689', 'biel@example.com', 'senhaBIBA', '(20) 3432-4567', 'Rua G, 456', 'V'),
    ('Davi Ferreira', '39076845906', 'davizin@example.com', 'senhaANA', '(20) 4359-4567', 'Rua D, 232', 'C'),
    ('Flavio Ortega', '18593038901', 'flavio@example.com', 'senhaFLA', '(20) 2321-4531', 'Rua F, 904', 'V'),
    ('Cesar Augusto', '47890785688', 'cesaraugusto@example.com', 'senhaCESAR', '(20) 3241-4524', 'Rua CA, 333', 'V'),
    ('Adriano Imperador', '85903286799', 'adriimpe@example.com', 'senhaIMP', '(20) 0123-4242', 'Rua AI, 171', 'V');


INSERT INTO produto (preco, descricao, qtdEstoque, localizacaoEstoque, unidadeVenda, validade)
VALUES
    (10.99, 'Produto 1', 100, 'Prateleira A', 'Unidade', '2023-12-31'),
    (15.99, 'Produto 2', 50, 'Prateleira B', 'Unidade', '2023-11-30'),
    (5.49, 'Produto 3', 200, 'Prateleira C', 'Unidade', '2023-12-15'),
    (8.99, 'Produto 4', 75, 'Prateleira D', 'Unidade', '2023-12-10'),
    (12.49, 'Produto 5', 120, 'Prateleira E', 'Unidade', '2023-12-05'),
    (6.99, 'Produto 6', 90, 'Prateleira F', 'Unidade', '2023-11-25'),
    (9.99, 'Produto 7', 60, 'Prateleira G', 'Unidade', '2023-11-20'),
    (11.99, 'Produto 8', 40, 'Prateleira H', 'Unidade', '2023-11-15'),
    (7.49, 'Produto 9', 150, 'Prateleira I', 'Unidade', '2023-11-10'),
    (14.99, 'Produto 10', 80, 'Prateleira J', 'Unidade', '2023-11-05');
    
-- Os inserts na tabela requisicao dependem da relação com a tabela produto.
INSERT INTO requisicao (checado)
VALUES
    (1),
    (0),
    (1),
    (0),
    (1),
    (0),
    (1),
    (0),
    (1),
    (0);

INSERT INTO cotacao (idComprador, finalizado)
VALUES
    (1, 1),
    (2, 0),
    (3, 1),
    (4, 0),
    (5, 1),
    (6, 0),
    (7, 1),
    (8, 0),
    (9, 1),
    (10, 0);


INSERT INTO cliente (nome)
VALUES
    ('Maria da Silva'),
    ('José Oliveira'),
    ('Ana Santos'),
    ('Paulo Souza'),
    ('Carla Ferreira'),
    ('Antônio Gomes'),
    ('Mariana Alves'),
    ('Lucas Lima'),
    ('Beatriz Rodrigues'),
    ('Rafaela Gonçalves');

-- Para inserir dados na tabela pedido, você precisará associar os pedidos aos clientes e produtos.

INSERT INTO pedido (idCliente, finalizado)
VALUES
    (1, 1),
    (2, 0),
    (3, 1),
    (4, 0),
    (5, 1),
    (6, 0),
    (7, 1),
    (8, 0),
    (9, 1),
    (10, 0);

INSERT INTO fornecedor (nomeFornecedor)
VALUES
    ('Fornecedor ABC Ltda.'),
    ('Fornecedor XYZ S.A.'),
    ('Distribuidora de Produtos EFG'),
    ('Indústria de Alimentos HIJ'),
    ('Comércio de Eletrônicos LMN'),
    ('Importadora de Vestuário OPQ'),
    ('Fornecedor RST Comércio'),
    ('Distribuidora de Materiais UVW'),
    ('Indústria de Bebidas XYZ Ltda.'),
    ('Comércio de Produtos Alimentícios ABC');

-- Para a tabela ProdutoReq, você precisará associar as requisições, funcionários e cotações com produtos específicos.
INSERT INTO ProdutoReq (idRequisicao, idFuncionario, idCotacao)
VALUES
    (1, 1, 1),
    (2, 2, 2),
    (3, 3, 3),
    (4, 4, 4),
    (5, 5, 5),
    (6, 6, 6),
    (7, 7, 7),
    (8, 8, 8),
    (9, 9, 9),
    (10, 10, 10);
