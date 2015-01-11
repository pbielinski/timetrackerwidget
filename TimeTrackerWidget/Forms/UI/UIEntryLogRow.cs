using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TimeTrackerWidget.ExternalTrackers.Paymo3;

namespace TimeTrackerWidget.Forms.UI
{
    public partial class UIEntryLogRow : UserControl
    {
        private Entry entry = null;

        public delegate void EventClick(Entry entry);

        public event EventClick OnRowClick = null;

        public enum ImageRowEnum
        {
            NONE,
            TOP,
            BOTTOM,
            LINE,
            TOP_RED,
            BOTTOM_RED,
            LINE_RED
        }

        public UIEntryLogRow()
        {
            InitializeComponent();
        }

        public void SetData(string timer, string text, ImageRowEnum imageType)
        {
            this.labelTime.Text = timer;
            this.label1.Text = text;
            this.SetImage(imageType);
        }

        public void SetData(Entry entry, string timer, string text, ImageRowEnum imageType)
        {
            this.entry = entry;
            this.labelTime.Text = timer;
            this.label1.Text = text;
            this.SetImage(imageType);
        }

        public void SetImage(ImageRowEnum imageType)
        {
            switch (imageType)
            {
                case ImageRowEnum.TOP:
                    this.pictureBox1.Image = TimeTrackerWidget.Properties.Resources.top;
                    break;
                case ImageRowEnum.BOTTOM:
                    this.pictureBox1.Image = TimeTrackerWidget.Properties.Resources.bottom;
                    break;
                case ImageRowEnum.LINE:
                    this.pictureBox1.Image = TimeTrackerWidget.Properties.Resources.full;
                    break;
                case ImageRowEnum.TOP_RED:
                    this.pictureBox1.Image = TimeTrackerWidget.Properties.Resources.top_red;
                    break;
                case ImageRowEnum.BOTTOM_RED:
                    this.pictureBox1.Image = TimeTrackerWidget.Properties.Resources.bottom_red;
                    break;
                case ImageRowEnum.LINE_RED:
                    this.pictureBox1.Image = TimeTrackerWidget.Properties.Resources.full_red;
                    break;
            }
        }

        private void labelTime_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void UIEntryLogRow_Click(object sender, EventArgs e)
        {
            if (OnRowClick != null)
                OnRowClick(this.entry);
        }
    }
}
