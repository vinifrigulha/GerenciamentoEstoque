using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "server=localhost;database=gerenciaEstoque;user=root;password=0000";

        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Conexão bem-sucedida!");

                // Executar a consulta para inserir uma nova linha na tabela "cliente"
                string query2 = "INSERT INTO cliente (nome) VALUES (@nome)";

                using (MySqlCommand insertCommand = new MySqlCommand(query2, connection))
                {
                    // Substitua "@nome" e "@email" pelos parâmetros reais
                    insertCommand.Parameters.AddWithValue("@nome", "Gil");

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Inserção bem-sucedida!");
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma linha inserida.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro de conexão: {ex.Message}");
            }

            // Fora do bloco using da conexão principal
            string query = "SELECT * FROM cliente";

            string NomePrincipal = "";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                Console.WriteLine("Conexão get here!");
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader.GetInt32("idCliente")}, Nome: {reader.GetString("nome")}");
                        NomePrincipal = reader.GetString("nome");
                    }
                }
            }

            //string queryInsFun = "INSERT INTO funcionario (nome, cpf, email, senha, telefone, endereco, tipoFuncionario) VALUES (@nome, @cpf, @email, @senha, @telefone, @endereco, @tipoFuncionario)"
            //string queryInsPro = "INSERT INTO produto (preco, quantidadeEstoque, localizacaoEstoque, unidadeVenda, validade) VALUES (@preco, @cpf, @quantidadeEstoque, @localizacaoEstoque, @unidadeVenda, @validade)"
            //string queryInsReq = "INSERT INTO requisicao (idProduto, checado) VALUES (@idProduto, @checado)"
            //string queryInsCot = "INSERT INTO cotacao (idComprador, finalizado) VALUES (@idComprador, @finalizado)"
            //string queryInsOrdCom = "INSERT INTO ordemCompra (idOrdemCompra), VALUES (@idOrdemCompra)"
            //string queryInsCli = "INSERT INTO cliente (nome) VALUES (@nome)"
            //string queryInsPed = "INSERT INTO pedido (idCliente, finalizado) VALUES (@idCliente, @finalizado)"
            //string queryInsOrdemVen = "INSERT INTO ordemVenda (idVendedor) VALUES (@idVendedor)"
            //string queryInsFor = "INSERT INTO fornecedor (nomeFornecedor) VALUES (@nomeFornecedor)"
            //string queryInsProReq = "INSERT INTO ProdutoReq (idFuncionario, idCotacao, idProduto) VALUES (@idFuncionario, @idCotacao, @idProduto)"
            
            Console.WriteLine($"{NomePrincipal}");
        }
    }
}
