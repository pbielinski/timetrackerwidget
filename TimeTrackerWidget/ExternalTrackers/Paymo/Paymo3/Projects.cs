using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace TimeTrackerWidget.ExternalTrackers.Paymo3
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("response")]
    public class Projects
    {
        [XmlArray("projects")]
        [XmlArrayItem("project", typeof(Project))]
        public Project[] Project { get; set; }
    }

    [Serializable()]
    public class Project
    {
        [System.Xml.Serialization.XmlElement("id")]
        public int Id { get; set; }
        [System.Xml.Serialization.XmlElement("name")]
        public string Name { get; set; }
        [System.Xml.Serialization.XmlElement("active")]
        public bool Active { get; set; }
        [XmlArray("tasklists")]
        [XmlArrayItem("tasklist", typeof(TaskList))]
        public TaskList[] Task_list { get; set; }
    }

    [Serializable()]
    public class TaskList
    {
        [System.Xml.Serialization.XmlElement("id")]
        public int Id { get; set; }
        [System.Xml.Serialization.XmlElement("name")]
        public string Name { get; set; }
        [XmlArray("tasks")]
        [XmlArrayItem("task", typeof(Task))]
        public Task[] Task { get; set; }
    }

    [Serializable()]
    public class Task
    {
        [System.Xml.Serialization.XmlElement("id")]
        public int Id { get; set; }
        [System.Xml.Serialization.XmlElement("name")]
        public string Name { get; set; }
        [System.Xml.Serialization.XmlElement("complete")]
        public bool Complete { get; set; }
    }
}
