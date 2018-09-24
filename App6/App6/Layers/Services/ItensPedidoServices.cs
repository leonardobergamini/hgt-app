using System;
using System.Collections.Generic;
using App6.Models;

namespace App6.Layers.Services
{
    public class ItensPedidoServices
    {

        public List<ItensPedidoModel> GetAllItensByPedido(PedidoModel _pedido){

            List<ItensPedidoModel> _itens = new List<ItensPedidoModel>();
            if(_pedido.IdPedido.Equals("P-0001")){

                var _ticket = new TicketServices().GetTickets("1", _pedido.IdPedido);
                var _item = new ItensPedidoModel
                {
                    IdItemPedido = "1",
                    Pedido = _pedido,
                    Ticket = _ticket
                };

                _itens.Add(_item);
            }
            if (_pedido.IdPedido.Equals("P-0002"))
            {

                var _ticket = new TicketServices().GetTickets("2", _pedido.IdPedido);
                var _item = new ItensPedidoModel
                {
                    IdItemPedido = "2",
                    Pedido = _pedido,
                    Ticket = _ticket
                };

                _itens.Add(_item);
            }
            if (_pedido.IdPedido.Equals("P-0003"))
            {

                var _ticket = new TicketServices().GetTickets("3", _pedido.IdPedido);
                var _item = new ItensPedidoModel
                {
                    IdItemPedido = "3",
                    Pedido = _pedido,
                    Ticket = _ticket
                };

                _itens.Add(_item);
            }
            if (_pedido.IdPedido.Equals("P-0002"))
            {
                var _ticket = new TicketServices().GetTickets("4", _pedido.IdPedido);
                var _item = new ItensPedidoModel
                {
                    IdItemPedido = "4",
                    Pedido = _pedido,
                    Ticket = _ticket
                };

                _itens.Add(_item);
            }
            if (_pedido.IdPedido.Equals("P-0001"))
            {
                var _ticket = new TicketServices().GetTickets("5", _pedido.IdPedido);
                var _item = new ItensPedidoModel
                {
                    IdItemPedido = "5",
                    Pedido = _pedido,
                    Ticket = _ticket
                };

                _itens.Add(_item);
            }

            return _itens;
        }

    }
}
