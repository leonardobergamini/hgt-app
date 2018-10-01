using System;
using System.Collections.Generic;

namespace App6.Models
{
    public class FaixaEtariaModel
    {
        public List<FaixaEtariaModel> records { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public String IdFaixaEtaria { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public String NomeFaixaEtaria { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "descricao__c")]
        public String Descricao { get; set;}

    }
}
