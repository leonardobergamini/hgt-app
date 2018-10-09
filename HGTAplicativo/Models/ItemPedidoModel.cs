using System;
using System.Collections.Generic;

namespace HGTAplicativo.Models
{
    public class ItemPedidoModel
    {
        public List<ItemPedidoModel> records { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public String IdItemPedido { get; set; }
        public ItemPedidoModel ItemPedido { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Pedido__c")]
        public String IdPedido { get; set; }
        public PedidoModel Pedido { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "ticket__c")]
        public String IdTicket { get; set; }
        public TicketModel Ticket { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "titular_ticket__c")]
        public String IdTitularTicket { get; set; }
        public TitularTicketModel TitularTicket { get; set; }

    }
}
