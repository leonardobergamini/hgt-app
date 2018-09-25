using System;
using System.Collections.Generic;
using App6.Layers.Data;
using App6.Layers.Services;
using App6.Models;

namespace App6.Layers.Business
{
    public class TicketBusiness
    {
        public List<TicketModel> GetAllTicketByUsuario(UsuarioModel _usuario){
            List<TicketModel> _tickets = new List<TicketModel>();
            List<ItemPedidoModel> _itensPedido = new List<ItemPedidoModel>();

            //List<List<TicketModel>> listaItens = new List<List<TicketModel>>();

            foreach (var pedido in Global.Pedidos)
            {
                _itensPedido = new ItemPedidoServices().GetAllItensByPedido(pedido);

                foreach (var item in _itensPedido)
                {
                    var _ticketSub = new TicketServices().GetTicket(item.IdItemPedido, pedido.IdPedido);
                    _tickets.Add(_ticketSub);
                }
            }
            return _tickets;
        }

        public TicketModel GetTicket(String _idPedido, String _idItem)
        {
            TicketModel _ticket = new TicketModel();

            _ticket = new TicketServices().GetTicket(_idItem, _idPedido);

            return _ticket;
        }

        public TicketModel GetTicketBySetor(String _idSetor){

            var _ticket = new TicketServices().GetTicketByIdSetor(_idSetor);

            return _ticket;
        }

    }

}
