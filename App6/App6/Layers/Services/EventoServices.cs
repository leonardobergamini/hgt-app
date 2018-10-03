using System;
using System.Net.Http;
using App6.Models;
using Newtonsoft.Json;

namespace App6.Layers.Services
{
    public class EventoServices
    {
        public EventoModel GetEventoById(String _idEvento){
            //var auth = new APIConfig().Auth();
            //var _accessToken = auth.access_token;
            //var _url = auth.instance_url;

            //Global.Auth = new APIConfig().Auth();
            Global.AccessToken = Global.Auth.access_token;
            Global.Url = Global.Auth.instance_url;

            var _urlAccountApi = Global.Url + "/services/data/v43.0/query/?q= SELECT Id, Name, " +
                "local__c, faixa_etaria__c, descricao__c, dt_inicio_evento__c, " +
                "dt_final_evento__c, dt_inicio_venda__c, dt_final_venda__c, url_img__c " +
                ", Hr_inicio_evento__c, Hr_termino_evento__c FROM evento__c WHERE Id ='" + _idEvento+"'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.AccessToken);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var eventoApi = JsonConvert.DeserializeObject<EventoModel>(conteudoResposta);


                return eventoApi.records[0];
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }

        }

        //Consultar Evento por nro. do Pedido
        public EventoModel GetEventoByPedido(String _idPedido){

            //var auth = new APIConfig().Auth();
            //var _accessToken = auth.access_token;
            //var _url = auth.instance_url;

            var _urlAccountApi = Global.Url + "/services/data/v43.0/query/?q= SELECT Evento__c " +
                "FROM pedido__c WHERE Id ='" + _idPedido + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.AccessToken);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var pedidoApi = JsonConvert.DeserializeObject<PedidoModel>(conteudoResposta);

                var _evento = pedidoApi.records[0].IdEvento;

                var _eventoRetorno = GetEventoById(_evento);
                return _eventoRetorno;
                
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }
        }
    }
}
