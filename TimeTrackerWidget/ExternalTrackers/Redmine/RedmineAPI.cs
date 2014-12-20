using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TimeTrackerWidget.Utils;
using System.Net;
using System.Windows.Forms;

namespace TimeTrackerWidget.ExternalTrackers.Redmine
{
    public class Activity
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    class RedmineAPI
    {
        public string APIKEY = string.Empty;
        public string URL = string.Empty;
        private RestClient client = null;

        public static RedmineAPI Instance
        {
            get
            {
                return SingletonGenericProvider<RedmineAPI>.Instance;
            }
        }

        private bool CheckAPI()
        {
            return this.APIKEY != string.Empty && this.URL != string.Empty;
        }

        public RedmineAPI()
        {
            client = new RestClient();
        }

        public bool AddTimeEntry(int issueNo, TimeSpan time, DateTime date, int activity, string comment)
        {
            if (!this.CheckAPI())
                return false;

            bool result = false;
            try
            {
                client.EndPoint = URL + @"/time_entries.xml?key=" + APIKEY;
                client.Method = HttpVerb.POST;

                string data = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" +
                    "<time_entry>" +
                    "<issue_id>" + issueNo + "</issue_id>" +
                    "<spent_on>" + date.ToString("yyyy-MM-dd") + "</spent_on>" +
                    "<hours>" + time.Hours + ":" + time.Minutes.ToString().PadLeft(2, '0') + "</hours>" +
                    "<activity_id>" + activity + "</activity_id>" +
                    "<comments>" + comment + "</comments>" +
                    "</time_entry>";
                client.PostData = data;
                string response = client.MakeRequest();
                result = true;
            }
            catch (WebException)
            {
                //
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return result;
        }

        public List<Activity> GetActivities()
        {
            List<Activity> list = new List<Activity>();
            list.Add(new Activity() { Text = "Development", Value = 9 });
            list.Add(new Activity() { Text = "Design", Value = 8 });
            return list;
        }
    }
}
