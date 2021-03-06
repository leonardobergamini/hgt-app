﻿using System;
using System.Collections.Generic;

namespace HGTAplicativo.Models
{
    public class TitularTicketModel
    {
        public List<TitularTicketModel> records { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public String IdTitular { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "nome__c")]
        public String PrimeiroNome { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "sobrenome__c")]
        public String Sobrenome { get; set; }

        public String NomeCompleto { get { return PrimeiroNome + " " + Sobrenome; } }

        [Newtonsoft.Json.JsonProperty(PropertyName = "dt_nascimento__c")]
        public DateTime DtNascimento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "cpf__c")]
        public String CPF { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "telefone__c")]
        public String Telefone { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "email__c")]
        public String Email { get; set; }

        public String IdUsuario { get; set; }
    }
}
