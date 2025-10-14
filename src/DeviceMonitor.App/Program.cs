using System;
using System.Windows.Forms;
using DeviceMonitor.App.Properties;

namespace DeviceMonitor.App
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new UI.MainForm());
        }
    }
}
