using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TimeTrackerWidget.ExternalTrackers.Paymo
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("response")]
    public class ResponseAddEntry
    {
        [System.Xml.Serialization.XmlAttribute("status")]
        public string Status { get; set; }

        [System.Xml.Serialization.XmlElement("entry")]
        public Entry entry { get; set; }

        [System.Xml.Serialization.XmlElement("error")]
        public Error error { get; set; } 
    }

    [Serializable()]
    public class Entry
    {
        [System.Xml.Serialization.XmlAttribute("id")]
        public int Id { get; set; }
    }
}
