using System;
using System.Collections.Generic;

namespace HGTAplicativo.Models
{
    public class SetorModel
    {
        public List<SetorModel> records { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public String IdSetor { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public String NomeSetor { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "descricao__c")]
        public String Descricao { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "capacidade_total_setor__c")]
        public String CapacidadeTotalSetor { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "capacidade_usada_setor__c")]
        public String CapacidadeUsadaSetor { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "local__c")]
        public String IdLocal { get; set; }
    }
}
