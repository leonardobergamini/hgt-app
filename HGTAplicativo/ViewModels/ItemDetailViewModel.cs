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
            var _evento = new EventoBusiness().GetEvento(Global.Pedido.IdPedido);

            //Consultas API
            var _ticket = new TicketBusiness().GetTicketByIdItem(Global.ItemPedido.IdItemPedido);
            var _faixa = new FaixaEtariaBusiness().GetFaixaEtariaById(_evento.IdFaixaEtaria);
            var _titularTicket = new TitularTicketBusiness().GetTitularTicketById(Global.ItemPedido.IdTitularTicket);

            //Adicionar a FaixaEtaria no evento.
            _evento.FaixaEtaria = _faixa;

            //Adicionar Titular do ticket
            TitularTicket = _titularTicket;

            if(_evento.Status != true){
                _ticket.Status = "ATIVO";
                Ticket = _ticket;
                Evento = _evento;
            }
            else{
                _ticket.Status = "VENCIDO";
                Ticket = _ticket;
                Evento = _evento;
            }

        }
    }
}
