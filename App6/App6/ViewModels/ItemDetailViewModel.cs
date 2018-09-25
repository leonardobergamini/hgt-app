using System;
using System.Collections.Generic;
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

            // Variavéis: Global.Pedido e Global.ItemPedido

            var _idItemPedido = Global.ItemPedido.IdItemPedido;
            Global.Ticket = new TicketBusiness().GetTicket(Global.Pedido.IdPedido, _idItemPedido);
            Global.Evento = new EventoBusiness().GetEventoByIdLocal(Global.Ticket.Setor.Local.IdLocal);

            Evento = Global.Evento;
            Ticket = Global.Ticket;
        }
    }
}
