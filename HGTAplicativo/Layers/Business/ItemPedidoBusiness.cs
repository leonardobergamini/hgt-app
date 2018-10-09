using System;
using System.Collections.Generic;
using HGTAplicativo.Layers.Services;
using HGTAplicativo.Models;

namespace HGTAplicativo.Layers.Business
{
    public class ItemPedidoBusiness
    {
        public List<ItemPedidoModel> GetAllItemPedido(String _idPedido)
        {
            var _itens = new ItemPedidoServices().GetAllItensByPedido(_idPedido);
            return _itens;
        }

        public ItemPedidoModel GetItemPedidoById(String _idItemPedido)
        {
            var _itemPedido = new ItemPedidoServices().GetItemPedidoById(_idItemPedido);
            return _itemPedido;
        }

    }
}
