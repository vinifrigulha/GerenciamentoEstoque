using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamentodeestoque.Atores
{
    public class Fornecedor
    {
        private string idFornecedor;
        private string nomeFornecedor;

        public string GetId() { return idFornecedor; }
        public string GetNome() { return nomeFornecedor; }

        private void SetId()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 1000000);
            idFornecedor = numeroAleatorio.ToString("000000");
        }

        public void SetNome(string nomeFornecedor) { this.nomeFornecedor = nomeFornecedor; }

        public Cotacao ResponderCotacao(string idCotacao)
        {

        }

        public void EnviarProdutos()
        {

        }

        public void ReceberNotificaçãoAlmoxarife()
        {

        }
    }
}
