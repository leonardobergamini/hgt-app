using System;
using System.Collections.Generic;
using App6.Layers.Services;
using App6.Models;

namespace App6.Layers.Business
{
    public class EventoBusiness
    {
        public List<EventoModel> GetEventos(){

            var _formaPg = new FormaPagamentoServices().GetFormaPagamento(Global.Usuario);
            Global.FormaPagamento = _formaPg;
            var _cartao = new CartaoCreditoServices().GetCartaoCredito(_formaPg.IdFormaPagamento);
            Global.CartaoCredito = _cartao;
            var _pedidos = new PedidoServices().GetPedidoByUsuario(Global.Usuario, _cartao);
            Global.Pedidos = _pedidos;

            List<TicketModel> _tickets = new List<TicketModel>();
            List<ItensPedidoModel> _itensPedido = new List<ItensPedidoModel>();
            List<SetorModel> _setores = new List<SetorModel>();
            List<LocalModel> _locais = new List<LocalModel>();
            List<EventoModel> _eventos = new List<EventoModel>();

            foreach (var pedido in _pedidos)
            {
                _tickets.Clear();
                _itensPedido.Clear();
                _setores.Clear();
                _locais.Clear();

                _itensPedido = new ItensPedidoServices().GetAllItensByPedido(pedido);

                foreach (var item in _itensPedido)
                {
                    var _ticketSub = new TicketServices().GetTickets(item.IdItemPedido, pedido.IdPedido);
                    _tickets.Add(_ticketSub);
                }
                foreach (var ticket in _tickets)
                {
                    var _setor = ticket.Setor;
                    _setores.Add(_setor);


                    foreach (var setor in _setores)
                    {
                        var _local = setor.Local;
                        _locais.Add(_local);
                    }
                    _setores.Clear();
                    foreach (var local in _locais)
                    {
                        var _evento = new EventoServices().GetEvento(local.IdLocal);
                        _eventos.Add(_evento);

                    }
                    _locais.Clear();
                }
            }
            //Global.Eventos = _eventos;
            return _eventos;
        }
    }
}
