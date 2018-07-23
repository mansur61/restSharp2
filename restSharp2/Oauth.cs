using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace restSharp2
{
    class Oauth
    {

        public TextBox txtUrl;
        public Oauth(TextBox txtUrl)
        {
            this.txtUrl = txtUrl;
        }
        public void outhCode(string client_id, string response_type, string state, string scope, string redirect_uri)
        {
             try
             {


            var baseUrl = "https://wakatime.com";
            var restclient = new RestClient(baseUrl);

            RestRequest request = new RestRequest("/oauth/authorize?") { Method = Method.GET };
            // request.AddHeader("Accept", "application/json");
            // request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("response_type", response_type);
            request.AddParameter("client_id", client_id);
            request.AddParameter("redirect_uri", redirect_uri);
            request.AddParameter("scope", scope);
            request.AddParameter("state", state);
               

             var url = restclient.BuildUri(request).ToString();
               
             var response = restclient.Execute(request);
                txtUrl.Text = response.ResponseUri.ToString();
                if (HttpStatusCode.OK == response.StatusCode)
                {
                       // txtUrl.Text = url;
                        var responseJson = response.Content;
                   // txtUrl.Text = restclient.ToString();
                    if (responseJson != null)
                    {                       
                       Process.Start(txtUrl.Text);
                      
                    }
                    else
                    {
                        txtUrl.Text ="responseJson içeriği Boşşş" ;
                    }
                
                }
                else
                {
                        txtUrl.Text="istek Başarısız :" + response.StatusCode;
                }
            
             }
             catch (Exception ex)
             {
                txtUrl.Text="Hata :" +ex.Message.ToString();
             }

        }
    }
}
