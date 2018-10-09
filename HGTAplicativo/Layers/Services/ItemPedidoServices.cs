using System;
using System.Collections.Generic;
using System.Net.Http;
using HGTAplicativo.Models;
using Newtonsoft.Json;

namespace HGTAplicativo.Layers.Services
{
    public class ItemPedidoServices
    {
        public List<ItemPedidoModel> GetAllItensByPedido(String _idPedido)
        {

            //Global.AccessToken = Global.Auth.access_token;
            //Global.Url = Global.Auth.instance_url;


            var _urlAccountApi = Global.Auth.instance_url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "Pedido__c, titular_ticket__c, ticket__c FROM itens_pedido__c " +
                "WHERE Pedido__c = '" + _idPedido + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Auth.access_token);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var itensApi = JsonConvert.DeserializeObject<ItemPedidoModel>(conteudoResposta);

                List<ItemPedidoModel> _itens = new List<ItemPedidoModel>();
                foreach (var item in itensApi.records)
                {
                    _itens.Add(item);
                }

                return _itens;
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }

        }

        public ItemPedidoModel GetItemPedidoById(String _idItemPedido)
        {
            ItemPedidoModel _item = null;
            foreach (var item in Global.ItensPedidos)
            {
                if (item.IdItemPedido.Equals(_idItemPedido))
                {
                    _item = item;
                }
            }
            return _item;
        }
    }
}
