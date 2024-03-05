using Katharsis.Bot.Core;
using Katharsis.Bots.Voice.Menus;
using Prism.Ioc;
using Prism.Modularity;
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
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
