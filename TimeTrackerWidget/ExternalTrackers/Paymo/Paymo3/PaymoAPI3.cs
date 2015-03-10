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

        public Entries GetEntriesPerDay(DateTime date)
        {
            string timeFrom = date.ToString("yyyy-MM-ddT") + "00:00:00.000Z";
            string timeTo = date.ToString("yyyy-MM-ddT") + "23:59:59.000Z";

            return (Entries)this.RetrieveResponse("entries", "include=task.name&where=time_interval in (\"" + timeFrom + "\",\"" + timeTo + "\") and user_email=" + this.User, typeof(Entries), HttpVerb.GET);
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
                headers.Add("Accept", "text/xml");


                if (method == HttpVerb.GET || method == HttpVerb.DELETE)
                {
                    client.EndPoint = URL + @"/" + action + (parameters != string.Empty ? "?" + parameters : "");
                }
                else if (method == HttpVerb.POST || method == HttpVerb.PUT)
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
                Console.WriteLine(ex.Message);
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
                   "{\"start_time\":\"" + start.ToString("yyyy-MM-ddTHH:mm") + ":00+01:00\",\"end_time\":\"" + end.ToString("yyyy-MM-ddTHH:mm") +
                   ":00+01:00\",\"task_id\":\"" + taskId + "\",\"description\":\"" + message + "\"}",
                   null, HttpVerb.POST, "application/json");
        }

        public void UpdateEntry(DateTime start, DateTime end, int taskId, string message, int entryId)
        {
            if (entryId == 0)
            {
                this.AddEntry(start, end, taskId, message);
            }
            else
            {
                this.RetrieveResponse(@"entries/" + entryId,
                        "{\"duration\":\"" + end.Subtract(start).TotalSeconds + "\",\"start_time\":\"" + start.ToString("yyyy-MM-ddTHH:mm") + ":00+01:00\",\"end_time\":\"" + end.ToString("yyyy-MM-ddTHH:mm") +
                        ":00+01:00\",\"task_id\":\"" + taskId + "\",\"description\":\"" + message + "\",\"id\":\"" + entryId.ToString() + "\"}",
                        null, HttpVerb.PUT, "application/json");
            }
        }

        public void DeleteEntry(int entryId)
        {
            if (entryId > 0)
            {
                this.RetrieveResponse(@"entries/" + entryId, "", null, HttpVerb.DELETE, "application/json");
            }
        }
    }
}
