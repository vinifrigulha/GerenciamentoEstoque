using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEstoque.Atores.Internos
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, string cpf, string email, string login, string senha, string endereco, string telefone = "") 
            : base(nome, cpf, email, login, senha, endereco, telefone)
        {
            this.tipoFuncionario = 'V';
        }
    }
}
