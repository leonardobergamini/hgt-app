using System;
using HGTAplicativo.Layers.Services;
using HGTAplicativo.Models;

namespace HGTAplicativo.Layers.Business
{
    public class EventoBusiness
    {
        public EventoModel GetEventoByPedido(String _idPedido)
        {

            var _evento = new EventoServices().GetEventoByPedido(_idPedido);


            if (_evento.DtFinalEvento == DateTime.Now.Date)
            {
                _evento.Status = false;
                }
            else if (_evento.DtFinalEvento > DateTime.Now.Date)
            {
                _evento.Status = false;
            }
            else if (_evento.DtFinalEvento < DateTime.Now.Date)
            {
                _evento.Status = true;            
            }


            return _evento;
        }

        public EventoModel GetEventoById(String _idEvento)
        {

            var _evento = new EventoServices().GetEventoById(_idEvento);

            if (_evento.DtFinalEvento == DateTime.Now.Date)
            {
                _evento.Status = false;
            }
            else if (_evento.DtFinalEvento > DateTime.Now.Date)
            {
                _evento.Status = false;
            }
            else if (_evento.DtFinalEvento < DateTime.Now.Date)
            {
                _evento.Status = true;
            }

            return _evento;
        }

        public EventoModel GetEvento(String _idPedido){
            EventoModel _evento = new EventoModel();
            foreach (var pedido in Global.Pedidos)
            {
                if (pedido.IdPedido.Equals(_idPedido))
                {
                    foreach (var evento in Global.Eventos)
                    {
                        if (pedido.IdEvento.Equals(evento.IdEvento))
                        {
                            _evento = evento;
                        }
                    }
                }
            }

            return _evento;
        }
    }
}
