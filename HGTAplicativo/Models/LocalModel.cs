using System;
using System.Collections.Generic;

namespace HGTAplicativo.Models
{
    public class LocalModel
    {
        public List<LocalModel> records { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public String IdLocal { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public String NomeLocal { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "descricao__c")]
        public String Descricao { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "capacidade_total__c")]
        public long CapacidadeTotal { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "rua__c")]
        public String Endereco { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "numero__c")]
        public long NroEndereco { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "complemento__c")]
        public String ComplementoEndereco { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "CEP__c")]
        public String CEP { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "cidade__c")]
        public String Cidade { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "estado__c")]
        public String UF { get; set; }

        public String EnderecoCompleto { get { return ToString(); } }

        public override string ToString()
        {
            return Endereco + ", " + NroEndereco + ", " + ComplementoEndereco;
        }
    }
}
