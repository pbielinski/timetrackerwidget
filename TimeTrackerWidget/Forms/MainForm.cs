using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TimeTrackerWidget.ExternalTrackers.Paymo.Paymo3;
using TimeTrackerWidget.ExternalTrackers.Paymo3;
using TimeTrackerWidget.ExternalTrackers.Redmine;

namespace TimeTrackerWidget.forms
{
    public partial class MainForm : Form
    {
        public bool RunTaskEnable = false;
        private bool canClose = false;
        public DateTime TimerStart;
        public DateTime TimerStop;
        public Double Timer;

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

        public MainForm()
        {
            InitializeComponent();
            this.Icon = TimeTrackerWidget.Properties.Resources.clock_off;
            Rectangle r = Screen.PrimaryScreen.WorkingArea;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            Timer = 0;
            ReloadSettings();

            this.ShowMainPanel(this.panelMain);
        }

        public void ReloadSettings()
        {
            this.LoadRedmine();
            this.LoadPaymo();
        }

        private void LoadPaymo()
        {
            if (TimeTrackerWidget.Properties.Settings.Default.PaymoEnabled)
            {
                this.uiEventEdit1.LoadPaymo();
                this.panelPaymoWidget.Enabled = true;
                if (!backgroundWorkerPaymoProjects.IsBusy)
                {
                    pictureBoxPaymoLoad.Visible = true;
                    backgroundWorkerPaymoProjects.RunWorkerAsync();
                }
                this.buttonTimerLogs.Enabled = true;
            }
            else
            {
                this.panelPaymoWidget.Enabled = false;
                this.ShowMainPanel(this.panelMain);
                this.buttonTimerLogs.Enabled = false;
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

        private void LoadRedmine()
        {
            if (TimeTrackerWidget.Properties.Settings.Default.RedmineEnable)
            {
                this.panelRedmineWidget.Enabled = true;
                RedmineAPI.Instance.APIKEY = TimeTrackerWidget.Properties.Settings.Default.RedmineAPIKey;
                RedmineAPI.Instance.URL = TimeTrackerWidget.Properties.Settings.Default.RedmineURL;
                this.comboBoxRedmineActivity.Items.Clear();
                foreach (Activity a in RedmineAPI.Instance.GetActivities())
                {
                    comboBoxRedmineActivity.Items.Add(a);
                }
                comboBoxRedmineActivity.SelectedIndex = 0;
            }
            else
            {
                this.panelRedmineWidget.Enabled = false;
            }
        }

        private void timerRunnerTask_Tick(object sender, EventArgs e)
        {
            Timer++;
            FormatTime();
        }

        private void FormatTime()
        {
            this.labelTimer.Text = Math.Floor(Timer / 3600).ToString().PadLeft(2, '0') + ":" + Math.Floor((Timer / 60) % 60).ToString().PadLeft(2, '0') + ":" + Math.Floor(Timer % 60).ToString().PadLeft(2, '0');
        }

        private void runTaskButton_Click(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void StartTimer()
        {
            RunTaskEnable = (RunTaskEnable) ? false : true;
            if (RunTaskEnable)
            {
                this.runTaskButton.ImageIndex = 1;
                this.runTaskButton.Text = "STOP";
                this.timerRunnerTask.Enabled = true;
                TimerStart = DateTime.Now;
                this.Icon = TimeTrackerWidget.Properties.Resources.clock_on;
                this.notifyIcon1.Icon = TimeTrackerWidget.Properties.Resources.clock_on;
            }
            else
            {
                TimerStop = DateTime.Now;
                this.Icon = TimeTrackerWidget.Properties.Resources.clock_off;
                this.notifyIcon1.Icon = TimeTrackerWidget.Properties.Resources.clock_off;
                int issueNo = 0;
                if (TimeTrackerWidget.Properties.Settings.Default.RedmineEnable &&
                    (TimerStop - TimerStart).TotalMinutes >= 1 &&
                    int.TryParse(this.textBoxRedmineIssueNo.Text, out issueNo))
                    RedmineAPI.Instance.AddTimeEntry(issueNo, TimerStop - TimerStart, DateTime.Now, (comboBoxRedmineActivity.SelectedItem as Activity).Value, this.commentTextBox.Text);

                if (TimeTrackerWidget.Properties.Settings.Default.PaymoEnabled &&
                    (TimerStop - TimerStart).TotalMinutes >= 1 &&
                    this.comboBoxPaymoTasks.SelectedIndex >= 0)
                    PaymoAPI3.Instance.AddEntry(TimerStart, TimerStop, ((Task)((ComboBoxItem)this.comboBoxPaymoTasks.SelectedItem).ObjectValue).Id, this.commentTextBox.Text);

                this.runTaskButton.ImageIndex = 0;
                this.runTaskButton.Text = "START";
                this.timerRunnerTask.Enabled = false;
                Timer = 0;
                FormatTime();
            }
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeetingsForm form = new SeetingsForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                ReloadSettings();
            }
        }

        private void ShowMainForm()
        {
            if (this.WindowState != FormWindowState.Minimized)
                this.ShowWindow();
            else
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowMainForm();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (canClose == false)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void closeForm()
        {
            canClose = true;
            this.Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        private void open_Click(object sender, EventArgs e)
        {
            ShowMainForm();
        }

        private void zamknijToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closeForm();
        }

        protected override void WndProc(ref Message message)
        {
            if (message.Msg == SingleInstance.WM_SHOWFIRSTINSTANCE)
            {
                ShowWindow();
            }
            base.WndProc(ref message);
        }

        public void ShowWindow()
        {
            // Insert code here to make your form show itself.
            WinApi.ShowToFront(this.Handle);
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
                this.SelectFirstPaymo(this.comboBoxPaymoTasks);
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

        private void textBoxRedmineIssueNo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RedmineGotoIssue();
            }
            else
            {
                if (this.textBoxRedmineIssueNo.Text != string.Empty)
                    this.commentTextBox.Text = "#" + this.textBoxRedmineIssueNo.Text;
                else
                    this.commentTextBox.Text = string.Empty;
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
            pictureBoxPaymoLoad.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(TimeTrackerWidget.Properties.Settings.Default.RedmineEnable && 
                TimeTrackerWidget.Properties.Settings.Default.RedmineURL != string.Empty)
                Process.Start(TimeTrackerWidget.Properties.Settings.Default.RedmineURL);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (TimeTrackerWidget.Properties.Settings.Default.PaymoEnabled)
                Process.Start("https://app.paymoapp.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RedmineGotoIssue();
        }

        private void RedmineGotoIssue()
        {
            if (TimeTrackerWidget.Properties.Settings.Default.RedmineEnable &&
                TimeTrackerWidget.Properties.Settings.Default.RedmineURL != string.Empty &&
                this.textBoxRedmineIssueNo.Text != string.Empty)
            {
                int issueNo = 0;
                if (int.TryParse(this.textBoxRedmineIssueNo.Text, out issueNo))
                    Process.Start(TimeTrackerWidget.Properties.Settings.Default.RedmineURL + @"/issues/" + issueNo);
            }
        }

        private void buttonTimer_Click(object sender, EventArgs e)
        {
            this.ShowMainPanel(this.panelMain);
        }

        private void ShowMainPanel(Control control)
        {
            this.buttonTimer.BackColor = control == this.panelMain ? Color.LightSkyBlue : Color.LightSlateGray;
            this.buttonTimerLogs.BackColor = control == this.uitImerLogs ? Color.LightSkyBlue : Color.LightSlateGray;

            foreach (Control c in this.panelAll.Controls)
                c.Visible = c == control;
        }

        private void buttonTimerLogs_Click(object sender, EventArgs e)
        {
            this.uitImerLogs.RefreshListEvents();
            this.ShowMainPanel(this.uitImerLogs);
        }

        public void ShowEditEvent(Entry entry)
        {
            this.uiEventEdit1.SetData(entry);
            this.uiEventEdit1.Visible = true;
            this.panelAll.Visible = false;
            this.panel1.Visible = false;
        }

        private void uitImerLogs_OnRowClick(Entry entry)
        {
            this.ShowEditEvent(entry);
        }

        private void uiEventEdit1_OnSaveClick(object sender, EventArgs e)
        {
            this.uiEventEdit1.Visible = false;
            this.panelAll.Visible = true;
            this.panel1.Visible = true;
            this.uitImerLogs.RefreshListEvents();
        }

        private void uiEventEdit1_OnDeleteClick(object sender, EventArgs e)
        {
            this.uiEventEdit1.Visible = false;
            this.panelAll.Visible = true;
            this.panel1.Visible = true;
            this.uitImerLogs.RefreshListEvents();
        }

        private void uiEventEdit1_OnCancelClick(object sender, EventArgs e)
        {
            this.uiEventEdit1.Visible = false;
            this.panelAll.Visible = true;
            this.panel1.Visible = true;
        }
    }
}
