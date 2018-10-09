using System;
using System.Net.Http;
using HGTAplicativo.Models;
using Newtonsoft.Json;

namespace HGTAplicativo.Layers.Services
{
    public class TicketServices
    {
        public TicketModel GetTicketById(String _idTicket){

            //Global.AccessToken = Global.Auth.access_token;
            //Global.Url = Global.Auth.instance_url;

            var _urlAccountApi = Global.Auth.instance_url + "/services/data/v43.0/query/?q= SELECT Id, Name, " +
                "preco__c , cod_ingresso__c, setor__c FROM ticket__c " +
                "WHERE Id = '" + _idTicket + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Auth.access_token);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var ticketApi = JsonConvert.DeserializeObject<TicketModel>(conteudoResposta);

                return ticketApi.records[0];
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }

        }

        public TicketModel GetTicketByIdItem(String _idItem){

            //Global.AccessToken = Global.Auth.access_token;
            //Global.Url = Global.Auth.instance_url;


            var _urlAccountApi = Global.Auth.instance_url + "/services/data/v43.0/query/?q= SELECT ticket__c" +
                " FROM itens_pedido__c WHERE Id = '" + _idItem + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Auth.access_token);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var ticketApi = JsonConvert.DeserializeObject<ItemPedidoModel>(conteudoResposta);
                var _idTicket = ticketApi.records[0].IdTicket;

                var _ticket = GetTicketById(_idTicket);

                return _ticket;
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }

        }
    }
}
