using System;
using System.Collections.Generic;
using HGTAplicativo.Layers.Services;

namespace HGTAplicativo.Models
{
    public class Global
    {
        public static UsuarioModel Usuario { get; set; }
        public static TicketModel Ticket { get; set; }
        public static EventoModel Evento { get; set; }
        public static List<TicketModel> Tickets { get; set; }
        public static List<EventoModel> Eventos { get; set; }
        public static List<PedidoModel> Pedidos { get; set; }
        public static List<ItemPedidoModel> ItensPedidos { get; set; }
        public static ItemPedidoModel ItemPedido { get; set; }
        public static PedidoModel Pedido { get; set; }
        public static FormaPagamentoModel FormaPagamento { get; set; }
        public static String CartaoCredito { get; set; }
        public static TitularTicketModel TitularTicket { get; set; }
        public static APIConfig Auth { get; set; }
        public static String AccessToken { get; set; }
        public static String Url { get; set; }
    }
}
