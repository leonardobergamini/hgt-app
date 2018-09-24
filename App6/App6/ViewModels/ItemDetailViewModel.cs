using System;
using App6.Layers.Business;
using App6.Layers.Services;
using App6.Models;

namespace App6.ViewModels
{
    public class ItemDetailViewModel
    {
        public EventoModel Evento { get; set; }
        public TicketModel Ticket { get; set; }

        public ItemDetailViewModel(){
            Evento = Global.Evento;
            Ticket = new TicketBusiness().GetTicket();

        }

    }


}
