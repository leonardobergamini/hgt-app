using System;

namespace App6.Models
{
    public class TicketModel
    {
        public int Id { get; set; }
        public Double Preco { get; set; }
        public string CodIngresso { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }

        public TicketModel(int id, double preco, string codIngresso, string nome, string descricao)
        {
            this.Id = id;
            this.Preco = preco;
            this.CodIngresso = codIngresso;
            this.Nome = nome;
            this.Descricao = descricao;
        }

        public TicketModel(){

        }

    }
}