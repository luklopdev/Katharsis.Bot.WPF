using Katharsis.Bot.Core.WPF;
using Katharsis.Bots.Voice.Core;
using Katharsis.Bots.Voice.Interfaces;
using Katharsis.Bots.Voice.Menus;
using Prism.Commands;
using Prism.Regions;
using System.Windows;

namespace Katharsis.Bots.Voice.ViewModels
{
    public class BarViewModel : ViewModelBase
    {
        private readonly IRegionManager _regionManager;

        private DelegateCommand<IBarNavigationItem> _navigateCommand = default!;
        public DelegateCommand<IBarNavigationItem> NavigateCommand => _navigateCommand ??=
            new DelegateCommand<IBarNavigationItem>(ExecuteNavigateCommand);

        public BarViewModel(IRegionManager regionManger)
        {
            _regionManager = regionManger;
        }

        void ExecuteNavigateCommand(IBarNavigationItem navigationItem)
        {
            try
            {
                if(navigationItem != null)
                    _regionManager.RequestNavigate(RegionNames.SHELL_MAIN_REGION, navigationItem.View);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
