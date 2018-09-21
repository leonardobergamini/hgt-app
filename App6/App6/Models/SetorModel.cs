using System;
namespace App6.Models
{
    public class SetorModel
    {
        public String IdSetor { get; set; } 
        public String NomeSetor { get; set;}
        public String Descricao { get; set; }
        public long CapacidadeTotalSetor { get; set; }
        public long CapacidadeUsadaSetor { get; set; }
        public LocalModel Local { get; set; }

        public SetorModel()
        {
        }

        public SetorModel(string idSetor, string nomeSetor, string descricao, long capacidadeTotalSetor, long capacidadeUsadaSetor, LocalModel local)
        {
            this.IdSetor = idSetor;
            this.NomeSetor = nomeSetor;
            this.Descricao = descricao;
            this.CapacidadeTotalSetor = capacidadeTotalSetor;
            this.CapacidadeUsadaSetor = capacidadeUsadaSetor;
            this.Local = local;
        }

    }
}
