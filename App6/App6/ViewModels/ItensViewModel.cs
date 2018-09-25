using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using App6.Models;
using App6.Views;
using App6.Layers.Business;
using System.Collections;
using System.Collections.Generic;
using App6.Layers.Data;

namespace App6.ViewModels
{
    public class ItensViewModel
    {
        //public EventoModel Evento { get; set; }
        //public TicketModel Ticket { get; set; }
        public ItensViewModel()
        {
            var _pedidos = new PedidoBusiness().GetAllPedido();
            TicketModel _ticket = null;
            EventoModel _evento = null;

            //Como pegar as infos de cada evento do cliente?
            //O problema é quando temos mais de um pedido na lista. Como popular, individualmente, as linhas
            //do listview com as infos do evento de cada pedido?


            //if (_pedidos.Count == 1){
            //    var _pedido = _pedidos[0];
            //    var _itens = new ItemPedidoBusiness().GetAllItemPedido(_pedido);
            //    //var _itemPedido = new ItemPedidoBusiness().GetItemPedidoById(_itens[0].IdItemPedido);
            //    _ticket = new TicketBusiness().GetTicket(_pedido.IdPedido, _itens[0].IdItemPedido);
            //    _evento = new EventoBusiness().GetEventoByIdLocal(_ticket.Setor.Local.IdLocal);

            //}

            //Global.Evento = _evento;
            //Global.Ticket = _ticket;
            //Global.Pedidos = _pedidos;

            ListaPedido = new PedidoBusiness().GetAllPedido();
            int i = 0;
            //var _exibicao = new ExibicaoPedido();
            //_exibicao.UrlImagem = _evento.UrlImagem;

            ////var _exibicao = new ExibicaoPedido
            ////{
            ////    UrlImagem = _evento.UrlImagem

            ////};
            //ListaPedido.Add(_exibicao);
            //int i = 0;

        }
        private IList<PedidoModel> listaPedido;
        public IList<PedidoModel> ListaPedido{
            get{
                return listaPedido;
            }
            set{
                listaPedido = value;
            }
        }

    }
}