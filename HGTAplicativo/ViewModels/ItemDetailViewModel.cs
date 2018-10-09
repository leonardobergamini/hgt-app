using System;
using HGTAplicativo.Layers.Business;
using HGTAplicativo.Models;

namespace HGTAplicativo.ViewModels
{
    public class ItemDetailViewModel
    {
        public EventoModel Evento { get; set; }
        public TicketModel Ticket { get; set; }
        public TitularTicketModel TitularTicket { get; set; }

        public ItemDetailViewModel()
        {
            var _evento = new EventoBusiness().GetEventoByPedido(Global.Pedido.IdPedido);
            var _ticket = new TicketBusiness().GetTicketByIdItem(Global.ItemPedido.IdItemPedido);
            var _faixa = new FaixaEtariaBusiness().GetFaixaEtariaById(_evento.IdFaixaEtaria);
            var _local = new LocalBusiness().GetLocalById(_evento.IdLocal);
            var _titularTicket = new TitularTicketBusiness().GetTitularTicketById(Global.ItemPedido.IdTitularTicket);

            //Adicionar a FaixaEtaria no evento.
            _evento.FaixaEtaria = _faixa;

            //Adicionar o Local(Endereço)
            _evento.Local = _local;

            //Adicionar Titular do ticket
            TitularTicket = _titularTicket;

            Evento = _evento;
            Ticket = _ticket;
        }
    }
}
