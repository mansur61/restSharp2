using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace restSharp2
{
    public partial class Form1 : Form
    {
        private static Oauth auth ;
        private static TokenAl _token ;
        private static ApiVerileri apiData;
        public string JSON;


        #region
        /*
         * Domaini belirttiğim web sitesinde kendinize özel uygulama oluşturun..
         * O uygulamaya ait bilgilerinizi aşağıya girin..
         * Ama bu işe başlamadan evvel öncelikle web istesinin dökümanlaının okuyup anlamaya çalışın
         * üzerine bazı kavramların araştırmalar yapın..
         * 
        private static string client_id =App_ID;
        public static string client_secret=App_Secret;

        private static string response_type = "code";//Bu böyle olsun
        private static string redirect_uri =code değerini alabileceğiniz server tarafından tanınlı geçerli 
        callback url dir..
          
        private static string scope = Api verilerinize ulaşmak istediğiniz web sitesinini dökümanlarından bakabilirsiniz..
        private static string state = Api verilerinize ulaşmak istediğiniz web sitesinini dökümanlarından bakabilirsiniz..
                                    3. kişi lere karşı alınan bir önlemdir. Kullanmanızı tavsiye ederim..
        private static string grant_type =Api verilerinize ulaşmak istediğiniz web sitesinini dökümanlarından bakabilirsiniz..

            
        */
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
       
        #region
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            auth = new Oauth(txtUrl);
            auth.outhCode(txtClientID.Text.ToString(), txtResponseType.Text.ToString(),
                txtState.Text.ToString(), txtScope.Text.ToString()
                , txtRedirectUri.Text.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _token=new TokenAl(txtSonuc);
           _token.tokenAl(txtClientID2.Text.ToString(),txtClientSecret.Text.ToString(),
               txtGrantType.Text.ToString() ,txtCode.Text.ToString(),
               txtRedirectUri.Text.ToString(),txtState2.Text.ToString());
          
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            apiData = new ApiVerileri(txtTokenGir.Text.ToString(),txtApiResponse,txtJsonParse);
            apiData.apiVerileriGetir();

            apiData.deserialiseJSON();    
        }
         


        
    }
}
