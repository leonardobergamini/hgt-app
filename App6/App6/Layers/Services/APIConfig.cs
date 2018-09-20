using System;
using System.Collections.Generic;
using System.Net.Http;

namespace App6.Layers.Services
{
    public class APIConfig
    {
        static String securityKey = "Hk3Z4XmQjFOyOGHUEgqmDUUC";
        static String clientSecret = "1305799021171533032";
        static String clientId = "3MVG9zlTNB8o8BA3rgXhHthKCwzZDvZtXGphpAOExvWOqmwKlWP0kYsKifG0jdFXnEsXDSkanRbTHyOS_8e9Q";
        static String grantAcess = "password";
        static String userName = "leonardo@fiap.com";
        static String password = "Bergamini@2018" + securityKey;
        public String urlSalesForceAuth = "https://login.salesforce.com/services/oauth2/token";

        public String access_token { get; set; }
        public String instance_url { get; set; }
        public String token_type { get; set; }

        public Dictionary<String, String> AcessarAPI(){
            var parameters = new Dictionary<String, String> {
                { "grant_type" , grantAcess },
                { "username" , userName },
                { "password" , password },
                { "client_id", clientId },
                { "client_secret", clientSecret },
            };

            return parameters;

        }
    }
}
