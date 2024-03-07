using Katharsis.Bots.Voice.Interfaces;
using Katharsis.Bots.Voice.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Katharsis.Bots.Voice.Menus
{
    /// <summary>
    /// Interaction logic for BarNavigationItemBot.xaml
    /// </summary>
    public partial class BarNavigationItemBot : Button, IBarNavigationItem
    {
        public string View { get => nameof(BotMainView); }

        public BarNavigationItemBot()
        {
            InitializeComponent();
        }
    }
}
