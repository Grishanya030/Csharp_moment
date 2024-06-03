using Pathfinder2E.Shell.ViewModels;
using Pathfinder2E.Shell.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pathfinder2E.Shell
{
    public class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            containerProvider.Resolve<IRegionManager>()
                .RegisterViewWithRegion("MainRegion", nameof(MainView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry
                 .RegisterSingleton<MainViewModel>()
                 .RegisterForNavigation<MainView>();
        }
    }
}
