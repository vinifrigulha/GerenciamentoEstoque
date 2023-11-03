using Gerenciamentodeestoque.Atores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Atores
{
    internal class Cliente
    {
        private string idCliente;
        private string nomeCliente;

        public string GetId() { return idCliente; }
        public string GetNome() { return nomeCliente; }

        private void SetId()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 1000000);
            idCliente = numeroAleatorio.ToString("000000");
        }
        public void SetNome(string nomeCliente) { this.nomeCliente = nomeCliente; }

        public void ResponderVendedor(string idVendedor) { 
        }

        public void Criarpedido(){

        }

        public void CancelarPedido(string idPedido)
        {

        }

        public Pedido EnviarPedido(string idPedido){ 
        }



    }
}
