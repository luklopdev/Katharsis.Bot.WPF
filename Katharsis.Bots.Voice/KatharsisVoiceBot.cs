using Katharsis.Bot.Core;
using Katharsis.Bots.Voice.Menus;
using Katharsis.Bots.Voice.ViewModels;
using Katharsis.Bots.Voice.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;

namespace Katharsis.Bots.Voice
{
    public class KatharsisVoiceBot : IModule
    {
        private readonly IRegionManager _regionManager;

        public KatharsisVoiceBot(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.BOTS_LIST_REGION, typeof(BotListMenuItem));
            _regionManager.RegisterViewWithRegion(Core.RegionNames.SHELL_TOP_REGION, typeof(BarView));
            _regionManager.RegisterViewWithRegion(Core.RegionNames.SHELL_MAIN_REGION, typeof(BotMainView));
            _regionManager.RegisterViewWithRegion(Core.RegionNames.BAR_REGION, typeof(BarNavigationItemBot));
            _regionManager.RegisterViewWithRegion(Core.RegionNames.BAR_REGION, typeof(BarNavigationItemSettings));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<BotListMenuItem, BotListMenuItemViewModel>();

            containerRegistry.RegisterForNavigation<BotShellView, BotShellViewModel>();
            containerRegistry.RegisterForNavigation<BotMainView, BotMainViewModel>();
            containerRegistry.RegisterForNavigation<SettingsView, SettingsViewModel>();
        }
    }
}
