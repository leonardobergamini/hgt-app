﻿using System;
using System.Collections.Generic;
using App6.Layers.Business;
using App6.Layers.Services;
using App6.Models;

namespace App6.ViewModels
{
    public class ItemDetailViewModel
    {
        public EventoModel Evento { get; set; }
        public TicketModel Ticket { get; set; }

        public ItemDetailViewModel(){
            var _evento = new EventoBusiness().GetEventoByPedido(Global.Pedido.IdPedido);
            var _ticket = new TicketBusiness().GetTicketByIdItem(Global.ItemPedido.IdItemPedido);
            var _faixa = new FaixaEtariaBusiness().GetFaixaEtariaById(_evento.IdFaixaEtaria);
            var _local = new LocalBusiness().GetLocalById(_evento.IdLocal);

            //Adicionar a FaixaEtaria no evento.
            _evento.FaixaEtaria = _faixa;

            //Adicionar o Local(Endereço)
            _evento.Local = _local;

            Evento = _evento;
            Ticket = _ticket;
        }
    }
}
