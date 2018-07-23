using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Net;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace restSharp2
{
    class TokenAl
    {
        public TextBox txtSonuc;
        public TokenAl(TextBox txtToken)
        {
            this.txtSonuc = txtToken;
          
        }
        public void  tokenAl(string client_id,string client_secret,string grant_type,
            string oauthCode,string redirect_uri,string state)
        {
            var baseUrl = "https://wakatime.com";

          
            var restclient = new RestClient(baseUrl);
            RestRequest request = new RestRequest("/oauth/token") { Method = Method.POST };
           // request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("code", oauthCode);
            request.AddParameter("client_id", client_id);
            request.AddParameter("client_secret", client_secret);
            request.AddParameter("redirect_uri", redirect_uri);
            request.AddParameter("grant_type", grant_type);
            request.AddParameter("state", grant_type);

            var response = restclient.Execute(request);           
            var responseJson = response.Content;
            txtSonuc.Text = responseJson;

        }
    }
}
