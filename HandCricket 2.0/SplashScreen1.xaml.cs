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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace HandCricket_2._0
{
    /// <summary>
    /// Interaction logic for SplashScreen1.xaml
    /// </summary>
    public partial class SplashScreen1 : Window
    {
        public SplashScreen1()
        {
            InitializeComponent(); StartTimer();
        }

        DispatcherTimer timer = null;
        void StartTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(6);
            timer.Tick += new EventHandler(timer_Elapsed);
            timer.Start();
        }

        void timer_Elapsed(object sender, EventArgs e)
        {
            timer.Stop();

            MainWindow window = new MainWindow();
            window.Show(); Close();
        }
    }
}
