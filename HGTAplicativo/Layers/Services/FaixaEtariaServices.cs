using System;
using System.Net.Http;
using HGTAplicativo.Models;
using Newtonsoft.Json;

namespace HGTAplicativo.Layers.Services
{
    public class FaixaEtariaServices
    {
        public FaixaEtariaModel GetFaixaEtariaById(String _idFaixa)
        {
            //Global.AccessToken = Global.Auth.access_token;
            //Global.Url = Global.Auth.instance_url;

            var _urlAccountApi = Global.Auth.instance_url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "Name, descricao__c FROM faixa_etaria__c WHERE Id = '" + _idFaixa + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Auth.access_token);

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
