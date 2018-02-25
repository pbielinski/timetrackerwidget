using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using TimeTrackerWidget.forms;
using ZetaIpc.Runtime.Client;
using ZetaIpc.Runtime.Helper;
using ZetaIpc.Runtime.Server;

namespace TimeTrackerWidget
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (!SingleInstance.Start())
            {
                if (args.Length > 0)
                {
                    var c = new IpcClient();
                    c.Initialize(Properties.Settings.Default.IPCPort);
                    c.Send(args[0]);
                    SingleInstance.ShowFirstInstance();
                }
                return;
            }

            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            Version appVersion = a.GetName().Version;
            string appVersionString = appVersion.ToString();

            if (Properties.Settings.Default.ApplicationVersion != appVersion.ToString())
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.ApplicationVersion = appVersionString;
                Properties.Settings.Default.Save();
            }

            ServicePointManager
             .ServerCertificateValidationCallback +=
             (sender, cert, chain, sslPolicyErrors) => true;
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                MainForm mainForm = new MainForm();
                Application.Run(mainForm);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            SingleInstance.Stop();
        }
    }
}
