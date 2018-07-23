using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace restSharp2
{
    class JsonParse
    {
        #region
        /*
        private DateTime createdAt;
        private string displayName;
        private string Email;
        private bool emailPublic;
        private string fullName;
        private bool haspremiumfeatures;
        private string humanReadableWebsite;
        private bool isEmailconfirmed;
        private bool ishireable;
        private bool languagesUsedpublic;
        private DateTime lastHeartbeat;
        private string lastPlugin;
        private string ID;
        private string last_pluginName;
        private string lastPproject;
        private string Location;
        private bool logged_timePublic;
        private string modifiedat;
        private string Photo;
        private bool photoPublic;
        private string Plan;
        private string Timezone;
        private string Username;
        private string Website;
        public DateTime created_at {  get { return createdAt; } set { createdAt = value; } }
        public string display_name { get { return displayName; } set { displayName = value; } }
        public string email { get { return Email; } set { Email = value; } }
        public bool email_public { get { return emailPublic; } set { emailPublic = value; } }
        public string full_name { get { return fullName; } set { fullName = value; } }
        public bool has_premium_features { get { return haspremiumfeatures; } set { haspremiumfeatures = value; } }
        public string human_readable_website { get { return humanReadableWebsite; } set { humanReadableWebsite = value; } }
        public string id { get { return ID; } set { ID = value; } }
        public bool is_email_confirmed { get { return isEmailconfirmed; } set { isEmailconfirmed = value; } }
        public bool is_hireable { get { return ishireable; } set { ishireable = value; } }
        public bool languages_used_public { get { return languagesUsedpublic; } set { languagesUsedpublic = value; } }
        public DateTime last_heartbeat { get { return lastHeartbeat; } set { lastHeartbeat = value; } }
        public string last_plugin { get { return lastPlugin; } set { lastPlugin = value; } }
        public string last_plugin_name { get { return last_pluginName; } set { last_pluginName = value; } }
        public string last_project { get { return lastPproject; } set { lastPproject = value; } }
        public string location { get { return Location; } set { Location = value; } }
        public bool logged_time_public { get { return logged_timePublic; } set { logged_timePublic = value; } }
        public string modified_at { get { return modifiedat; } set { modifiedat = value; } }
        public string photo { get { return Photo; } set { Photo = value; } }
        public bool photo_public { get { return photoPublic; } set { photoPublic = value; } }
        public string plan { get { return Plan; } set { Plan = value; } }
        public string timezone { get { return Timezone; } set { Timezone = value; } }
        public string username { get { return Username; } set { Username = value; } }
        public string website { get { return Website; } set { Website = value; } }
        */
        #endregion
        /* Başka tanımla */
        public Data data { get; set; }
        
        public class Data
        {
            public DateTime created_at { get; set; }
            public string display_name { get; set; }
            public string email { get; set; }
            public bool email_public { get; set; }
            public string full_name { get; set; }
            public bool has_premium_features { get; set; }
            public string human_readable_website { get; set; }
            public string id { get; set; }
            public bool is_email_confirmed { get; set; }
            public bool is_hireable { get; set; }
            public bool languages_used_public { get; set; }
            public DateTime last_heartbeat { get; set; }
            public string last_plugin { get; set; }
            public string last_plugin_name { get; set; }
            public string last_project { get; set; }
            public string location { get; set; }
            public bool logged_time_public { get; set; }
            public string modified_at { get; set; }
            public string photo { get; set; }
            public bool photo_public { get; set; }
            public string plan { get; set; }
            public string timezone { get; set; }
            public string username { get; set; }
            public string website { get; set; }

        }

       }
   }
