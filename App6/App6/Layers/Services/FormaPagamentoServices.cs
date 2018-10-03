using System;
using System.Net.Http;
using App6.Models;
using Newtonsoft.Json;

namespace App6.Layers.Services
{
    public class FormaPagamentoServices
    {
        public FormaPagamentoModel GetFormaPagamento(UsuarioModel _usuario){

            //var auth = new APIConfig().Auth();
            //var _accessToken = auth.access_token;
            //var _url = auth.instance_url;

            //Global.Auth = new APIConfig().Auth();
            Global.AccessToken = Global.Auth.access_token;
            Global.Url = Global.Auth.instance_url;

            var _urlAccountApi = Global.Url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "Contato__c, cartao_credito__c FROM forma_de_pagamento__c " +
                "WHERE Contato__c = '" + _usuario.IdCliente + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.AccessToken);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var formaApi = JsonConvert.DeserializeObject<FormaPagamentoModel>(conteudoResposta);

                return formaApi.records[0];
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }

        }

        public FormaPagamentoServices()
        {
        }
    }
}
