using System;
using System.Collections.Generic;
using HGTAplicativo.Layers.Services;
using HGTAplicativo.Models;

namespace HGTAplicativo.Layers.Business
{
    public class PedidoBusiness
    {
        public List<PedidoModel> GetAllPedidoAndEventos(String _idFormaPg)
        {
            var _pedidos = new PedidoServices().GetAllPedido(_idFormaPg);
            List<PedidoModel> _pedidosRetorno = new List<PedidoModel>();

            foreach (var pedido in _pedidos)
            {
                
                pedido.Evento = new EventoBusiness().GetEventoById(pedido.IdEvento);
                pedido.Evento.Local = new LocalServices().GetLocalById(pedido.Evento.IdLocal);

                _pedidosRetorno.Add(pedido);

            }

            return _pedidosRetorno;
        }
    }
}
