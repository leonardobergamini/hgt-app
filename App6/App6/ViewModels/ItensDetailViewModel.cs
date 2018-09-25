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
            ListaItens = new ItemPedidoBusiness().GetAllItemPedido(Global.Pedido);
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
