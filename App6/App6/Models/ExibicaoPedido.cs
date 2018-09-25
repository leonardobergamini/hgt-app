using System;
using System.Collections.Generic;

namespace App6.Models
{
    public class ExibicaoPedido
    {
        public TicketModel Ticket { get; set; }
        public EventoModel Evento { get; set; }
        public List<PedidoModel> Pedidos { get; set; }
    }
}
