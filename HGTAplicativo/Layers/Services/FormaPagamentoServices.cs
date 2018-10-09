using System;
using System.Net.Http;
using HGTAplicativo.Models;
using Newtonsoft.Json;

namespace HGTAplicativo.Layers.Services
{
    public class FormaPagamentoServices
    {
        public FormaPagamentoModel GetFormaPagamento(UsuarioModel _usuario)
        {

            //Global.AccessToken = Global.Auth.access_token;
            //Global.Url = Global.Auth.instance_url;

            var _urlAccountApi = Global.Auth.instance_url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "Contato__c, cartao_credito__c FROM forma_de_pagamento__c " +
                "WHERE Contato__c = '" + _usuario.IdCliente + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Auth.access_token);

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
    }
}
