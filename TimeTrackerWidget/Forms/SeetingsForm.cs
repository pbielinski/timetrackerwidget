using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeTrackerWidget.forms
{
    public partial class SeetingsForm : Form
    {
        public SeetingsForm()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                TimeTrackerWidget.Properties.Settings.Default.RedmineAPIKey = this.textBoxRedmineApiKey.Text;
                TimeTrackerWidget.Properties.Settings.Default.RedmineURL = this.textBoxRedmineUrl.Text;
                TimeTrackerWidget.Properties.Settings.Default.RedmineEnable = this.checkBoxRedmineEnable.Checked;

                TimeTrackerWidget.Properties.Settings.Default.PaymoEnabled = this.checkBoxPaymoEnable.Checked;
                TimeTrackerWidget.Properties.Settings.Default.PaymoLogin = this.textBoxPaymoUsername.Text;
                TimeTrackerWidget.Properties.Settings.Default.PaymoPassword = this.textBoxPaymoPassword.Text;

                TimeTrackerWidget.Properties.Settings.Default.Save();
            }
            else
            {

            }
        }

        private void SeetingsForm_Load(object sender, EventArgs e)
        {
            TimeTrackerWidget.Properties.Settings.Default.Reload();
            this.textBoxRedmineApiKey.Text = TimeTrackerWidget.Properties.Settings.Default.RedmineAPIKey;
            this.textBoxRedmineUrl.Text = TimeTrackerWidget.Properties.Settings.Default.RedmineURL;
            this.checkBoxRedmineEnable.Checked = TimeTrackerWidget.Properties.Settings.Default.RedmineEnable;

            this.checkBoxPaymoEnable.Checked = TimeTrackerWidget.Properties.Settings.Default.PaymoEnabled;
            this.textBoxPaymoUsername.Text = TimeTrackerWidget.Properties.Settings.Default.PaymoLogin;
            this.textBoxPaymoPassword.Text = TimeTrackerWidget.Properties.Settings.Default.PaymoPassword;

        }
    }
}
