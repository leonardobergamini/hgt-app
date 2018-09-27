using System;
using System.Collections.Generic;
using App6.Layers.Services;
using App6.Models;

namespace App6.Layers.Business
{
    public class PedidoBusiness
    {
        public List<PedidoModel> GetAllPedido(){
            var _pedidos = new PedidoServices().GetPedidoByUsuario(Global.Usuario, Global.CartaoCredito);
            return _pedidos;
        }

        public List<PedidoModel> GetAllPedidoAndEventos()
        {
            var _pedidos = new PedidoServices().GetPedidoByUsuario(Global.Usuario, Global.CartaoCredito);

            var _pedidosRetorno = new List<PedidoModel>();

            foreach (var item in _pedidos) {

                var _itens = new ItemPedidoBusiness().GetAllItemPedido(item);
                //var _itemPedido = new ItemPedidoBusiness().GetItemPedidoById(_itens[0].IdItemPedido);
                var _ticket = new TicketBusiness().GetTicket(item.IdPedido, _itens[0].IdItemPedido);
                var _evento = new EventoBusiness().GetEventoByIdLocal(_ticket.Setor.Local.IdLocal);


                //item.Evento = new Services.EventoServices().GetEventoByPedido(item.IdPedido);
                //item.Evento = new EventoModel()
                //{
                //    NomeEvento = "Evento #1",
                //    UrlImagem = "https://bhaz.com.br/wp-content/uploads/2018/01/22496026_10155617737168432_8803059024245934709_o-850x491.jpg"
                //};
                item.Evento = _evento;

                _pedidosRetorno.Add(item);

            }


            return _pedidosRetorno;
        }
    }
}
