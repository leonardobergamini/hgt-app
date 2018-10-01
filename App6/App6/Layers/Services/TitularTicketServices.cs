using System;
using System.Net.Http;
using App6.Models;
using Newtonsoft.Json;

namespace App6.Layers.Services
{
    public class TitularTicketServices
    {
        public TitularTicketModel GetTitularTicketById(String _idTitular){
            var auth = new APIConfig().Auth();
            var _accessToken = auth.access_token;
            var _url = auth.instance_url;


            var _urlAccountApi = _url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "nome__c, sobrenome__c, dt_nascimento__c, cpf__c, telefone__c, " +
                "email__c FROM titular_ticket__c WHERE Id = '" + _idTitular + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _accessToken);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var titularApi = JsonConvert.DeserializeObject<TitularTicketModel>(conteudoResposta);

                return titularApi.records[0];
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }
        }

    }
}
