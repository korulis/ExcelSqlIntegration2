using System;
using System.Collections.Generic;
using System.Configuration;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;

namespace IntegrationApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    
    public partial class App : Application
    {
        public App()
        {
            MainWindow = new MainWindow();
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindow.Show();
            //MainWindow = new MainWindow();
            //MainWindow = new MainWindow();
            //this.StartupUri = new System.Uri("MainWindow.xaml", System.UriKind.Relative);
        }
    }
}
