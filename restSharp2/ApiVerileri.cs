using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using RestSharp;
using System.IO;


namespace restSharp2
{
    class ApiVerileri
    {
        public string accestoken;
        public TextBox txtApiResponse;
        public TextBox txtJsonParse;
        public string responseJson;




        private JsonParse _jparser=new JsonParse();
       

        public ApiVerileri(string _token,TextBox txtRes, TextBox txtJsonParse)
        {
            accestoken = _token;
            txtApiResponse = txtRes;
            this.txtJsonParse = txtJsonParse;
        }

        public void apiVerileriGetir()
        {
            var baseUrl = "https://wakatime.com/api/";

          
            var restclient = new RestClient(baseUrl);
            RestRequest request = new RestRequest("v1/users/current?") { Method = Method.GET };
            // request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("token", accestoken);

           
            try
            {
            var  response = restclient.Execute(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {

                 responseJson = response.Content;
                    if (responseJson != null)
                    {
                           txtApiResponse.Text = responseJson;
                         
                         deserialiseJSON();
                    }
                }
                else
                {
                    txtApiResponse.Text = "İstek Başarısız";
                }
             }        
            catch (Exception ex)
            {
                txtApiResponse.Text = "Hata :"+ex.Message.ToString();

            }
           
        }
        public void deserialiseJSON()
        {
            var durum = string.Empty;         
            try
            {
                var jParse = JsonConvert.DeserializeObject<JsonParse>(responseJson);
                //jParse den çekmek istediklerinizi var olan kod yapınıza yani api verilerinie göre
                //aşağıdaki gibi yazdırsbilirsiniz..Aşağıda verilen herhhangi bir örnektir..
                //Siz de yapacağınız herhenagi proje ye göre kendi adımlarınızı izleyebilirsiniz..

                // durum = "  last_plugin_name :" + jParse.data.last_plugin_name.ToString();

                durum = "Kendi api verilerinizi çekebilirsiniz..";
                txtJsonParse.Text = durum;
            }
            catch (Exception ex)
            {              
                durum = "Olmadı :" + ex.Message.ToString();
                txtJsonParse.Text = durum;
            }
         
        }

    }
    
}
