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
            System.Diagnostics.Debug.Print("PedidoBusiness " + DateTime.Now);
            var _pedidos = new PedidoServices().GetAllPedido(_idFormaPg);
            Global.Pedidos = _pedidos;
            List<PedidoModel> _pedidosRetorno = new List<PedidoModel>();
            List<EventoModel> _eventos = new List<EventoModel>();

            foreach (var pedido in _pedidos)
            {
                var _evento = new EventoBusiness().GetEventoById(pedido.IdEvento);
                pedido.Evento = _evento;
                pedido.Evento.Local = new LocalServices().GetLocalById(pedido.Evento.IdLocal);

                _eventos.Add(pedido.Evento);
                Global.Eventos = _eventos;
                _pedidosRetorno.Add(pedido);

            }
            System.Diagnostics.Debug.Print("PedidoBusiness " + DateTime.Now);
            return _pedidosRetorno;
        }
    }
}
