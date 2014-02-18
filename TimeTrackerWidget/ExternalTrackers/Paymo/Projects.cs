using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TimeTrackerWidget.ExternalTrackers.Paymo
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("response")]
    public class Projects
    {
        [System.Xml.Serialization.XmlAttribute("status")]
        public string Status { get; set; }  

        [XmlArray("projects")]
        [XmlArrayItem("project", typeof(Project))]
        public Project[] Project { get; set; }

        [System.Xml.Serialization.XmlElement("error")]
        public Error error { get; set; } 
    }

    [Serializable()]
    public class Project
    {
        [System.Xml.Serialization.XmlAttribute("id")]
        public int Id { get; set; }
        [System.Xml.Serialization.XmlAttribute("name")]
        public string Name { get; set; }
        [System.Xml.Serialization.XmlAttribute("retired")]
        public bool Retired { get; set; }
        [XmlArray("task_lists")]
        [XmlArrayItem("task_list", typeof(TaskList))]
        public TaskList[] Task_list { get; set; }
    }

    [Serializable()]
    public class TaskList
    {
        [System.Xml.Serialization.XmlAttribute("id")]
        public int Id { get; set; }
        [System.Xml.Serialization.XmlAttribute("name")]
        public string Name { get; set; }
        [XmlArray("tasks")]
        [XmlArrayItem("task", typeof(Task))]
        public Task[] Task { get; set; }
    }

    [Serializable()]
    public class Task
    {
        [System.Xml.Serialization.XmlAttribute("id")]
        public int Id { get; set; }
        [System.Xml.Serialization.XmlAttribute("name")]
        public string Name { get; set; }
        [System.Xml.Serialization.XmlAttribute("complete")]
        public bool Complete { get; set; }
    }
}
