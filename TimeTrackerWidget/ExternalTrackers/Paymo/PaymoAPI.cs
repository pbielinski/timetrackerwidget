using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Serialization;
using TimeTrackerWidget.Utils;

namespace TimeTrackerWidget.ExternalTrackers.Paymo
{
    class PaymoAPI
    {
        internal string APIKEY = string.Empty;
        internal string URL = "https://api.paymo.biz/service";
        internal string User = string.Empty;
        internal string Password = string.Empty;

        internal string Token = string.Empty;
        private RestClient client = null;

        public static PaymoAPI Instance
        {
            get
            {
                return SingletonGenericProvider<PaymoAPI>.Instance;
            }
        }

        private bool CheckAPI()
        {
            return this.APIKEY != string.Empty && this.URL != string.Empty && this.User != string.Empty && this.Password != string.Empty;
        }

        public PaymoAPI()
        {
            client = new RestClient();
        }

        public bool Login()
        {
            bool result = CheckToken();

            if (result == false)
            {
                Token token = (Token)this.RetrieveResponse("paymo.auth.login", "&username=" + this.User + "&password=" + this.Password, typeof(Token));
                if (token != null && token.Status == "ok")
                {
                    this.Token = token.TokenKey;
                    TimeTrackerWidget.Properties.Settings.Default.PaymoLastToken = this.Token;
                    TimeTrackerWidget.Properties.Settings.Default.Save();
                    result = true;
                }
            }
            return result;
        }

        public bool CheckToken()
        {
            Token token = (Token)this.RetrieveResponse("paymo.auth.checkToken", "", typeof(Token));
            return (token != null && token.Status == "ok") ? true : false;
        }

        public Projects GetProjects()
        {
            Projects result = (Projects)this.RetrieveResponse("paymo.projects.getList", "&include_task_lists=1&include_tasks=1", typeof(Projects));
            if (result != null && result.error != null && result.error.Code == 104)
            {
                this.Login();
                result = (Projects)this.RetrieveResponse("paymo.projects.getList", "&include_task_lists=1&include_tasks=1", typeof(Projects));
            }
            return result;
        }

        private object RetrieveResponse(string action, string parameters, Type responseType)
        {
            return RetrieveResponse(action, parameters, responseType, HttpVerb.GET);
        }

        private object RetrieveResponse(string action, string parameters, Type responseType, HttpVerb method)
        {
            object result = null;

            if (!this.CheckAPI())
                return null;

            try
            {
                if (method == HttpVerb.GET)
                {
                    client.EndPoint = URL + @"/" + action + "?api_key=" + this.APIKEY + "&format=xml&auth_token=" + this.Token + parameters;
                }
                else if(method == HttpVerb.POST)
                {
                    client.EndPoint = URL + @"/" + action;
                    client.PostData = "api_key=" + this.APIKEY + "&format=xml&auth_token=" + this.Token + parameters;
                }
                client.Method = method;
                string response = client.MakeRequest("", "application/x-www-form-urlencoded");
                XmlSerializer serializer = new XmlSerializer(responseType);
                using (TextReader reader = new StringReader(response))
                {
                    result = serializer.Deserialize(reader);
                }
            }
            catch (WebException)
            {

            }
            catch (Exception)
            {

            }
            return result;
        }

        public ResponseAddEntry AddEntry(DateTime start, DateTime end, int taskId, string message)
        {
            ResponseAddEntry result =
                result = (ResponseAddEntry)this.RetrieveResponse("paymo.entries.add",
                    "&start=" + start.ToString("yyyy-MM-dd HH:mm") + ":00&end=" + end.ToString("yyyy-MM-dd HH:mm") +
                    ":00&task_id=" + taskId + "&description=" + System.Web.HttpUtility.UrlEncode(message), 
                    typeof(ResponseAddEntry), HttpVerb.POST);
            if (result != null && result.error != null && result.error.Code == 104)
            {
                this.Login();
                result = (ResponseAddEntry)this.RetrieveResponse("paymo.entries.add",
                    "&start=" + start.ToString("yyyy-MM-dd HH:mm") + ":00&end=" + end.ToString("yyyy-MM-dd HH:mm") + 
                    ":00&task_id=" + taskId + "&description=" + System.Web.HttpUtility.UrlEncode(message),
                    typeof(ResponseAddEntry), HttpVerb.POST);
            }
            return result;
        }
    }
}
