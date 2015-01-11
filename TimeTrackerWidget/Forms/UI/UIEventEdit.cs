using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TimeTrackerWidget.ExternalTrackers.Paymo3;
using TimeTrackerWidget.ExternalTrackers.Redmine;
using TimeTrackerWidget.ExternalTrackers.Paymo.Paymo3;

namespace TimeTrackerWidget.Forms.UI
{
    public partial class UIEventEdit : UserControl
    {
        [Browsable(true)]
        public event EventHandler OnSaveClick = null;
        [Browsable(true)]
        public event EventHandler OnDeleteClick = null;
        [Browsable(true)]
        public event EventHandler OnCancelClick = null;

        public UIEventEdit()
        {
            InitializeComponent();
        }

        private void buttonNowFrom_Click(object sender, EventArgs e)
        {
            this.datePickerFrom.Value = DateTime.Now;
            this.timePickerFrom.Value = DateTime.Now;
        }

        private void buttonNowTo_Click(object sender, EventArgs e)
        {
            this.datePickerTo.Value = DateTime.Now;
            this.timePickerTo.Value = DateTime.Now;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DateTime dFrom = this.datePickerFrom.Value.Date + this.timePickerFrom.Value.TimeOfDay;
            DateTime dTo = this.datePickerTo.Value.Date + this.timePickerTo.Value.TimeOfDay;
            PaymoAPI3.Instance.UpdateEntry(dFrom, dTo, ((Task)((ComboBoxItem)this.comboBoxPaymoTasks.SelectedItem).ObjectValue).Id, this.commentTextBox.Text, this.entry.Id);
            if (OnSaveClick != null)
                OnSaveClick(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OnCancelClick != null)
                OnCancelClick(sender, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (DeleteMessageBox.ShowStaticDialog() == DialogResult.Yes)
            {
                PaymoAPI3.Instance.DeleteEntry(this.entry.Id);
                if (OnDeleteClick != null)
                    OnDeleteClick(sender, e);
            }
        }

        private class ComboBoxItem
        {
            public int Value { get; set; }
            public string Text { get; set; }
            public bool Selectable { get; set; }
            public object ObjectValue { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        private Entry entry = null;
        private bool selectedFirstTask = false;

        public void SetData(Entry entry)
        {
            this.selectedFirstTask = false;
            this.entry = entry;
            this.datePickerFrom.Value = entry.StartTime.ToLocalTime();
            this.timePickerFrom.Value = entry.StartTime.ToLocalTime();
            this.datePickerTo.Value = entry.EndTime.ToLocalTime();
            this.timePickerTo.Value = entry.EndTime.ToLocalTime();
            this.commentTextBox.Text = entry.Description;

            if (this.entry != null && this.entry.Id > 0)
            {
                int currentProjectSelected = comboBoxPaymoProjects.SelectedIndex;
                for (int i = 0; i < this.comboBoxPaymoProjects.Items.Count; i++)
                {
                    if (((ComboBoxItem)this.comboBoxPaymoProjects.Items[i]).Selectable &&
                        ((ComboBoxItem)this.comboBoxPaymoProjects.Items[i]).Value == this.entry.ProjectId)
                    {
                        comboBoxPaymoProjects.SelectedIndex = i;
                        break;
                    }
                }

                if (currentProjectSelected == comboBoxPaymoProjects.SelectedIndex)
                {
                    if (this.selectedFirstTask == false && this.entry != null && this.entry.Id > 0)
                    {
                        for (int i = 0; i < this.comboBoxPaymoTasks.Items.Count; i++)
                        {
                            if (((ComboBoxItem)this.comboBoxPaymoTasks.Items[i]).Selectable &&
                                ((ComboBoxItem)this.comboBoxPaymoTasks.Items[i]).Value == this.entry.TaskId)
                            {
                                comboBoxPaymoTasks.SelectedIndex = i;
                                break;
                            }
                        }
                        this.selectedFirstTask = true;
                    }
                }
            }

            this.buttonDelete.Visible = this.entry.Id > 0;
        }

        private void comboBoxPaymoProjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;

            if (cb.SelectedItem != null && cb.SelectedItem is ComboBoxItem && ((ComboBoxItem)cb.SelectedItem).Selectable == false)
            {
                this.SelectFirstPaymo(this.comboBoxPaymoProjects);
            }
            else if (cb.SelectedItem != null && cb.SelectedItem is ComboBoxItem && ((ComboBoxItem)cb.SelectedItem).Selectable == true)
            {
                this.comboBoxPaymoTasks.Items.Clear();

                Array.Sort(((Project)((ComboBoxItem)cb.SelectedItem).ObjectValue).Task_list, delegate(TaskList t1, TaskList t2)
                {
                    return t1.Name.CompareTo(t2.Name);
                });

                foreach (TaskList tl in ((Project)((ComboBoxItem)cb.SelectedItem).ObjectValue).Task_list)
                {
                    if (tl.Task != null && tl.Task.Length > 0)
                    {
                        ComboBoxItem c = new ComboBoxItem();
                        c.Selectable = false;
                        c.Text = tl.Name;
                        c.Value = tl.Id;
                        c.ObjectValue = tl;
                        this.comboBoxPaymoTasks.Items.Add(c);
                        foreach (Task t in tl.Task)
                        {
                            if (t.Complete)
                                continue;
                            ComboBoxItem c2 = new ComboBoxItem();
                            c2.Selectable = true;
                            c2.Text = t.Name;
                            c2.Value = t.Id;
                            c2.ObjectValue = t;
                            this.comboBoxPaymoTasks.Items.Add(c2);
                        }
                    }
                }
                if (this.selectedFirstTask == false && this.entry != null && this.entry.Id > 0)
                {
                    for (int i = 0; i < this.comboBoxPaymoTasks.Items.Count; i++)
                    {
                        if (((ComboBoxItem)this.comboBoxPaymoTasks.Items[i]).Selectable &&
                            ((ComboBoxItem)this.comboBoxPaymoTasks.Items[i]).Value == this.entry.TaskId)
                        {
                            comboBoxPaymoTasks.SelectedIndex = i;
                            break;
                        }
                    }
                    this.selectedFirstTask = true;
                }
                else
                    this.SelectFirstPaymo(this.comboBoxPaymoTasks);
            }
        }

        public void LoadPaymo()
        {
            if (!backgroundWorkerPaymoProjects.IsBusy)
            {
                backgroundWorkerPaymoProjects.RunWorkerAsync();
            }
        }

        private void comboBoxPaymoTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;

            if (cb.SelectedItem != null && cb.SelectedItem is ComboBoxItem && ((ComboBoxItem)cb.SelectedItem).Selectable == false)
            {
                this.SelectFirstPaymo((ComboBox)cb);
            }
        }

        private void SelectFirstPaymo(ComboBox cb)
        {
            for (int i = 0; i < cb.Items.Count; i++)
            {
                if (((ComboBoxItem)cb.Items[i]).Selectable)
                {
                    cb.SelectedIndex = i;
                    break;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (TimeTrackerWidget.Properties.Settings.Default.PaymoEnabled)
            {
                PaymoAPI3.Instance.User = TimeTrackerWidget.Properties.Settings.Default.PaymoLogin;
                PaymoAPI3.Instance.Password = TimeTrackerWidget.Properties.Settings.Default.PaymoPassword;
                e.Result = PaymoAPI3.Instance.GetProjects();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (TimeTrackerWidget.Properties.Settings.Default.PaymoEnabled)
            {
                this.comboBoxPaymoProjects.Enabled = true;
                this.comboBoxPaymoTasks.Enabled = true;
                this.comboBoxPaymoProjects.Items.Clear();
                this.comboBoxPaymoTasks.Items.Clear();

                Projects p = (Projects)e.Result;

                if (p != null)
                {
                    foreach (Project pr in p.Project)
                    {
                        if (pr.Active)
                        {
                            ComboBoxItem c = new ComboBoxItem();
                            c.Selectable = true;
                            c.Text = pr.Name;
                            c.Value = pr.Id;
                            c.ObjectValue = pr;
                            this.comboBoxPaymoProjects.Items.Add(c);
                        }
                    }
                }
                this.SelectFirstPaymo(this.comboBoxPaymoProjects);
            }
            else
            {
                this.comboBoxPaymoProjects.Enabled = false;
                this.comboBoxPaymoTasks.Enabled = false;
            }
        }
    }
}
