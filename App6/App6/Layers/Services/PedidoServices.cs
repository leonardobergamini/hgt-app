using System;
using System.Collections.Generic;
using System.Net.Http;
using App6.Models;
using Newtonsoft.Json;

namespace App6.Layers.Services
{
    public class PedidoServices
    {
        public List<PedidoModel> GetAllPedido(String _idFormaPg){

            var auth = new APIConfig().Auth();
            var _accessToken = auth.access_token;
            var _url = auth.instance_url;


            var _urlAccountApi = _url + "/services/data/v43.0/query/?q= SELECT Id, Forma_de_pagamento__c, Evento__c " +
                "FROM pedido__c WHERE forma_de_pagamento__c = '" + _idFormaPg+"'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _accessToken);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var pedidosApi = JsonConvert.DeserializeObject<PedidoModel>(conteudoResposta);

                List<PedidoModel> _pedidos = new List<PedidoModel>();
                foreach (var item in pedidosApi.records)
                {
                    _pedidos.Add(item);
                }
                return _pedidos;
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }
        }


        //public PedidoModel GetPedidoById(String _idPedido){

        //    PedidoModel _pedido = new PedidoModel();
        //    var _user = Global.Usuario;
        //    var _formaPg = new FormaPagamentoServices().GetFormaPagamento(Global.Usuario);
        //    var _cartaoPg = new CartaoCreditoServices().GetCartaoCredito(Global.Usuario);

        //    if (_idPedido.Equals("P-0001")){
        //        _pedido = new PedidoModel
        //        {
        //            IdPedido = "P-0001",
        //            Usuario = _user,
        //            FormaPagamento = _formaPg
        //        };

        //    }
        //    if(_idPedido.Equals("P-0002")){
        //        _pedido = new PedidoModel
        //        {
        //            IdPedido = "P-0002",
        //            Usuario = _user,
        //            FormaPagamento = _formaPg
        //        };
        //    }
        //    if(_idPedido.Equals("P-0003")){
        //        _pedido = new PedidoModel
        //        {
        //            IdPedido = "P-0003",
        //            Usuario = _user,
        //            FormaPagamento = _formaPg
        //        };
        //    }

        //    return _pedido;
        //}

    }
}
