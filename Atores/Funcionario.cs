using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEstoque.Atores.Internos
{
    public class Funcionario
    {
        // Atributos
        protected string id;
        protected string nome;
        protected string cpf;
        protected string email;
        protected string login;
        protected string senha;
        protected string endereco;
        protected string telefone;
        protected char tipoFuncionario;

        // Cadastro
        public Funcionario(string nome, string cpf, string email, string login, string senha, string endereco, string telefone = "")
        {
            SetId();
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.login = login;
            this.senha = senha;
            this.endereco = endereco;
            this.telefone = telefone;
        }

        // Métodos
        public bool Login()
        {
            while (true)
            {
                Console.Write("Digite seu login: ");
                string login = Console.ReadLine();
                Console.Write("Digite sua senha: ");
                string senha = Console.ReadLine();

                if (this.login == login && this.senha == senha)
                {
                    Console.WriteLine("Login bem-sucedido!");
                    return true;
                }

                Console.WriteLine("Login falhou. Verifique suas credenciais.");
            }
        }

        public void Logoff()
        {
            Console.WriteLine("Você saiu. Até mais! :)");
        }

        public void AlterarSenha()
        {
            Console.Write("\nDigite sua senha atual: ");
            string senhaAntiga = Console.ReadLine();
            while (senhaAntiga != senha)
            {
                Console.WriteLine("\nSenha incorreta! Tente novamente.");
                Console.Write("\nDigite sua senha atual: ");
                senhaAntiga = Console.ReadLine();
            }

            Console.Write("\nDigite sua nova senha: ");
            string senhaNova = Console.ReadLine();
            Console.Write("\nRepita sua nova senha: ");
            string senhaConfirmacao = Console.ReadLine();

            while (senhaNova != senhaConfirmacao)
            {
                Console.WriteLine("\nAs senhas não coincidem! Tente novamente.");
                Console.Write("\nDigite sua nova senha: ");
                senhaNova = Console.ReadLine();
                Console.Write("\nRepita sua nova senha: ");
                senhaConfirmacao = Console.ReadLine();
            }

            senha = senhaNova;
            Console.WriteLine("\nSenha alterada com sucesso!");
        }

        // Gets
        public string GetId() { return id; }
        public string GetNome() { return nome; }
        public string GetCpf() { return cpf; }
        public string GetEmail() { return email; }
        public string GetEndereco() { return endereco; }
        public string GetTelefone() { return telefone; }
        public void GetTipoFuncionario() { Console.WriteLine($"Tipo funcionário: {tipoFuncionario}"); }

        // Sets
        private void SetId()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 1000000);
            id = numeroAleatorio.ToString("000000");
        }
        public void SetNome(string nome) { this.nome = nome; }
        public void SetEmail(string email) { this.email = email; }
        public void SetEndereco(string endereco) { this.endereco = endereco; }
        public void SetTelefone(string telefone) { this.telefone = telefone; }
    }  
}
