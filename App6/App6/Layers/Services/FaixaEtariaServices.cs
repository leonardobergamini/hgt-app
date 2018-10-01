using System;
using System.Collections.Generic;
using System.Net.Http;
using App6.Models;
using Newtonsoft.Json;

namespace App6.Layers.Services
{
    public class FaixaEtariaServices
    {

        public FaixaEtariaModel GetFaixaEtariaById(String _idFaixa){

            var auth = new APIConfig().Auth();
            var _accessToken = auth.access_token;
            var _url = auth.instance_url;

            var _urlAccountApi = _url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "Name, descricao__c FROM faixa_etaria__c WHERE Id = '" + _idFaixa + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _accessToken);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var faixaApi = JsonConvert.DeserializeObject<FaixaEtariaModel>(conteudoResposta);

                return faixaApi.records[0];

            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }


        }

    }
}
