﻿using System;
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
    /// Interaction logic for BotListMenuItem.xaml
    /// </summary>
    public partial class BotListMenuItem : ListBoxItem
    {
        public BotListMenuItem()
        {
            InitializeComponent();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
