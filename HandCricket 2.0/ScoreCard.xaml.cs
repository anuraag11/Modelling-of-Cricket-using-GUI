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
using MahApps.Metro.Controls;

namespace HandCricket_2._0
{
    /// <summary>
    /// Interaction logic for ScoreCard.xaml
    /// </summary>
    public partial class ScoreCard : MetroWindow
    {
        public ScoreCard()
        {
            InitializeComponent();
        }

        public void showScoreCard(string team1, string team2, string[] firstBatter,string[] secondBatter, int[] scores, int[] ballsUsed,
            int[] scores2, int[] ballsUsed2, int totalScore, int totalScore2, int no, int no2, int wicketsLeft, int wicketsLeft2)
        {
            TextBlock t1 = new TextBlock(); t1.FontSize = 20; t1.Height = 32;t1.Width = 485;
            t1.FontFamily = new FontFamily("Segoe UI Semibold"); t1.Foreground = new SolidColorBrush(Colors.Orange);
            TextBlock t0 = new TextBlock();
            t0.Text = ""; t0.Height = 32; t0.Width = 485;
            sp.Children.Add(t0);
            t1.Text = "  "+team1 +"  "+ totalScore.ToString() + "/" + no.ToString();
            sp.Children.Add(t1);
            TextBlock t01 = new TextBlock();
            t01.Text = ""; t01.Height = 32; t01.Width = 485;
            sp.Children.Add(t01);
            if(wicketsLeft==0)
            {
                for (int i = 0; i < no; i++)
                {
                    TextBlock t = new TextBlock(); t.FontSize = 19; t.Height = 32; t.Width = 400; t.FontFamily = new FontFamily("Segoe UI Semibold");
                    t.Text = "  " + firstBatter[i]; t.Foreground = new SolidColorBrush(Colors.Azure);
                    TextBlock q = new TextBlock(); q.FontSize = 19; q.Height = 32; q.Width = 85; q.FontFamily = new FontFamily("Segoe UI Semibold");
                    q.Text = scores[i] + " (" + ballsUsed[i] + ")"; q.Foreground = new SolidColorBrush(Colors.Azure);
                    sp.Children.Add(t); sp.Children.Add(q);
                }
            }
            else
            {
                for (int i = 0; i <= no; i++)
                {
                    TextBlock t = new TextBlock(); t.FontSize = 19; t.Height = 32; t.Width = 400; t.FontFamily = new FontFamily("Segoe UI Semibold");
                    t.Text = "  " + firstBatter[i]; t.Foreground = new SolidColorBrush(Colors.Azure);
                    TextBlock q = new TextBlock(); q.FontSize = 19; q.Height = 32; q.Width = 85; q.FontFamily = new FontFamily("Segoe UI Semibold");
                    q.Text = scores[i] + " (" + ballsUsed[i] + ")"; q.Foreground = new SolidColorBrush(Colors.Azure);
                    sp.Children.Add(t); sp.Children.Add(q);
                }
            }

            TextBlock t00 = new TextBlock();
            t00.Text = ""; t00.FontSize = 20; t00.Height = 32; t00.Width = 485;
            sp.Children.Add(t00);

            TextBlock t2 = new TextBlock(); t2.FontSize = 20; t2.Height = 32; t2.Width = 485;
            t2.Text = "  "+team2 + "  " + totalScore2.ToString() + "/" + no2.ToString();
            t2.FontFamily = new FontFamily("Segoe UI Semibold"); t2.Foreground = new SolidColorBrush(Colors.Orange);
            sp.Children.Add(t2);
            TextBlock t000 = new TextBlock();
            t000.Text = ""; t1.FontSize = 20; t000.Height = 32; t000.Width = 485;
            sp.Children.Add(t000);
            if(wicketsLeft2==0)
            {
                for (int i = 0; i < no2; i++)
                {
                    TextBlock t = new TextBlock();
                    t.Text = "  " + secondBatter[i]; t.FontSize = 19; t.Height = 32; t.Width = 400; t.FontFamily = new FontFamily("Segoe UI Semibold");
                    TextBlock q = new TextBlock(); q.FontSize = 19; q.Height = 32; q.Width = 85; q.FontFamily = new FontFamily("Segoe UI Semibold");
                    q.Text = scores2[i] + " (" + ballsUsed2[i] + ")";
                    t.Foreground = new SolidColorBrush(Colors.Azure); q.Foreground = new SolidColorBrush(Colors.Azure);
                    sp.Children.Add(t); sp.Children.Add(q);
                }
            }
            else
            {
                for (int i = 0; i <= no2; i++)
                {
                    TextBlock t = new TextBlock();
                    t.Text = "  " + secondBatter[i]; t.FontSize = 19; t.Height = 32; t.Width = 400; t.FontFamily = new FontFamily("Segoe UI Semibold");
                    TextBlock q = new TextBlock(); q.FontSize = 19; q.Height = 32; q.Width = 85; q.FontFamily = new FontFamily("Segoe UI Semibold");
                    q.Text = scores2[i] + " (" + ballsUsed2[i] + ")";
                    t.Foreground = new SolidColorBrush(Colors.Azure); q.Foreground = new SolidColorBrush(Colors.Azure);
                    sp.Children.Add(t); sp.Children.Add(q);
                }
            }

            TextBlock t001 = new TextBlock();
            t001.Text = ""; t001.FontSize = 20; t001.Height = 32; t001.Width = 485;
            sp.Children.Add(t001);

        }
    }
}
