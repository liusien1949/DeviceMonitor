using System.Windows.Forms;

namespace DeviceMonitor.App.Properties
{
    internal static class ApplicationConfiguration
    {
        public static void Initialize()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
        }
    }
}
