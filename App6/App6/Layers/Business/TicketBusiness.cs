using System;
using System.Collections.Generic;
using App6.Layers.Data;
using App6.Layers.Services;
using App6.Models;

namespace App6.Layers.Business
{
    public class TicketBusiness
    {
        public TicketBusiness(){}

        public List<TicketModel> GetAllTicketByUsuario(UsuarioModel _usuario){
            List<TicketModel> _tickets = new List<TicketModel>();
            List<ItensPedidoModel> _itensPedido = new List<ItensPedidoModel>();

            //List<List<TicketModel>> listaItens = new List<List<TicketModel>>();

            foreach (var pedido in Global.Pedidos)
            {
                _itensPedido = new ItensPedidoServices().GetAllItensByPedido(pedido);

                foreach (var item in _itensPedido)
                {
                    var _ticketSub = new TicketServices().GetTickets(item.IdItemPedido, pedido.IdPedido);
                    _tickets.Add(_ticketSub);
                }
            }
            return _tickets;
        }
        public TicketModel GetTicket()
        {
            //var _local = new LocalServices().GetLocal(Global.Evento.Local.IdLocal);
            //var _setor = new SetorServices().GetSetoresByIdLocal(_local.IdLocal);
            List<ItensPedidoModel> _itens = new List<ItensPedidoModel>();
            TicketModel _ticket = new TicketModel();

            foreach (var pedido in Global.Pedidos)
            {
                _itens = new ItensPedidoServices().GetAllItensByPedido(pedido);

                foreach (var item in _itens)
                {
                    _ticket = new TicketServices().GetTickets(item.IdItemPedido, pedido.IdPedido);
                }
            }
            return _ticket;
        }

    }

}
