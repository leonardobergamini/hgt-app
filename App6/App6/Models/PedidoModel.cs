using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace App6.Models
{
    public class PedidoModel //: ObservableCollection<PedidoModel>
    {
        public List<PedidoModel> records { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public String IdPedido { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Forma_de_pagamento__c")]
        public String FormaPagamento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Evento__c")]
        public String IdEvento { get; set; }

        public EventoModel Evento { get; set; }
        public UsuarioModel Usuario { get; set;}


    }

}
