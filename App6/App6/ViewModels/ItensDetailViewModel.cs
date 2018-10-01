using System;
using System.Collections.Generic;
using App6.Layers.Business;
using App6.Models;

namespace App6.ViewModels
{
    public class ItensDetailViewModel
    {
        public ItensDetailViewModel()
        {
            List<ItemPedidoModel> _lista = new List<ItemPedidoModel>();

            var _itens = new ItemPedidoBusiness().GetAllItemPedido(Global.Pedido.IdPedido);

            foreach (var item in _itens)
            {
                ItemPedidoModel _item = new ItemPedidoModel();
                _item.ItemPedido = item;
                _item.Pedido = Global.Pedido;
                _item.Ticket = new TicketBusiness().GetTicketById(item.IdTicket);
                _item.Ticket.Setor = new SetorBusiness().GetSetorById(_item.Ticket.IdSetor);
                _item.TitularTicket = new TitularTicketBusiness().GetTitularTicketById(item.IdTitularTicket);
                _item.TitularTicket.NomeCompleto = _item.TitularTicket.PrimeiroNome + " " + _item.TitularTicket.Sobrenome;


                _lista.Add(_item);
    
            }
            ListaItens = _lista;
        }

        private IList<ItemPedidoModel> listaItens;
        public IList<ItemPedidoModel> ListaItens
        {
            get
            {
                return listaItens;
            }
            set
            {
                listaItens = value;
            }
        }
    }
}
