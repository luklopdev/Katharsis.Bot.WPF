using Katharsis.Bot.Core;
using Katharsis.Bot.Core.WPF;
using Katharsis.Bots.Voice.Views;
using Prism.Commands;
using Prism.Regions;

namespace Katharsis.Bots.Voice.ViewModels
{
    public class BotListMenuItemViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;

        private DelegateCommand _selectedCommand = default!;
        public DelegateCommand SelectedCommand => _selectedCommand ??=
            new DelegateCommand(ExecuteSelectedCommand);

        public BotListMenuItemViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        void ExecuteSelectedCommand()
        {
            _regionManager.RequestNavigate(RegionNames.MAIN_VIEW_MAIN_REGION, nameof(BotShellView));
        }
    }
}
