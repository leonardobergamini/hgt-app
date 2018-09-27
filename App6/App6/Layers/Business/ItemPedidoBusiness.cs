﻿using System;
using System.Collections.Generic;
using App6.Models;
using App6.Layers.Services;

namespace App6.Layers.Business
{
    public class ItemPedidoBusiness
    {
        public List<ItemPedidoModel> GetAllItemPedido(PedidoModel _pedido){
            var _itens = new ItemPedidoServices().GetAllItensByPedido(_pedido);
            return _itens;
        }

        public ItemPedidoModel GetItemPedidoById(String _idItemPedido){
            var _itemPedido = new ItemPedidoServices().GetItemPedidoById(_idItemPedido);
            return _itemPedido;
        }
    }
}