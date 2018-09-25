using System;
using System.Collections.Generic;
using App6.Models;

namespace App6.Layers.Business
{
    public class PedidoBusiness
    {
        public List<PedidoModel> GetAllPedido(){
            var _pedidos = new Services.PedidoServices().GetPedidoByUsuario(Global.Usuario, Global.CartaoCredito);
            return _pedidos;
        }
    }
}
