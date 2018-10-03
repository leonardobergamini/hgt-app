using System;
using System.Net.Http;
using App6.Models;
using Newtonsoft.Json;

namespace App6.Layers.Services
{
    public class LocalServices
    {
        public LocalModel GetLocalById(String _idLocal)
        {
            //var auth = new APIConfig().Auth();
            //var _accessToken = auth.access_token;
            //var _url = auth.instance_url;

            //Global.Auth = new APIConfig().Auth();
            Global.AccessToken = Global.Auth.access_token;
            Global.Url = Global.Auth.instance_url;

            var _urlAccountApi = Global.Url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "Name, descricao__c, capacidade_total__c, rua__c, cidade__c, " +
                "estado__c, CEP__c, pais__c, complemento__c, numero__c " +
                "FROM Local__c WHERE Id ='" + _idLocal + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.AccessToken);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var localApi = JsonConvert.DeserializeObject<LocalModel>(conteudoResposta);

                return localApi.records[0];
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }
        }
    }
}
