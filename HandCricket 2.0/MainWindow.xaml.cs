using MahApps.Metro.Controls;
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
using System.Threading;
using MahApps.Metro.Controls.Dialogs;

namespace HandCricket_2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void proceed_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gw = new GameWindow();
            bool q=false;
            if (fieldf.IsChecked == true) q = false;
            else if (batf.IsChecked == true) q = true;
            gw.inputData((int)wickets.Value,team1.Text,team2.Text,q);
            gw.Show(); Close();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            String s1 = "About";
            String s2 = "HandCricket v2.0\nCopyright © Anuraag Ghosh 2021. All rights reserved.\n\nMade for the love of our old school pastime.";
            await this.ShowMessageAsync(s1, s2);
        }
    }
}
