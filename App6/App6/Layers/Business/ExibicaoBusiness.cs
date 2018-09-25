using System;
using System.Collections.Generic;
using App6.Models;

namespace App6.Layers.Business
{
    public class ExibicaoBusiness
    {
        public List<ExibicaoPedido> GetExibicaoPedidos(){

            List<ExibicaoPedido> _listaExibicao = new List<ExibicaoPedido>();

            var _view = new ExibicaoPedido
            {
                Evento = Global.Evento,
                Ticket = Global.Ticket,
                Pedidos = Global.Pedidos
            };

            _listaExibicao.Add(_view);

            return _listaExibicao;

        }
    }
}
