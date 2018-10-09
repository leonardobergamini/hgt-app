using System;
using System.Net.Http;
using HGTAplicativo.Models;
using Newtonsoft.Json;

namespace HGTAplicativo.Layers.Services
{
    public class SetorServices
    {
        public SetorModel GetSetorById(String _idSetor)
        {

            //Global.AccessToken = Global.Auth.access_token;
            //Global.Url = Global.Auth.instance_url;


            var _urlAccountApi = Global.Auth.instance_url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "Name, descricao__c, capacidade_total_setor__c, " +
                "capacidade_usada_setor__c, local__c FROM setor__c " +
                "WHERE Id = '" + _idSetor + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Auth.access_token);

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
