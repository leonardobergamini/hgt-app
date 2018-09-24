using System;
using System.Collections.Generic;

namespace App6.Models
{
    public class ItensPedidoModel
    {
        public String IdItemPedido { get; set; }
        public PedidoModel Pedido { get; set; }
        public TicketModel Ticket { get; set;}


        public ItensPedidoModel()
        {
        }
    }
}
