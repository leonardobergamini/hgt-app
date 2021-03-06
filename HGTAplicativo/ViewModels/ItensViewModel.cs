﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using HGTAplicativo.Layers.Business;
using HGTAplicativo.Models;
using System.Threading;
using System.Threading.Tasks;
using Acr.UserDialogs;

namespace HGTAplicativo.ViewModels
{
    public class ItensViewModel
    {
        public ObservableCollection<PedidoAgrupadoModel> PedidoAgrupado { get; set; }

        public ItensViewModel()
        {
            PedidoAgrupado = new ObservableCollection<PedidoAgrupadoModel>();
            PedidoAgrupadoModel _pedidoAntigo = new PedidoAgrupadoModel() { LongName = "Antigos" };
            PedidoAgrupadoModel _pedidoNovo = new PedidoAgrupadoModel() { LongName = "Novos" };
            PedidoAgrupadoModel _pedidoHoje = new PedidoAgrupadoModel() { LongName = "É hoje!" };

            var _pedidos = new PedidoBusiness().GetAllPedidoAndEventos(Global.FormaPagamento.IdFormaPagamento);

            foreach (var pedido in _pedidos)
            {
                var _dia = pedido.Evento.DtInicioEvento.Day;
                var _mes = pedido.Evento.DtInicioEvento.Month;
                var _ano = pedido.Evento.DtInicioEvento.Year;

                if (_ano > DateTime.Now.Year)
                {
                    //PedidoNovo
                    _pedidoNovo.Add(pedido);

                }
                else if (_ano == DateTime.Now.Year)
                {
                    if (_mes == DateTime.Now.Month)
                    {
                        if (_dia == DateTime.Now.Day)
                        {
                            //PedidoHoje
                            _pedidoHoje.Add(pedido);
                        }
                        else if (_dia > DateTime.Now.Day)
                        {
                            //PedidoNovo
                            _pedidoNovo.Add(pedido);
                        }
                        else
                        {
                            //PedidoAntigo
                            _pedidoAntigo.Add(pedido);
                        }

                    }
                    else if (_mes > DateTime.Now.Month)
                    {
                        //PedidoNovo
                        _pedidoNovo.Add(pedido);

                    }
                    else
                    {
                        //PedidoAntigo
                        _pedidoAntigo.Add(pedido);
                    }

                }
                else
                {
                    //PedidoAntigo
                    _pedidoAntigo.Add(pedido);
                }
            }

            PedidoAgrupado.Add(_pedidoNovo);
            PedidoAgrupado.Add(_pedidoAntigo);
            PedidoAgrupado.Add(_pedidoHoje);

            ListaPedido = PedidoAgrupado;
       
        }

        private IList<PedidoAgrupadoModel> listaPedido;
        public IList<PedidoAgrupadoModel> ListaPedido
        {
            get
            {
                return listaPedido;
            }
            set
            {
                listaPedido = value;
            }
        }
    }
}
