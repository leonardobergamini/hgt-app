using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace App6.Models
{
    public class UsuarioModel
    {
        public List<UsuarioModel> records;
        public String Id { get; set; }
        public String Nome__c { get; set; }
        public String Sobrenome__c { get; set; }
        public String Dt_nascimento__c { get; set; }
        public String CPF__c { get; set; }
        public String E_mail__c { get; set; }
        public String Celular__c { get; set; }
        public String RG__c { get; set; }
        public String Nm_Usuario__c { get; set; }
        public String Senha__c { get; set; }

        public UsuarioModel(string _usuario, string _senha)
        {
            /*this.Nm_Usuario__c = _usuario;
            this.Senha__c = _senha;*/
        }

        public UsuarioModel()
        {

        }

    }
}

