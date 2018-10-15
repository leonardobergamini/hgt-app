using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acr.UserDialogs;
using HGTAplicativo.Layers.Business;
using HGTAplicativo.Models;

namespace HGTAplicativo.ViewModels
{
    public class ItensDetailViewModel
    {
        public PedidoModel Pedido { get; set; }
        List<ItemPedidoModel> _lista = new List<ItemPedidoModel>();
        public ItensDetailViewModel(){

            var _itens = new ItemPedidoBusiness().GetAllItemPedido(Global.Pedido.IdPedido);

            foreach (var item in _itens)
            {
                ItemPedidoModel _item = new ItemPedidoModel();
                _item.ItemPedido = item;
                _item.Pedido = Global.Pedido;
                _item.Ticket = new TicketBusiness().GetTicketById(item.IdTicket);
                _item.Ticket.Setor = new SetorBusiness().GetSetorById(_item.Ticket.IdSetor);
                _item.TitularTicket = new TitularTicketBusiness().GetTitularTicketById(item.IdTitularTicket);

                _lista.Add(_item);

            }

            Pedido = Global.Pedido;
            ListaItens = _lista;
        }

        public async Task GetListaItens(){
            await Task.Run(() =>
            {

            });
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
