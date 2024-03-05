using Katharsis.Bot.Core;
using Katharsis.Bot.Core.WPF;
using Katharsis.Bot.WPF.Views;
using Prism.Commands;
using Prism.Regions;

namespace Katharsis.Bot.WPF.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;

        private DelegateCommand _viewLoadedCommand = default!;
        public DelegateCommand ViewLoadedCommand => _viewLoadedCommand ??=
            new DelegateCommand(ExecuteViewLoadedCommand);

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        void ExecuteViewLoadedCommand()
        {
            _regionManager.RequestNavigate(RegionNames.MAIN_REGION, nameof(MainView));
        }
    }
}
