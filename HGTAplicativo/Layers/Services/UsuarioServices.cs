﻿using System;
using System.Net.Http;
using HGTAplicativo.Models;
using Newtonsoft.Json;

namespace HGTAplicativo.Layers.Services
{
    public class UsuarioServices
    {
        public UsuarioModel GetLogin(String _usuario, String _senha)
        {
            System.Diagnostics.Debug.Print("UsuarioServices" + DateTime.Now);

            Global.Auth = new APIConfig().Auth();
            //Global.AccessToken = Global.Auth.access_token;
            //Global.Url = Global.Auth.instance_url;


            var _urlAccountApi = Global.Auth.instance_url + "/services/data/v43.0/query/?q= SELECT+Id+," +
                "+FirstName+,+LastName+,+Birthdate+,+cpf__c+,+Email+,+MobilePhone" +
                "+,+rg__c+,+usuario__c+,+senha__c+,+MailingStreet+,+MailingCity+," +
                "+MailingState+,+MailingPostalCode+FROM+Contact+" +
                "WHERE+usuario__c+LIKE+'" + _usuario +
                "'+AND+senha__c+LIKE+'" + _senha + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Auth.access_token);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var usersApi = JsonConvert.DeserializeObject<UsuarioModel>(conteudoResposta);

                return usersApi.records[0];
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }finally{
                System.Diagnostics.Debug.Print("UsuarioServices" + DateTime.Now);
            }
        }

    }
}
