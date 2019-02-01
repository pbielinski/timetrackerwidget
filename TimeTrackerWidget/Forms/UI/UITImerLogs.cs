using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TimeTrackerWidget.Forms.UI;
using TimeTrackerWidget.ExternalTrackers.Paymo.Paymo3;
using TimeTrackerWidget.ExternalTrackers.Paymo3;

namespace TimeTrackerWidget.Forms
{
    public partial class UITImerLogs : UserControl
    {
        [Browsable(true)]
        public event UIEntryLogRow.EventClick OnRowClick = null;

        public UITImerLogs()
        {
            InitializeComponent();
            this.dateTimePickerEntry.Value = DateTime.Now;
        }

        private void backgroundWorkerRefresh_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = PaymoAPI3.Instance.GetEntriesPerDay((DateTime)e.Argument);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RefreshListEvents();
        }

        public void RefreshListEvents()
        {
            if(TimeTrackerWidget.Properties.Settings.Default.PaymoEnabled && !this.backgroundWorkerPaymoRefresh.IsBusy)
            {
                this.backgroundWorkerPaymoRefresh.RunWorkerAsync(this.dateTimePickerEntry.Value);
            }
        }

        private void backgroundWorkerPaymoRefresh_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int i = 0;
            int hour = 8;

            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.Controls.Clear();

            if (e.Result != null && e.Result is Entries)
            {
                Entries entries = (Entries)e.Result;
                Array.Sort(entries.Entry, delegate(Entry e1, Entry e2) {
                    int compare = e1.StartTime.CompareTo(e2.StartTime);
                    if(compare == 0) 
                        compare = e1.EndTime.CompareTo(e2.EndTime);
                    return compare;
                });

                DateTime? lastEndTime = null;
                bool conflict = false;
                bool endConflict = true;
                UIEntryLogRow lastRow = null;
                foreach (var item in entries.Entry)
                {
                    if(item.User.Email != TimeTrackerWidget.Properties.Settings.Default.PaymoLogin)
                    {
                        continue;
                    }

                    DateTime startTime = item.StartTime.ToLocalTime();
                    DateTime endTime = item.EndTime.ToLocalTime();
                    conflict = false;

                    if (lastEndTime.HasValue && lastEndTime > startTime)
                        conflict = true;

                    if (!conflict)
                    {
                        if (lastEndTime.HasValue && lastEndTime.Value != startTime)
                        {
                            Entry entry = new Entry();
                            entry.StartTime = lastEndTime.Value.ToUniversalTime();
                            entry.EndTime = item.StartTime.ToUniversalTime();
                            lastRow = AddLogEntry(entry, lastEndTime.Value.ToString("HH:mm"), "", endConflict ? UIEntryLogRow.ImageRowEnum.BOTTOM : UIEntryLogRow.ImageRowEnum.BOTTOM_RED, i++);
                            endConflict = true;
                        }

                        if (lastEndTime.HasValue && lastEndTime.Value != startTime)
                        {
                            Entry entry = new Entry();
                            entry.StartTime = lastEndTime.Value.ToUniversalTime();
                            entry.EndTime = item.StartTime.ToUniversalTime();
                            if (lastRow != null)
                                AddLogEntry(entry, lastEndTime.Value.ToString("HH:mm"), "", UIEntryLogRow.ImageRowEnum.NONE, Color.Orange);
                            else
                                AddLogEntry(entry, lastEndTime.Value.ToString("HH:mm"), "", UIEntryLogRow.ImageRowEnum.NONE, i);
                            i++;
                        }

                        while (hour < startTime.Hour)
                        {
                            Entry entry = new Entry();
                            entry.StartTime = this.dateTimePickerEntry.Value.Date.AddHours(hour);
                            entry.EndTime = this.dateTimePickerEntry.Value.Date.AddHours(hour + 1);
                            if (lastRow != null)
                                AddLogEntry(entry, hour.ToString().PadLeft(2, '0') + ":00", "", UIEntryLogRow.ImageRowEnum.NONE, Color.Orange);
                            else
                                AddLogEntry(entry, hour.ToString().PadLeft(2, '0') + ":00", "", UIEntryLogRow.ImageRowEnum.NONE, i);
                            i++;
                            hour++;
                        }

                        lastRow = AddLogEntry(item, startTime.ToString("HH:mm"), (item.Description != string.Empty ? item.Description + " " : "") + "(" + item.Task.Name + ")", 
                            (lastRow != null && lastRow.entry.Id > 0 && lastRow.entry.EndTime.ToLocalTime() == startTime ? 
                            UIEntryLogRow.ImageRowEnum.CONTINUE : UIEntryLogRow.ImageRowEnum.TOP), i++);
                    }
                    else
                    {
                        if (lastRow != null)
                            lastRow.SetImage(UIEntryLogRow.ImageRowEnum.TOP_RED);
                        lastRow = AddLogEntry(item, startTime.ToString("HH:mm"), (item.Description != string.Empty ? item.Description + " " : "") + "(" + item.Task.Name + ")", UIEntryLogRow.ImageRowEnum.LINE_RED, i++);
                        endConflict = false;
                    }

                    hour = endTime.Hour + 1;
                    lastEndTime = endTime;
                }

                if (lastEndTime.HasValue)
                {
                    Entry entry = new Entry();
                    entry.StartTime = lastEndTime.Value.ToUniversalTime();
                    entry.EndTime = lastEndTime.Value.AddHours(1).ToUniversalTime();
                    AddLogEntry(entry, lastEndTime.Value.ToString("HH:mm"), "", !conflict ? UIEntryLogRow.ImageRowEnum.BOTTOM : UIEntryLogRow.ImageRowEnum.BOTTOM_RED, i++);
                }
            }

            for (int j = hour; j <= 16; j++)
            {
                Entry entry = new Entry();
                entry.StartTime = new DateTime(this.dateTimePickerEntry.Value.Year,
                    this.dateTimePickerEntry.Value.Month,
                    this.dateTimePickerEntry.Value.Day,
                    j, 0, 0).ToUniversalTime();
                entry.EndTime = new DateTime(this.dateTimePickerEntry.Value.Year,
                    this.dateTimePickerEntry.Value.Month,
                    this.dateTimePickerEntry.Value.Day,
                    j + 1, 0, 0).ToUniversalTime();
                AddLogEntry(entry, j.ToString().PadLeft(2, '0') + ":00", "", UIEntryLogRow.ImageRowEnum.NONE, i++);
            }

            this.flowLayoutPanel1.ResumeLayout();
        }

        private UIEntryLogRow AddLogEntry(Entry entry, string time, string text, UIEntryLogRow.ImageRowEnum imageIndex, int rowIndex)
        {
            return this.AddLogEntry(entry, time, text, imageIndex, rowIndex % 2 == 0 ? Color.White : Color.LightGray);
        }

        private UIEntryLogRow AddLogEntry(Entry entry, string time, string text, UIEntryLogRow.ImageRowEnum imageIndex, Color backcolor)
        {
            UIEntryLogRow row = new UIEntryLogRow();
            row.Height = 28;
            row.Width = this.flowLayoutPanel1.Width - 16;
            row.Margin = new Padding(0);
            row.Padding = new System.Windows.Forms.Padding(0);
            row.BackColor = backcolor;
            row.SetData(entry, time, text, imageIndex);
            row.Parent = this.flowLayoutPanel1;
            row.MouseEnter += new System.EventHandler(this.flowLayoutPanel1_MouseEnter);
            row.OnRowClick += new UIEntryLogRow.EventClick(row_OnRowClick);
            return row;
        }

        void row_OnRowClick(Entry entry)
        {
            if (OnRowClick != null)
                OnRowClick(entry);
        }

        private void flowLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Focus();
        }

        private void dateTimePickerEntry_ValueChanged(object sender, EventArgs e)
        {
            this.RefreshListEvents();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Entry entry = new Entry();
            entry.StartTime = dt.ToUniversalTime();
            entry.EndTime = dt.ToUniversalTime();
            if (OnRowClick != null)
                OnRowClick(entry);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.dateTimePickerEntry.Value = this.dateTimePickerEntry.Value.AddDays(1);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            this.dateTimePickerEntry.Value = this.dateTimePickerEntry.Value.AddDays(-1);
        }
    }
}
