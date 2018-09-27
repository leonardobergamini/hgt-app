using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using App6.Models;
using App6.Views;
using App6.Layers.Business;
using System.Collections;
using System.Collections.Generic;
using App6.Layers.Data;

namespace App6.ViewModels
{
    public class ItensViewModel
    {
        public ObservableCollection<PedidoAgrupadoModel> PedidoAgrupado { get; set; }

        public ItensViewModel()
        {
            PedidoAgrupado = new ObservableCollection<PedidoAgrupadoModel>();
            PedidoAgrupadoModel _pedidoAntigo = new PedidoAgrupadoModel(){LongName = "Antigos"};
            PedidoAgrupadoModel _pedidoNovo = new PedidoAgrupadoModel(){LongName = "Novos"};
            PedidoAgrupadoModel _pedidoHoje = new PedidoAgrupadoModel() { LongName = "É hoje!" };

            var _pedidos = new PedidoBusiness().GetAllPedidoAndEventos();

            foreach (var pedido in _pedidos)
            {
                var _dia = pedido.Evento.DtInicioEvento.Day;
                var _mes = pedido.Evento.DtInicioEvento.Month;
                var _ano = pedido.Evento.DtInicioEvento.Year;
                //19/12/2018
                if (_ano >= DateTime.Now.Year)
                {
                    if(_mes == DateTime.Now.Month)
                    {
                        if(_dia == DateTime.Now.Day){
                            //PedidoHoje
                            _pedidoHoje.Add(pedido);
                        }else if(_dia > DateTime.Now.Day)
                        {
                            //PedidoNovo
                            _pedidoNovo.Add(pedido);
                        }else{
                            //PedidoAntigo
                            _pedidoAntigo.Add(pedido);
                        }

                    }else if(_mes > DateTime.Now.Month)
                    {
                        //PedidoNovo
                        _pedidoNovo.Add(pedido);
                       
                    }else
                    {
                        //PedidoAntigo
                        _pedidoAntigo.Add(pedido);
                    }

                }else 
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
        public IList<PedidoAgrupadoModel> ListaPedido{
            get{
                return listaPedido;
            }
            set{
                listaPedido = value;
            }
        }

    }
}