-- INSERÇÔES PARA POVOAR O BANCO

INSERT INTO funcionario (nome, cpf, email, senha, telefone, endereco, tipoFuncionario)
VALUES
    ('João Silva', '12345678901', 'joao@example.com', 'senha123', '(11) 1234-5678', 'Rua A, 123', 'A'),
    ('Maria Santos', '23456789012', 'maria@example.com', 'senha456', '(12) 2345-6789', 'Rua B, 456', 'B'),
    ('Pedro Oliveira', '34567890123', 'pedro@example.com', 'senha789', '(13) 3456-7890', 'Rua C, 789', 'C'),
    ('Ana Souza', '45678901234', 'ana@example.com', 'senhaABC', '(14) 4567-8901', 'Rua D, 901', 'D'),
    ('Lucas Pereira', '56789012345', 'lucas@example.com', 'senhaDEF', '(15) 5678-9012', 'Rua E, 234', 'E'),
    ('Mariana Ferreira', '67890123456', 'mariana@example.com', 'senhaGHI', '(16) 6789-0123', 'Rua F, 567', 'F'),
    ('Gustavo Rodrigues', '78901234567', 'gustavo@example.com', 'senhaJKL', '(17) 7890-1234', 'Rua G, 678', 'G'),
    ('Camila Lima', '89012345678', 'camila@example.com', 'senhaMNO', '(18) 8901-2345', 'Rua H, 789', 'H'),
    ('Rafaela Alves', '90123456789', 'rafaela@example.com', 'senhaPQR', '(19) 9012-3456', 'Rua I, 890', 'I'),
    ('Bruno Gomes', '01234567890', 'bruno@example.com', 'senhaSTU', '(20) 0123-4567', 'Rua J, 901', 'J');

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
-- Suponhamos que você queira criar requisições para alguns produtos.
-- Vou inserir 10 requisições para os produtos de id 1 a 10.
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

-- Inserir ordens de compra não faz sentido sem uma relação específica com outras tabelas.
-- Portanto, as ordens de compra são criadas quando há uma necessidade real no sistema.
-- Não é possível criar inserts genéricos para essa tabela sem mais contexto.

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
-- Suponhamos que você queira criar pedidos para os produtos de id 1 a 10, associados aos clientes de id 1 a 10.
-- Vou inserir 10 pedidos, um para cada cliente e produto.

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
-- Suponhamos que você queira criar associações para os produtos de id 1 a 10, com funcionários de id 1 a 10 e cotações de id 1 a 10.
-- Vou inserir 10 associações.
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
