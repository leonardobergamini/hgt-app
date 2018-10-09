using System;
namespace HGTAplicativo.Models
{
    public class CartaoCreditoModel
    {
        public int IdCartao { get; set; }
        public String NomeTitular { get; set; }
        public DateTime ValCartao { get; set; }
        public int CodSeguranca { get; set; }
        public String NroCartao { get; set; }

    }
}
