using System;
using App6.Layers.Services;
using System.Net.Http;
using App6.Models;
using Xamarin.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace App6.Layers.Services
{
    public class UsuarioServices
    {
        public APIConfig Auth(){

            APIConfig apiConfig = new APIConfig();

            var parameters = apiConfig.AcessarAPI();
            var encodedContent = new FormUrlEncodedContent(parameters);
            HttpClient client = new HttpClient();
            var response = client.PostAsync(apiConfig.urlSalesForceAuth, encodedContent).Result;

            if (response.IsSuccessStatusCode)
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var json = JsonConvert.DeserializeObject<APIConfig>(conteudoResposta);
                return json;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public UsuarioModel GetLogin(String _usuario, String _senha)
        {
            var _accessToken = Auth().access_token;
            var _url = Auth().instance_url;


            var _urlAccountApi = _url + "/services/data/v43.0/query/?q=SELECT+Id" +
                                        "+,+Nome__c+,+Sobrenome__c+,+Dt_nascimento__c+,+CPF__c+,+E_mail__c+,+Celular__c+,+RG__c" +
                                        "+,+Nm_Usuario__c +,+Senha__c + FROM+Conta__c+" +
                "WHERE+Nm_Usuario__c+LIKE+'" + _usuario + "'+AND+Senha__c+LIKE+'" + _senha + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _accessToken);

            var response = client.GetAsync(_urlAccountApi).Result;

            try{
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var usersApi = JsonConvert.DeserializeObject<UsuarioModel>(conteudoResposta);

                String ano = usersApi.records[0].Dt_nascimento__c.Substring(0, 4);
                String mes = usersApi.records[0].Dt_nascimento__c.Substring(5, 2);
                String dia = usersApi.records[0].Dt_nascimento__c.Substring(8, 2);

                usersApi.records[0].Dt_nascimento__c = dia + "/" + mes + "/" + ano;

                return usersApi.records[0];

            }catch(Exception e){
                //(response.IsSuccessStatusCode)
                throw;
            }
        }
    }
}

