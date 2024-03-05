using Katharsis.Bot.WPF.ViewModels;
using Katharsis.Bot.WPF.Views;
using Katharsis.Bots.Voice;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Katharsis.Bot.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            #region Navigation
            containerRegistry.RegisterForNavigation<MainView, MainViewModel>();
            #endregion

            #region Singleton

            #endregion
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<KatharsisVoiceBot>();
        }
    }

}
