using System;
using System.Collections.ObjectModel;

namespace App6.Models
{
    public class PedidoModel //: ObservableCollection<PedidoModel>
    {
        public String IdPedido { get; set; }
        public FormaPagamentoModel FormaPagamento { get; set; }
        public UsuarioModel Usuario { get; set;}
        public EventoModel Evento { get; set; }


        public PedidoModel(string idPedido, FormaPagamentoModel formaPagamento, UsuarioModel usuario, EventoModel evento)
        {
            this.IdPedido = idPedido;
            this.FormaPagamento = formaPagamento;
            this.Usuario = usuario;
            this.Evento = evento;
        }

        public PedidoModel(){

        }

    }

}
