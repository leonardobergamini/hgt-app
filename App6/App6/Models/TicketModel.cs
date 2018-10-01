using System;
using System.Collections.Generic;

namespace App6.Models
{
    public class TicketModel
    {
        public List<TicketModel> records { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public String IdTicket { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "preco__c")]
        public Double Preco { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "cod_ingresso__c")]
        public String CodIngresso { get; set; }


        [Newtonsoft.Json.JsonProperty(PropertyName = "setor__c")]
        public String IdSetor { get; set;}
        public SetorModel Setor { get; set; }

        public String QrCode { get { return ToString(); }}


        public override string ToString()
        {
            return "TicketModel: IdTicket= " + IdTicket;

        }

    }
}