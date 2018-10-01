using System;
using System.Net.Http;
using App6.Models;
using Newtonsoft.Json;

namespace App6.Layers.Services
{
    public class FormaPagamentoServices
    {
        public FormaPagamentoModel GetFormaPagamento(UsuarioModel _usuario){

            var auth = new APIConfig().Auth();
            var _accessToken = auth.access_token;
            var _url = auth.instance_url;

            var _urlAccountApi = _url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "Contato__c, cartao_credito__c FROM forma_de_pagamento__c " +
                "WHERE Contato__c = '" + _usuario.IdCliente + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _accessToken);

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



            //if(Global.Usuario.IdCliente.Equals("003f400000ZHEbGAAX")){
            //    var _cartao = new CartaoCreditoServices().GetCartaoCredito("1");
            //    var _formaPg = new FormaPagamentoModel
            //    {
            //        IdFormaPagamento = "1",
            //        Usuario = Global.Usuario,
            //        CartaoCredito = _cartao
            //    };

            //    return _formaPg;
            //}else if (Global.Usuario.IdCliente.Equals("003f400000ZHEbVAAX"))
            //{
            //    var _cartao = new CartaoCreditoServices().GetCartaoCredito("2");
            //    var _formaPg = new FormaPagamentoModel
            //    {
            //        IdFormaPagamento = "2",
            //        Usuario = Global.Usuario,
            //        CartaoCredito = _cartao
            //    };

            //    return _formaPg;
            //}else{
            //    return null;
            //}


        }

        public FormaPagamentoServices()
        {
        }
    }
}
