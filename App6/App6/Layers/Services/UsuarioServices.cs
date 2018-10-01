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
        public UsuarioModel GetLogin(String _usuario, String _senha)
        {
            var auth = new APIConfig().Auth();
            var _accessToken = auth.access_token;
            var _url = auth.instance_url;


            var _urlAccountApi = _url + "/services/data/v43.0/query/?q= SELECT+Id+," +
                "+FirstName+,+LastName+,+Birthdate+,+cpf__c+,+Email+,+MobilePhone" +
                "+,+rg__c+," +"+usuario__c+,+senha__c+,+MailingStreet+,+MailingCity+," +
                "+MailingState+,+MailingPostalCode+FROM+Contact+" +
                "WHERE+usuario__c+LIKE+'" + _usuario +
                "'+AND+senha__c+LIKE+'" + _senha + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _accessToken);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var usersApi = JsonConvert.DeserializeObject<UsuarioModel>(conteudoResposta);

                String ano = usersApi.records[0].DtNascimento.Substring(0, 4);
                String mes = usersApi.records[0].DtNascimento.Substring(5, 2);
                String dia = usersApi.records[0].DtNascimento.Substring(8, 2);

                usersApi.records[0].DtNascimento = dia + "/" + mes + "/" + ano;

                return usersApi.records[0];
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }
        }
    }
}


