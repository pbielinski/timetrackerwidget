using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TimeTrackerWidget.ExternalTrackers.Paymo3
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("response")]
    public class Entries
    {
        [XmlArray("entries")]
        [XmlArrayItem("entry", typeof(Entry))]
        public Entry[] Entry { get; set; }
    }

    [Serializable()]
    [System.Xml.Serialization.XmlRoot("response")]
    public class ResponseAddEntry
    {
        [System.Xml.Serialization.XmlAttribute("status")]
        public string Status { get; set; }

        [System.Xml.Serialization.XmlElement("entry")]
        public EntryAdded entry { get; set; }
    }

    [Serializable()]
    public class EntryAdded
    {
        [System.Xml.Serialization.XmlAttribute("id")]
        public int Id { get; set; }
    }

    [Serializable()]
    public class User
    {
        [System.Xml.Serialization.XmlElement("email")]
        public string Email { get; set; }
    }

    [Serializable()]
    public class Entry
    {
        [System.Xml.Serialization.XmlElement("id")]
        public int Id { get; set; }

        [System.Xml.Serialization.XmlElement("start_time")]
        public DateTime StartTime { get; set; }

        [System.Xml.Serialization.XmlElement("end_time")]
        public DateTime EndTime { get; set; }

        [System.Xml.Serialization.XmlElement("description")]
        public string Description { get; set; }

        [System.Xml.Serialization.XmlElement("project_id")]
        public int ProjectId { get; set; }

        [System.Xml.Serialization.XmlElement("task_id")]
        public int TaskId { get; set; }

        [System.Xml.Serialization.XmlElement("task")]
        public Task Task { get; set; }

        [System.Xml.Serialization.XmlElement("user")]
        public User User { get; set; }
    }
}
