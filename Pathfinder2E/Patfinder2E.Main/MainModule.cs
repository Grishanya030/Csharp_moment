using Pathfinder2E.Main.ViewModels;
using Pathfinder2E.Main.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;


namespace Pathfinder2E.Main
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
