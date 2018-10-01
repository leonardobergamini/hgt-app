using System;
using System.Collections.Generic;
using App6.Layers.Services;
using App6.Models;

namespace App6.Layers.Business
{
    public class EventoBusiness
    {
        public EventoModel GetEventoByPedido(String _idPedido){

            var _evento = new EventoServices().GetEventoByPedido(_idPedido);
            return _evento;
        }

        public EventoModel GetEventoById(String _idEvento){

            var _evento = new EventoServices().GetEventoById(_idEvento);
            return _evento;
        }
    }
}
