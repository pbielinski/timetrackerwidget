using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeTrackerWidget.Forms.UI
{
    public partial class DeleteMessageBox : Form
    {
        private static DeleteMessageBox instance = null;

        public DeleteMessageBox()
        {
            InitializeComponent();
        }

        public static DialogResult ShowStaticDialog()
        {
            if (instance == null)
                instance = new DeleteMessageBox();
            return instance.ShowDialog();
        }
    }
}
