using System;
using System.Collections.Generic;

namespace App6.Models
{
    public class EventoModel
    {
        public List<EventoModel> records { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName ="Id")]
        public String IdEvento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public String NomeEvento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "descricao__c")]
        public String Descricao { get; set;}

        [Newtonsoft.Json.JsonProperty(PropertyName = "dt_inicio_evento__c")]
        public DateTime DtInicioEvento { get; set;}

        [Newtonsoft.Json.JsonProperty(PropertyName = "dt_final_evento__c")]
        public DateTime DtFinalEvento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "dt_inicio_venda__c")]
        public DateTime DtInicioVenda { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "dt_final_venda__c")]
        public DateTime DtFinalVenda { get; set;}

        [Newtonsoft.Json.JsonProperty(PropertyName = "url_img__c")]
        public String UrlImagem { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Hr_inicio_evento__c")]
        public DateTime HoraInicioEvento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Hr_termino_evento__c")]
        public DateTime HoraTerminoEvento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "faixa_etaria__c")]
        public String IdFaixaEtaria { get; set; }
        public FaixaEtariaModel FaixaEtaria { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "local__c")]
        public String IdLocal { get; set; }
        public LocalModel Local { get; set; }






    }
}
