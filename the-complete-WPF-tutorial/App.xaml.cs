using System;
using System.Windows;
using System.Threading;
using System.Globalization;

namespace the_complete_WPF_tutorial
{
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("ko-KR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        }
    }
}
