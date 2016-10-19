using Microsoft.Practices.Unity;
using Prism.Unity;
using HQF.WPF.Controls.PrismUnityTest.Views;
using System.Windows;
using Prism.Modularity;

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

        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
           
            ModuleCatalog catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(ToolKitDemos.ToolKitDemosModule));
        }
    }
}
