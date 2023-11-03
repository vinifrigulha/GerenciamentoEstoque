using GerenciamentoEstoque.Objetos.Estoque;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEstoque.Atores.Internos
{
    public class Comprador : Funcionario
    {
        Dictionary<string, Cotacao> listaCotacao = new Dictionary<string, Cotacao>();
        public Comprador(string nome, string cpf, string email, string login, string senha, string endereco, string telefone = "") 
            : base(nome, cpf, email, login, senha, endereco, telefone)
        {
            this.tipoFuncionario = 'C';
        }

        // Cotações
        public void CriarCotacao()
        {
            Cotacao cotacao = new Cotacao(id);
            listaCotacao.Add(cotacao.GetIdCotacao(), cotacao);
        }
        public void ExibirCotacoes()
        {
            foreach (KeyValuePair<string, Cotacao> cotacao in listaCotacao)
            {
                Console.Write($"\nCotação {cotacao.Key} \nVendedor {cotacao.Value.GetIdComprador()} \nStatus {cotacao.Value.GetStatus()}");
            }
        }
        
    }
}
