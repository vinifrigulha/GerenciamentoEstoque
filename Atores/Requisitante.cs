using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Atores
{
    public class Requisitante : Funcionario
    {
        public Requisitante(string nome, string cpf, string email, string login, string senha, string endereco) : base(nome, cpf, email, login, senha, endereco)
        {
        }

        public Requisitante(string nome, string cpf, string email, string login, string senha, string endereco, string telefone) : base(nome, cpf, email, login, senha, endereco, telefone)
        {
        }
    }
}
