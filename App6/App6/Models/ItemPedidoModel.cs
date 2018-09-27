using System;
using System.Collections.Generic;

namespace App6.Models
{
    public class ItemPedidoModel
    {
        public String IdItemPedido { get; set; }
        public PedidoModel Pedido { get; set; }
        public TicketModel Ticket { get; set;}
        public TitularTicketModel TitularTicket { get; set; }


        public ItemPedidoModel()
        {
        }
    }
}
