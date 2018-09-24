using System;
namespace App6.Models
{
    public class PedidoModel
    {
        public String IdPedido { get; set; }
        public FormaPagamentoModel FormaPagamento { get; set; }
        public UsuarioModel Usuario { get; set;}

        public PedidoModel()
        {
        }
    }
}
