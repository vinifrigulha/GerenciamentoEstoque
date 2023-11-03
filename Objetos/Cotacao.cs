using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoEstoque.Objetos.Estoque
{
    public class Cotacao
    {
        // Atributos
        private string idCotacao;
        private string idComprador;
        private string status;
        private bool estaEncerrada = false;

        public Cotacao(string idComprador)
        {
            SetIdCotacao();
            this.idComprador = idComprador;
            this.status = "Em andamento...";
        }

        // Método
        public void AlterarStatus()
        {
            if (!this.estaEncerrada) Encerrar();
            else Console.Write($"\nA Cotação {idCotacao} já está encerrada!");
        }
        public void Encerrar()
        {
            this.estaEncerrada = true;
        }

        // Gets
        public string GetIdCotacao() { return idCotacao; }
        public string GetIdComprador() { return idComprador; }
        public string GetStatus() { return status; }

        // Sets
        private void SetIdCotacao()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 1000000);
            idCotacao = numeroAleatorio.ToString("000000");
        }
    }
}
