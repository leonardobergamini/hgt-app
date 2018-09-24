using System;
namespace App6.Models
{
    public class EventoModel
    {
        public String IdEvento { get; set; }
        public String NomeEvento { get; set; }
        public String Descricao { get; set;}
        public DateTime DtInicioEvento { get; set;}
        public DateTime DtFinalEvento { get; set; }
        public DateTime DtInicioVenda { get; set; }
        public DateTime DtFinalVenda { get; set;}
        public String UrlImagem { get; set; }
        public FaixaEtariaModel FaixaEtaria { get; set; }
        public LocalModel Local { get; set; }


        public EventoModel()
        {
        }
    }
}
