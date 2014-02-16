using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTrackerWidget.ExternalTrackers.Paymo
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("response")]
    public class Token
    {
        [System.Xml.Serialization.XmlElement("token")]
        public string TokenKey { get; set; }
        [System.Xml.Serialization.XmlAttribute("status")]
        public string Status { get; set; }

        [System.Xml.Serialization.XmlElement("error")]
        public Error error { get; set; } 
    }
}
