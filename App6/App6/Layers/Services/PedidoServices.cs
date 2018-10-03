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

            //var auth = new APIConfig().Auth();
            //var _accessToken = auth.access_token;
            //var _url = auth.instance_url;

            //Global.Auth = new APIConfig().Auth();
            Global.AccessToken = Global.Auth.access_token;
            Global.Url = Global.Auth.instance_url;


            var _urlAccountApi = Global.Url + "/services/data/v43.0/query/?q= SELECT Id, Forma_de_pagamento__c, Evento__c " +
                "FROM pedido__c WHERE forma_de_pagamento__c = '" + _idFormaPg+"'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.AccessToken);

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

    }
}
