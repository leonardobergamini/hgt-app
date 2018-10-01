using System;
using System.Collections.Generic;
using App6.Layers.Services;
using App6.Models;

namespace App6.Layers.Business
{
    public class PedidoBusiness
    {
        public List<PedidoModel> GetAllPedidoAndEventos(String _idFormaPg)
        {
            var _pedidos = new PedidoServices().GetAllPedido(_idFormaPg);
            List<PedidoModel> _pedidosRetorno = new List<PedidoModel>();

            foreach (var pedido in _pedidos)
            {
                //Global.ItensPedidos = new ItemPedidoBusiness().GetAllItemPedido(pedido);
                //var _itemPedido = new ItemPedidoBusiness().GetItemPedidoById(Global.ItensPedidos[0].IdItemPedido);
                //var _idTicket = _itemPedido.IdTicket;
                //var _ticket = new TicketBusiness().GetTicketById(_idTicket);
                //var _setor = new SetorBusiness().GetSetorById(_ticket.IdSetor);
                //var _evento = new EventoBusiness().GetEventoByEvento

                pedido.Evento = new EventoBusiness().GetEventoById(pedido.IdEvento);
                pedido.Evento.Local = new LocalServices().GetLocalById(pedido.Evento.IdLocal);

                _pedidosRetorno.Add(pedido);

            }

            return _pedidosRetorno;
        }
    }
}
