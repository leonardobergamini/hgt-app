using System;
using System.Collections.Generic;

namespace App6.Models
{
    public class FormaPagamentoModel
    {
        public List<FormaPagamentoModel> records { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public String IdFormaPagamento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "cartao_credito__c")]
        public String IdCartaoCredito { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Contato__C")]
        public String IdUsuario { get; set; }

        public FormaPagamentoModel()
        {
        }
    }
}
