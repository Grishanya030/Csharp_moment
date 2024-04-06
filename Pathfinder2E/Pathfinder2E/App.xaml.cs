using Pathfinder2E.ViewModels;
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
            containerRegistry
                .RegisterSingleton<MainWindowViewModel>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            //moduleCatalog

        }

        protected override Window CreateShell() => Container.Resolve<MainWindowView>();
    }

}
