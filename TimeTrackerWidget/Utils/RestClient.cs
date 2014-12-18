using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;

public enum HttpVerb
{
    GET,
    POST,
    PUT,
    DELETE
}

namespace TimeTrackerWidget.Utils
{
    public class RestClient
    {
        public string EndPoint { get; set; }
        public HttpVerb Method { get; set; }
        public string ContentType { get; set; }
        public string PostData { get; set; }

        public RestClient()
        {
            EndPoint = "";
            Method = HttpVerb.GET;
            ContentType = "text/xml";
            PostData = "";
        }
        public RestClient(string endpoint)
        {
            EndPoint = endpoint;
            Method = HttpVerb.GET;
            ContentType = "text/xml";
            PostData = "";
        }
        public RestClient(string endpoint, HttpVerb method)
        {
            EndPoint = endpoint;
            Method = method;
            ContentType = "text/xml";
            PostData = "";
        }

        public RestClient(string endpoint, HttpVerb method, string postData)
        {
            EndPoint = endpoint;
            Method = method;
            ContentType = "text/xml";
            PostData = postData;
        }


        public string MakeRequest()
        {
            return MakeRequest("", "");
        }

        public string MakeRequest(string parameters, string ContentType)
        {
            return this.MakeRequest(parameters, ContentType, null);
        }

        public string MakeRequest(string parameters, string ContentType, Dictionary<string, string> headers)
        {

            var request = (HttpWebRequest)WebRequest.Create(EndPoint + parameters);

            request.Method = Method.ToString();
            request.ContentLength = 0;
            request.ContentType = this.ContentType;
            request.Accept = "*/*";
            request.Proxy = null;

            if (headers != null)
            {
                foreach (KeyValuePair<string, string> item in headers)
                {
                    request.Headers.Add(item.Key, item.Value);
                }
            }

            if (!string.IsNullOrEmpty(PostData) && Method == HttpVerb.POST)
            {
                if(ContentType != "")
                    request.ContentType = ContentType;
                var encoding = new UTF8Encoding();
                var bytes = Encoding.GetEncoding("UTF-8").GetBytes(PostData);
                request.ContentLength = bytes.Length;

                using (var writeStream = request.GetRequestStream())
                {
                    writeStream.Write(bytes, 0, bytes.Length);
                }
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                var responseValue = string.Empty;

                if ((int)response.StatusCode < 200 && (int)response.StatusCode >= 300)
                {
                    var message = String.Format("Request failed. Received HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                // grab the response
                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                        using (var reader = new StreamReader(responseStream))
                        {
                            responseValue = reader.ReadToEnd();
                        }
                }

                return responseValue;
            }
        }

    } // class

}