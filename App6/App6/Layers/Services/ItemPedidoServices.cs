using System;
using System.Collections.Generic;
using App6.Models;

namespace App6.Layers.Services
{
    public class ItemPedidoServices
    {

        public List<ItemPedidoModel> GetAllItensByPedido(PedidoModel _pedido){

            List<ItemPedidoModel> _itens = new List<ItemPedidoModel>();
            if(_pedido.IdPedido.Equals("P-0001")){

                var _ticket = new TicketServices().GetTicket("1", _pedido.IdPedido);
                var _item = new ItemPedidoModel
                {
                    IdItemPedido = "1",
                    Pedido = _pedido,
                    Ticket = _ticket,
                    TitularTicket = Global.TitularTicket
                };

                _itens.Add(_item);
            }
            if (_pedido.IdPedido.Equals("P-0002"))
            {
                var _ticket = new TicketServices().GetTicket("2", _pedido.IdPedido);
                var _item = new ItemPedidoModel
                {
                    IdItemPedido = "2",
                    Pedido = _pedido,
                    Ticket = _ticket,
                    TitularTicket = Global.TitularTicket
                };

                _itens.Add(_item);
            }
            if (_pedido.IdPedido.Equals("P-0003"))
            {

                var _ticket = new TicketServices().GetTicket("3", _pedido.IdPedido);
                var _item = new ItemPedidoModel
                {
                    IdItemPedido = "3",
                    Pedido = _pedido,
                    Ticket = _ticket,
                    TitularTicket = Global.TitularTicket
                };

                _itens.Add(_item);
            }
            if (_pedido.IdPedido.Equals("P-0001"))
            {

                var _ticket = new TicketServices().GetTicket("4", _pedido.IdPedido);
                var _item = new ItemPedidoModel
                {
                    IdItemPedido = "4",
                    Pedido = _pedido,
                    Ticket = _ticket,
                    TitularTicket = Global.TitularTicket
                };

                _itens.Add(_item);
            }
            return _itens;
        }

        public ItemPedidoModel GetItemPedidoById(String _idItemPedido){
            ItemPedidoModel _item = null;

            if (_idItemPedido.Equals("1"))
            {
                var _ticket = new TicketServices().GetTicket("1", Global.Pedido.IdPedido);
                _item = new ItemPedidoModel
                {
                    IdItemPedido = "1",
                    Pedido = Global.Pedido,
                    Ticket = _ticket,
                    TitularTicket = Global.TitularTicket
                };
            }
            if (_idItemPedido.Equals("2"))
            {
                var _ticket = new TicketServices().GetTicket("2", Global.Pedido.IdPedido);
                _item = new ItemPedidoModel
                {
                    IdItemPedido = "2",
                    Pedido = Global.Pedido,
                    Ticket = _ticket,
                    TitularTicket = Global.TitularTicket
                };


            }
            if (_idItemPedido.Equals("3"))
            {

                var _ticket = new TicketServices().GetTicket("3", Global.Pedido.IdPedido);
                _item = new ItemPedidoModel
                {
                    IdItemPedido = "3",
                    Pedido = Global.Pedido,
                    Ticket = _ticket,
                    TitularTicket = Global.TitularTicket
                };

            }
            if (_idItemPedido.Equals("4"))
            {

                var _ticket = new TicketServices().GetTicket("4", Global.Pedido.IdPedido);
                _item = new ItemPedidoModel
                {
                    IdItemPedido = "4",
                    Pedido = Global.Pedido,
                    Ticket = _ticket,
                    TitularTicket = Global.TitularTicket
                };

            }

            return _item;
        }
    }
}
