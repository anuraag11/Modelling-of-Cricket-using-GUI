using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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

namespace HandCricket_2._0
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : MetroWindow
    {
        int wickets,target=0;
        string teamName1,teamName2;
        bool userBatsFirst,firstInnings=true,gameOver=false;
        string[] teamInd = {"Rohit Sharma","Shikhar Dhawan","Virat Kohli","Kedar Jadhav","MS Dhoni","Hardik Pandya","Ravindra Jadeja","Yuzvendra Chahal","Bhuvaneshwar Kumar","Jasprit Bumrah"};
        string[] teamEng = { "Jason Roy", "Alex Hales", "Joe Root", "Eoin Morgan", "Jos Buttler", "Jonny Bairstow", "Ben Stokes", "Liam Plunkett", "Chris Woakes", "David Willey" };
        string[] teamAus = { "David Warner", "Aaron Finch", "Steve Smith", "Glenn Maxwell", "Shane Watson", "Peter Handscomb", "Adam Zampa", "Mitchell Starc", "Pat Cummins", "Josh Hazlewood" };
        string[] teamSA = { "Quinton de Kock", "Hashim Amla", "Faf du Plessis", "AB de Villiers", "David Miller", "JP Duminy","Dale Steyn","Morne Morkel","Kagiso Rabada","Tabraiz Shamsi" };
        string[] userTeam; string[] computerTeam;
        int wicketsLeft,wicketsLeft2;
        int[] scores; int[] ballsUsed, scores2, ballsUsed2;
        int no = 0, no2 = 0; int totalScore = 0, totalScore2=0;

        public GameWindow()
        {
            InitializeComponent();
        }

        public void inputData(int w, string t1, string t2,bool uBatFirst)
        {
            wickets = w; teamName1 = t1; teamName2 = t2;
            team1.Text = t1; team2.Text = t2;
            userBatsFirst = uBatFirst;
            string[] userTeam = new string[wickets];
            string[] computerTeam = new string[wickets];
            if (teamName1 == "IND") {for (int i = 0; i < wickets; i++) userTeam[i] = teamInd[i]; }
            if (teamName1 == "ENG") { for (int i = 0; i < wickets; i++) userTeam[i] = teamEng[i]; }
            if (teamName1 == "AUS") { for (int i = 0; i < wickets; i++) userTeam[i] = teamAus[i]; }
            if (teamName1 == "SA") { for (int i = 0; i < wickets; i++) userTeam[i] = teamSA[i]; }
            if (teamName2 == "IND") { for (int i = 0; i < wickets; i++) computerTeam[i] = teamInd[i]; }
            if (teamName2 == "ENG") { for (int i = 0; i < wickets; i++) computerTeam[i] = teamEng[i]; }
            if (teamName2 == "AUS") { for (int i = 0; i < wickets; i++) computerTeam[i] = teamAus[i]; }
            if (teamName2 == "SA") { for (int i = 0; i < wickets; i++) computerTeam[i] = teamSA[i]; }
            initializeData(userTeam,computerTeam);
        }

        private void click1_Click(object sender, RoutedEventArgs e)
        {
            runGame(1);
        }

        private void click2_Click(object sender, RoutedEventArgs e)
        {
            runGame(2);
        }

        private void click3_Click(object sender, RoutedEventArgs e)
        {
            runGame(3);
        }

        private void click4_Click(object sender, RoutedEventArgs e)
        {
            runGame(4);
        }

        private void click5_Click(object sender, RoutedEventArgs e)
        {
            runGame(5);
        }

        private void click6_Click(object sender, RoutedEventArgs e)
        {
            runGame(6);
        }

        private void click7_Click(object sender, RoutedEventArgs e)
        {
            runGame(7);
        }

        private void click8_Click(object sender, RoutedEventArgs e)
        {
            runGame(8);
        }

        private void click9_Click(object sender, RoutedEventArgs e)
        {
            runGame(9);
        }

        private void click10_Click(object sender, RoutedEventArgs e)
        {
            runGame(10);
        }

        private void viewScoreCard_Click(object sender, RoutedEventArgs e)
        {
            ScoreCard ob = new ScoreCard();
            if(userBatsFirst)
                ob.showScoreCard(team1.Text, team2.Text, userTeam, computerTeam, scores, ballsUsed, scores2, ballsUsed2, totalScore, totalScore2, no, no2, wicketsLeft, wicketsLeft2);
            else
                ob.showScoreCard(team2.Text, team1.Text, computerTeam, userTeam, scores, ballsUsed, scores2, ballsUsed2, totalScore, totalScore2, no, no2, wicketsLeft, wicketsLeft2);
            ob.Show();

        }

        public void initializeData(string[] uteam,string[] cteam)
        {
            wicketsLeft = wickets;
            wicketsLeft2 = wickets;
            scores = new int[wickets];
            ballsUsed = new int[wickets];
            scores2 = new int[wickets];
            ballsUsed2 = new int[wickets];
            userTeam = new string[wickets]; computerTeam = new string[wickets];
            for (int i=0;i<wickets;i++)
            {
                userTeam[i] = uteam[i]; computerTeam[i] = cteam[i];
                scores[i] = 0; ballsUsed[i] = 0; scores2[i] = 0; ballsUsed2[i] = 0;
            }   
        }

        Random r = new Random();



        public async void runGame(int a)
        {
            int b = r.Next(1, 11);
            if(userBatsFirst && !gameOver)
            {
                if(firstInnings)
                {
                    ballsUsed[no] += 1;
                    if (a!=b)
                    {
                        totalScore += a; scores[no] += a;
                        team1_Score.Text = totalScore.ToString() + "/" + no.ToString();
                        batsman.Text = userTeam[no] + "*  " + scores[no] + " (" + ballsUsed[no] + ")";
                        myThrow.Text = a.ToString(); compThrow.Text = b.ToString();
                    }
                    else
                    {
                        wicketsLeft -= 1; no += 1;
                        team1_Score.Text = totalScore.ToString() + "/" + no.ToString();
                        if(wicketsLeft!=0) batsman.Text = userTeam[no] + "*  " + scores[no] + " (" + ballsUsed[no] + ")";
                        myThrow.Text = a.ToString(); compThrow.Text = b.ToString();
                        if (wicketsLeft == 0)
                        {
                            batsman.Text = userTeam[no-1] + "  " + scores[no-1] + " (" + ballsUsed[no-1] + ")";
                            firstInnings = false; target = totalScore + 1;                           
                            targetBlock.Text = target.ToString();
                        }
                    }
                }

                else
                {
                    ballsUsed2[no2] += 1;
                    if (a != b)
                    {
                        totalScore2 += b; scores2[no2] += b;
                        team2_Score.Text = totalScore2.ToString() + "/" + no2.ToString();
                        batsman.Text = computerTeam[no2] + "*  " + scores2[no2] + " (" + ballsUsed2[no2] + ")";
                        myThrow.Text = a.ToString(); compThrow.Text = b.ToString();
                        if (totalScore2 >= target) { await this.ShowMessageAsync("Computer Won!", "Better luck next time!"); gameOver = true; }
                    }
                    else
                    {
                        wicketsLeft2 -= 1; no2 += 1;
                        team2_Score.Text = totalScore2.ToString() + "/" + no2.ToString();
                        if (wicketsLeft2 != 0) batsman.Text = computerTeam[no2] + "*  " + scores2[no2] + " (" + ballsUsed2[no2] + ")";
                        myThrow.Text = a.ToString(); compThrow.Text = b.ToString();
                        if (wicketsLeft2 == 0)
                        {
                            batsman.Text = computerTeam[no2 - 1] + "  " + scores2[no2 - 1] + " (" + ballsUsed2[no2 - 1] + ")";
                            gameOver = true;
                            if(totalScore2==target-1) await this.ShowMessageAsync("Match Drawn!", "That was certainly a thriller!");
                            else await this.ShowMessageAsync("You Won!", "You defeated the computer!");
                        }
                    }
                }
            }

            else if(!userBatsFirst && !gameOver)
            {
                if (firstInnings)
                {
                    ballsUsed[no] += 1;
                    if (a != b)
                    {
                        totalScore += b; scores[no] += b;
                        team2_Score.Text = totalScore.ToString() + "/" + no.ToString();
                        batsman.Text = computerTeam[no] + "*  " + scores[no] + " (" + ballsUsed[no] + ")";
                        myThrow.Text = a.ToString(); compThrow.Text = b.ToString();
                    }
                    else
                    {
                        wicketsLeft -= 1; no += 1;
                        team2_Score.Text = totalScore.ToString() + "/" + no.ToString();
                        if (wicketsLeft != 0) batsman.Text = computerTeam[no] + "*  " + scores[no] + " (" + ballsUsed[no] + ")";
                        myThrow.Text = a.ToString(); compThrow.Text = b.ToString();
                        if (wicketsLeft == 0)
                        {
                            batsman.Text = computerTeam[no - 1] + "  " + scores[no - 1] + " (" + ballsUsed[no - 1] + ")";
                            firstInnings = false; target = totalScore + 1;
                            targetBlock.Text = target.ToString();
                        }
                    }
                }

                else
                {
                    ballsUsed2[no2] += 1;
                    if (a != b)
                    {
                        totalScore2 += a; scores2[no2] += a;
                        team1_Score.Text = totalScore2.ToString() + "/" + no2.ToString();
                        batsman.Text = userTeam[no2] + "*  " + scores2[no2] + " (" + ballsUsed2[no2] + ")";
                        myThrow.Text = a.ToString(); compThrow.Text = b.ToString();
                        if (totalScore2 >= target) { await this.ShowMessageAsync("You Won!", "You defeated the computer!"); gameOver = true; }
                    }
                    else
                    {
                        wicketsLeft2 -= 1; no2 += 1;
                        team1_Score.Text = totalScore2.ToString() + "/" + no2.ToString();
                        if (wicketsLeft2 != 0) batsman.Text = userTeam[no2] + "*  " + scores2[no2] + " (" + ballsUsed2[no2] + ")";
                        myThrow.Text = a.ToString(); compThrow.Text = b.ToString();
                        if (wicketsLeft2 == 0)
                        {
                            batsman.Text = userTeam[no2 - 1] + "  " + scores2[no2 - 1] + " (" + ballsUsed2[no2 - 1] + ")";
                            gameOver = true;
                            if (totalScore2 == target - 1) await this.ShowMessageAsync("Match Drawn!", "That was certainly a thriller!");
                            else await this.ShowMessageAsync("Computer Won!", "Better luck next time!");
                        }
                    }
                }
            }
        }

    }
}
