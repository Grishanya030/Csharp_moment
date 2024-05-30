using Pathfinder2E.Main;
using Pathfinder2E.Main.ViewModels;
using Pathfinder2E.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Pathfinder2E
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<MainModule>();

        }

        protected override Window CreateShell() => Container.Resolve<MainWindowView>();
    }

}
