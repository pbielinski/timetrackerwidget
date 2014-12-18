using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml.Serialization;
using TimeTrackerWidget.ExternalTrackers.Paymo3;
using TimeTrackerWidget.Utils;

namespace TimeTrackerWidget.ExternalTrackers.Paymo.Paymo3
{
    class PaymoAPI3
    {
        internal string URL = "https://app.paymoapp.com/api";
        internal string User = string.Empty;
        internal string Password = string.Empty;

        internal string SessionID = string.Empty;
        private RestClient client = null;

        public static PaymoAPI3 Instance
        {
            get
            {
                return SingletonGenericProvider<PaymoAPI3>.Instance;
            }
        }

        public PaymoAPI3()
        {
            client = new RestClient();
        }

        public Projects GetProjects()
        {
            return (Projects)this.RetrieveResponse("projects", "include=tasklists,tasklists.tasks&where=active%3Dtrue", typeof(Projects), HttpVerb.GET);
        }

        private object RetrieveResponse(string action, string parameters, Type responseType, HttpVerb method)
        {
            return RetrieveResponse(action, parameters, responseType, method, "text/xml");
        }

        private object RetrieveResponse(string action, string parameters, Type responseType, HttpVerb method, string ContentType)
        {
            object result = null;

            if (!this.CheckAPI())
                return null;

            try
            {
                Dictionary<string, string> headers = new Dictionary<string, string>();
                headers.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.GetEncoding("UTF-8").GetBytes(this.User + ":" + this.Password)));


                if (method == HttpVerb.GET)
                {
                    client.EndPoint = URL + @"/" + action + (parameters != string.Empty ? "?" + parameters : "");
                }
                else if (method == HttpVerb.POST)
                {
                    client.EndPoint = URL + @"/" + action;
                    client.PostData = parameters;
                }
                client.Method = method;
                string response = client.MakeRequest("", ContentType, headers);
                if (responseType != null)
                {
                    XmlSerializer serializer = new XmlSerializer(responseType);
                    using (TextReader reader = new StringReader(response))
                    {
                        result = serializer.Deserialize(reader);
                    }
                }
                else
                {
                    result = response;
                }
            }
            catch (WebException ex)
            {
                throw ex;
            }
            catch (Exception)
            {

            }
            return result;
        }

        private bool CheckAPI()
        {
            return this.URL != string.Empty && this.User != string.Empty && this.Password != string.Empty;
        }

        public void AddEntry(DateTime start, DateTime end, int taskId, string message)
        {
            this.RetrieveResponse("entries",
                    "{\"date\":\"" + DateTime.Now.ToString("yyyy-MM-dd") + "\",\"start_time\":\"" + start.ToString("yyyy-MM-ddTHH:mm") + ":00+01:00\",\"end_time\":\"" + end.ToString("yyyy-MM-ddTHH:mm") +
                    ":00+01:00\",\"task_id\":\"" + taskId + "\",\"description\":\"" + System.Web.HttpUtility.UrlEncode(message) + "\"}",
                    null, HttpVerb.POST, "application/json");
        }
    }
}
