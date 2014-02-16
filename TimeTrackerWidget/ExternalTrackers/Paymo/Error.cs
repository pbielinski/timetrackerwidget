using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTrackerWidget.ExternalTrackers.Paymo
{
    [Serializable()]
    public class Error
    {
        [System.Xml.Serialization.XmlAttribute("code")]
        public int Code { get; set; }

        [System.Xml.Serialization.XmlAttribute("message")]
        public string Message { get; set; }  
    }
}
