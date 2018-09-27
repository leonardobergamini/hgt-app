using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace App6.Models
{
    public class UsuarioModel
    {

        public List<UsuarioModel> records { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public String IdCliente { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "FirstName")]
        public String PrimeiroNome { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "LastName")]
        public String Sobrenome { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Birthdate")]
        public String DtNascimento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "cpf__c")]
        public String CPF { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Email")]
        public String Email { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "MobilePhone")]
        public String Telefone { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "rg__c")]
        public String RG { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "usuario__c")]
        public String NmUsuario { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "senha__c")]
        public String Senha { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "MailingStreet")]
        public String Endereco { get; set; }


        public long NroResidencia { get; set; }


        public String Complemento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "MailingPostalCode")]
        public String CEP { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "MailingCity")]
        public String Cidade { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "MailingState")]
        public String UF { get; set; }

        public String NomeCompleto { get { return this.PrimeiroNome + " " + this.Sobrenome; } }


        public UsuarioModel()
        {

        }

    }
}

