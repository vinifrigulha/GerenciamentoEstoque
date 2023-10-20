using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Atores
{
    public class Funcionario
    {
        // Atributos
        protected int id;
        protected string nome;
        protected string cpf;
        protected string email;
        protected string login;
        protected string senha;
        protected string endereco;
        protected string telefone;

        // Cadastro sem telefone
        public Funcionario(string nome, string cpf, string email, string login, string senha, string endereco)
        {
            // Gerar id aleatório entre 000001 e 999999
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.login = login;
            this.senha = senha;
            this.endereco = endereco;
        }
        // Cadastro com telefone
        public Funcionario(string nome, string cpf, string email, string login, string senha, string endereco, string telefone)
        {
            // Gerar id aleatório entre 000001 e 999999
            this.nome = nome;
            this.cpf = cpf;
            this.email = email;
            this.login = login;
            this.senha = senha;
            this.endereco = endereco;
            this.telefone = telefone;
        }

        // Métodos
        public void Login(string login, string senha)
        {

        }
        public void Logoff()
        {

        }
        public void AlterarSenha(string novaSenha)
        {

        }

        // Gets
        public int GetId() { return id; }
        public string GetNome() { return nome; }
        public string GetCpf() { return cpf; }
        public string GetEmail() { return email; }
        public string GetEndereco() { return endereco; }
        public string GetTelefone() { return telefone; }

        // Set
        public void SetNome(string nome) { this.nome = nome; }
        public void SetEmail(string email) { this.email = email; }
        public void SetEndereco(string endereco) { this.endereco = endereco; }
        public void SetTelefone(string telefone) { this.telefone = telefone; }
    }
}
