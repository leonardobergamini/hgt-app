using System;

namespace App6.Models
{
    public class TicketModel
    {
        public String IdTicket { get; set; }
        public Double Preco { get; set; }
        public String CodIngresso { get; set; }
        public String UrlQrCode { get; set;}
        public SetorModel Setor { get; set;}

        public TicketModel(){

        }


        public TicketModel(string idTicket, double preco, string codIngresso, string urlQrCode, SetorModel setor)
        {
            this.IdTicket = idTicket;
            this.Preco = preco;
            this.CodIngresso = codIngresso;
            this.UrlQrCode = urlQrCode;
            this.Setor = setor;
        }

    }
}