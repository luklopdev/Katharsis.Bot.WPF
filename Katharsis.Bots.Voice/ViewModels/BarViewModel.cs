using Katharsis.Bot.Core.WPF;
using Katharsis.Bots.Voice.Menus;
using Prism.Commands;
using Prism.Regions;

namespace Katharsis.Bots.Voice.ViewModels
{
    public class BarViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;

        private DelegateCommand _navigateCommand = default!;
        public DelegateCommand NavigateCommand => _navigateCommand ??=
            new DelegateCommand(ExecuteNavigateCommand);

        public BarViewModel(IRegionManager regionManger)
        {
            _regionManager = regionManger;
        }

        void ExecuteNavigateCommand()
        {

        }
    }
}
