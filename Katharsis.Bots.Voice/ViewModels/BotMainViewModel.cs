using Discord;
using Discord.WebSocket;
using Katharsis.Bot.Core.WPF;
using Katharsis.Bots.Voice.Models;
using Prism.Commands;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Threading;

namespace Katharsis.Bots.Voice.ViewModels
{
    public class BotMainViewModel : ViewModelBase
    {
        private DiscordSocketClient _client = default!;

        private ObservableCollection<LogMessage> _logs = new ObservableCollection<LogMessage>();
        public ObservableCollection<LogMessage> Logs
        {
            get => _logs;
            set => SetProperty(ref _logs, value);
        }

        private DelegateCommand _startCommand = default!;
        public DelegateCommand StartCommand => _startCommand ??=
            new DelegateCommand(ExecuteStartCommand);

        async void ExecuteStartCommand()
        {   
            _client = new DiscordSocketClient();
            _client.Log += Log;
            await _client.LoginAsync(TokenType.Bot, TOKEN);
            await _client.StartAsync();
        }

        private async Task Log(LogMessage msg)
        {
            await Task.Run(() =>
            {
                Console.WriteLine(msg);
                Application.Current.Dispatcher.Invoke(() =>
                {
                    Logs.Add(msg);
                });
            });
        }
    }
}
