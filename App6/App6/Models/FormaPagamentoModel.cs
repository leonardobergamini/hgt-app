using System;
namespace App6.Models
{
    public class FormaPagamentoModel
    {
        public String IdFormaPagamento { get; set; }
        public CartaoCreditoModel CartaoCredito { get; set; }
        public UsuarioModel Usuario { get; set; }

        public FormaPagamentoModel()
        {
        }
    }
}
