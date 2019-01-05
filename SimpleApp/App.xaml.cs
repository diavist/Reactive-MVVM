using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SimpleApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IMainWindowViewModel mainWindowViewModel = Bootstrapper.Resolve<IMainWindowViewModel>();
            MainWindow = (MainWindow)mainWindowViewModel.LoadWindow<IMainWindowViewModel, IMainWindow>(mainWindowViewModel);


            if (MainWindow != null)
            {
                //if (System.Windows.Forms.Screen.AllScreens.Count() > 1)
                //{
                //    var left = System.Windows.Forms.Screen.AllScreens[1].Bounds.Left;
                //    MainWindow.Left = left;
                //}

                MainWindow.Show();
                base.OnStartup(e);
            }
        }
    }
}
