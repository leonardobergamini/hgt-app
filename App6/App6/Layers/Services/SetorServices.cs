using System;
using System.Collections.Generic;
using System.Net.Http;
using App6.Models;
using Newtonsoft.Json;

namespace App6.Layers.Services
{
    public class SetorServices
    {
        public SetorModel GetSetorById (String _idSetor){

            //var auth = new APIConfig().Auth();
            //var _accessToken = auth.access_token;
            //var _url = auth.instance_url;

            //Global.Auth = new APIConfig().Auth();
            Global.AccessToken = Global.Auth.access_token;
            Global.Url = Global.Auth.instance_url;


            var _urlAccountApi = Global.Url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "Name, descricao__c, capacidade_total_setor__c, " +
                "capacidade_usada_setor__c, local__c FROM setor__c " +
                "WHERE Id = '" + _idSetor+"'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.AccessToken);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var setorApi = JsonConvert.DeserializeObject<SetorModel>(conteudoResposta);

                return setorApi.records[0];
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }

        }
    }
}
