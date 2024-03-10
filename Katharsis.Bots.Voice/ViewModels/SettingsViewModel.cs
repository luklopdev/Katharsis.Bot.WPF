using Katharsis.Bot.Core.WPF;
using Prism.Commands;
using System;
using System.Windows;

namespace Katharsis.Bots.Voice.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {
        private DelegateCommand _saveCommand = default!;
        public DelegateCommand SaveCommand => _saveCommand ??=
            new DelegateCommand(ExecuteSaveCommand);

        void ExecuteSaveCommand()
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
