using GerenciamentoEstoque.Atores.Internos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("\nSeu CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("\nSeu e-mail: ");
            string email = Console.ReadLine();
            Console.Write("\nSeu login: ");
            string login = Console.ReadLine();
            Console.Write("\nSua senha: ");
            string senha = Console.ReadLine();
            Console.Write("\nSeu endereço: ");
            string endereco = Console.ReadLine();
            Console.Write("\nSeu telefone (se não tiver, aperte 'Enter'): ");
            string telefone = Console.ReadLine();

            Comprador c1 = new Comprador(nome, cpf, email, login, senha, endereco, telefone);

            c1.Login();
            
            string id = c1.GetId();
            Console.WriteLine($"Seu Id é: {id}");


            // DEU ERRO
            c1.CriarCotacao();
            c1.CriarCotacao();
            c1.CriarCotacao();
            c1.CriarCotacao();

            c1.ExibirCotacoes();

            c1.Logoff();
        }
    }
}
