using Microsoft.Practices.Unity;
using Prism.Unity;
using HQF.WPF.Controls.PrismUnityTest.Views;
using System.Windows;

namespace HQF.WPF.Controls.PrismUnityTest
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
