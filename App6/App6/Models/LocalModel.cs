using System;
using System.Collections.Generic;

namespace App6.Models
{
    public class LocalModel
    {
        public String IdLocal { get; set; }
        public String NomeLocal { get; set; }
        public String Descricao { get; set; }
        public long CapacidadeTotal { get; set;}
        public String Endereco { get; set; }
        public long NroEndereco { get; set; }
        public String ComplementoEndereco { get; set; }
        public String CEP { get; set; }
        public String Cidade { get; set; }
        public String UF { get; set; }

        public LocalModel(){

        }
    }
}
