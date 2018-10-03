using System;
using System.Net.Http;
using System.Text;
using App6.Models;
using Newtonsoft.Json;

namespace App6.Layers.Services
{
    public class TitularTicketServices
    {
        public TitularTicketModel GetTitularTicketById(String _idTitular){
            //var auth = new APIConfig().Auth();
            //var _accessToken = auth.access_token;
            //var _url = auth.instance_url;

            Global.AccessToken = Global.Auth.access_token;
            Global.Url = Global.Auth.instance_url;


            var _urlAccountApi = Global.Url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "nome__c, sobrenome__c, dt_nascimento__c, cpf__c, telefone__c, " +
                "email__c FROM titular_ticket__c WHERE Id = '" + _idTitular + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.AccessToken);

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

        public String GetIdTitularByCpf(String _cpf)
        {
            //var auth = new APIConfig().Auth();
            //var _accessToken = auth.access_token;
            //var _url = auth.instance_url;

            Global.AccessToken = Global.Auth.access_token;
            Global.Url = Global.Auth.instance_url;


            var _urlAccountApi = Global.Url + "/services/data/v43.0/query/?q= SELECT Id " +
                "FROM titular_ticket__c WHERE cpf__c = '" + _cpf + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.AccessToken);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var titularApi = JsonConvert.DeserializeObject<TitularTicketModel>(conteudoResposta);

                return titularApi.records[0].IdTitular;
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }
        }

        public void SetTitularTicketAsync(String _idItem, TitularTicketModel _titularTicket)
        {
            //var auth = new APIConfig().Auth();
            //var _accessToken = auth.access_token;
            //var _url = auth.instance_url;

            Global.AccessToken = Global.Auth.access_token;
            Global.Url = Global.Auth.instance_url;


            var _urlAccountApi = Global.Url + "/services/data/v43.0/sobjects/" +
                                       "itens_pedido__c/"+_idItem;
            var _body = Newtonsoft.Json.JsonConvert.SerializeObject(_titularTicket);



            try{
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Authorization =
                          new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.AccessToken);

                StringContent _conteudo = new StringContent(_body, Encoding.UTF8, "application/json");

                var response = client.PostAsync(_urlAccountApi, _conteudo).Result;

                if (response.IsSuccessStatusCode)
                {
                    var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                    //dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(conteudoResposta);

                    Console.WriteLine("Id da Conta Gerado: " );

                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
            catch (Exception e){
                throw;
            }

        }
    }
}
