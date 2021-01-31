using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TournamentPro
{
    /// <summary>
    /// Interaction logic for GroupStage.xaml
    /// </summary>
    public partial class GroupStage : Window
    {
        string c1t1 = "";
        string c1t2 = "";
        string c2t1 = "";
        string c2t2 = "";
        string c3t1 = "";
        string c3t2 = "";
        string c4t1 = "";
        string c4t2 = "";


        int Team1Score = 0;
        int Team2Score = 0;
        int Team3Score = 0;
        int Team4Score = 0;
        int Team5Score = 0;
        int Team6Score = 0;
        int Team7Score = 0;
        int Team8Score = 0;

        int Team1PointsAgainst = 0;
        int Team2PointsAgainst = 0;
        int Team3PointsAgainst = 0;
        int Team4PointsAgainst = 0;
        int Team5PointsAgainst = 0;
        int Team6PointsAgainst = 0;
        int Team7PointsAgainst = 0;
        int Team8PointsAgainst = 0;

        int Team1Wins = 0;
        int Team2Wins = 0;
        int Team3Wins = 0;
        int Team4Wins = 0;
        int Team5Wins = 0;
        int Team6Wins = 0;
        int Team7Wins = 0;
        int Team8Wins = 0;

        List<string> team1Players;
        List<string> team2Players;
        List<string> team3Players;
        List<string> team4Players;
        List<string> team5Players;
        List<string> team6Players;
        List<string> team7Players;
        List<string> team8Players;

        List<string> Game1 = new List<string> { };
        List<string> Game2 = new List<string> { };
        List<string> Game3 = new List<string> { };
        List<string> Game4 = new List<string> { };
        List<string> Game5 = new List<string> { };
        List<string> Game6 = new List<string> { };
        List<string> Game7 = new List<string> { };
        List<string> Game8 = new List<string> { };
        List<string> Game9 = new List<string> { };
        List<string> Game10 = new List<string> { };
        List<string> Game11 = new List<string> { };
        List<string> Game12 = new List<string> { };
        List<string> Game13 = new List<string> { };
        List<string> Game14 = new List<string> { };
        List<string> Game15 = new List<string> { };
        List<string> Game16 = new List<string> { };
        List<string> Game17 = new List<string> { };
        List<string> Game18 = new List<string> { };
        List<string> Game19 = new List<string> { };
        List<string> Game20 = new List<string> { };
        List<string> Game21 = new List<string> { };
        List<string> Game22 = new List<string> { };
        List<string> Game23 = new List<string> { };
        List<string> Game24 = new List<string> { };

        List<List<string>> GamesList = new List<List<string>> { };
        List<List<string>> GamesList2 = new List<List<string>> { };

        public GroupStage(List<string> t1, List<string> t2, List<string> t3, List<string> t4, List<string> t5, List<string> t6, List<string> t7, List<string> t8)
        {
            InitializeComponent();
            Next.IsEnabled = false;
            team1Players = t1;
            team2Players = t2;
            team3Players = t3;
            team4Players = t4;
            team5Players = t5;
            team6Players = t6;
            team7Players = t7;
            team8Players = t8;
            assignGames1stHalf();
            assignGames2ndHalf();
            Court1Details();
            Court2Details();
            Court2Next();
            Court3Details();
            Court4Details();
            Court4Next();
        }

        private void scoreCollectC1T1()
        {
            if (c1t1 == "team1")
            {
                var score = Game1T1Score.Text;
                Team1Score += Int32.Parse(score);
                var scoreAgainst = Game1T2Score.Text;
                Team1PointsAgainst += Int32.Parse(score);
                if (Int32.Parse(score) == 21)
                {
                    Team1Wins += 1;
                }
            }
            else if (c1t1 == "team2")
            {
                var score = Game1T1Score.Text;
                Team2Score += Int32.Parse(score);
                var scoreAgainst = Game1T2Score.Text;
                Team2PointsAgainst += Int32.Parse(score);
                {
                    Team2Wins += 1;
                }
            }
            else if (c1t1 == "team3")
            {
                var score = Game1T1Score.Text;
                Team3Score += Int32.Parse(score);
                var scoreAgainst = Game1T2Score.Text;
                Team3PointsAgainst += Int32.Parse(score);
                {
                    Team3Wins += 1;
                }
            }
            else
            {
                var score = Game1T1Score.Text;
                Team4Score += Int32.Parse(score);
                var scoreAgainst = Game1T2Score.Text;
                Team4PointsAgainst += Int32.Parse(score);
                {
                    Team4Wins += 1;
                }
            }
            Game1T1Score.Clear();
        }
        private void scoreCollectC1T2()
        {
            if (c1t2 == "team1")
            {
                var score = Game1T2Score.Text;
                Team1Score += Int32.Parse(score);
                var scoreAgainst = Game1T1Score.Text;
                Team1PointsAgainst += Int32.Parse(score);
            }
            else if (c1t2 == "team2")
            {
                var score = Game1T2Score.Text;
                Team2Score += Int32.Parse(score);
                var scoreAgainst = Game1T1Score.Text;
                Team2PointsAgainst += Int32.Parse(score);
            }
            else if (c1t2 == "team3")
            {
                var score = Game1T2Score.Text;
                Team3Score += Int32.Parse(score);
                var scoreAgainst = Game1T1Score.Text;
                Team3PointsAgainst += Int32.Parse(score);
            }
            else
            {
                var score = Game1T2Score.Text;
                Team4Score += Int32.Parse(score);
                Team4PointsAgainst += Int32.Parse(score);
                var scoreAgainst = Game1T1Score.Text;
                Team4PointsAgainst += Int32.Parse(score);
            }
            Game1T2Score.Clear();
        }

        private void scoreCollectC2T1()
        {
            if (c2t1 == "team1")
            {
                var score = Game2T1Score.Text;
                Team1Score += Int32.Parse(score);
                var scoreAgainst = Game2T2Score.Text;
                Team1PointsAgainst += Int32.Parse(score);
            }
            else if (c2t1 == "team2")
            {
                var score = Game2T1Score.Text;
                Team2Score += Int32.Parse(score);
                var scoreAgainst = Game2T2Score.Text;
                Team2PointsAgainst += Int32.Parse(score);
            }
            else if (c2t1 == "team3")
            {
                var score = Game2T1Score.Text;
                Team3Score += Int32.Parse(score);
                var scoreAgainst = Game2T2Score.Text;
                Team3PointsAgainst += Int32.Parse(score);
            }
            else
            {
                var score = Game2T1Score.Text;
                Team4Score += Int32.Parse(score);
                Team4PointsAgainst += Int32.Parse(score);
                var scoreAgainst = Game2T2Score.Text;
                Team4PointsAgainst += Int32.Parse(score);
            }
            Game2T1Score.Clear();
        }

        private void scoreCollectC2T2()
        {
            if (c2t2 == "team1")
            {
                var score = Game2T2Score.Text;
                Team1Score += Int32.Parse(score);
                var scoreAgainst = Game2T1Score.Text;
                Team1PointsAgainst += Int32.Parse(score);
            }
            else if (c2t2 == "team2")
            {
                var score = Game2T2Score.Text;
                Team2Score += Int32.Parse(score);
                var scoreAgainst = Game2T1Score.Text;
                Team2PointsAgainst += Int32.Parse(score);
            }
            else if (c2t2 == "team3")
            {
                var score = Game2T2Score.Text;
                Team3Score += Int32.Parse(score);
                var scoreAgainst = Game2T1Score.Text;
                Team3PointsAgainst += Int32.Parse(score);
            }
            else
            {
                var score = Game2T2Score.Text;
                Team4Score += Int32.Parse(score);
                Team4PointsAgainst += Int32.Parse(score);
                var scoreAgainst = Game2T1Score.Text;
                Team4PointsAgainst += Int32.Parse(score);
            }
            Game2T2Score.Clear();
        }

        private void scoreCollectC3T1()
        {
            if (c3t1 == "team5")
            {
                var score = Game3T1Score.Text;
                Team1Score += Int32.Parse(score);
                var scoreAgainst = Game3T2Score.Text;
                Team1PointsAgainst += Int32.Parse(score);
            }
            else if (c3t1 == "team6")
            {
                var score = Game3T1Score.Text;
                Team2Score += Int32.Parse(score);
                var scoreAgainst = Game3T2Score.Text;
                Team2PointsAgainst += Int32.Parse(score);
            }
            else if (c3t1 == "team7")
            {
                var score = Game3T1Score.Text;
                Team3Score += Int32.Parse(score);
                var scoreAgainst = Game3T2Score.Text;
                Team3PointsAgainst += Int32.Parse(score);
            }
            else
            {
                var score = Game3T1Score.Text;
                Team4Score += Int32.Parse(score);
                Team4PointsAgainst += Int32.Parse(score);
                var scoreAgainst = Game3T2Score.Text;
                Team4PointsAgainst += Int32.Parse(score);
            }
            Game3T1Score.Clear();
        }

        private void scoreCollectC3T2()
        {
            if (c3t2 == "team5")
            {
                var score = Game3T2Score.Text;
                Team1Score += Int32.Parse(score);
                var scoreAgainst = Game3T1Score.Text;
                Team1PointsAgainst += Int32.Parse(score);
            }
            else if (c3t2 == "team6")
            {
                var score = Game3T2Score.Text;
                Team2Score += Int32.Parse(score);
                var scoreAgainst = Game3T1Score.Text;
                Team2PointsAgainst += Int32.Parse(score);
            }
            else if (c3t2 == "team7")
            {
                var score = Game3T2Score.Text;
                Team3Score += Int32.Parse(score);
                var scoreAgainst = Game3T1Score.Text;
                Team3PointsAgainst += Int32.Parse(score);
            }
            else
            {
                var score = Game3T2Score.Text;
                Team4Score += Int32.Parse(score);
                Team4PointsAgainst += Int32.Parse(score);
                var scoreAgainst = Game3T1Score.Text;
                Team4PointsAgainst += Int32.Parse(score);
            }
            Game3T2Score.Clear();
        }

        private void scoreCollectC4T1()
        {
            if (c4t1 == "team5")
            {
                var score = Game4T1Score.Text;
                Team1Score += Int32.Parse(score);
                var scoreAgainst = Game4T2Score.Text;
                Team1PointsAgainst += Int32.Parse(score);
            }
            else if (c4t1 == "team6")
            {
                var score = Game4T1Score.Text;
                Team2Score += Int32.Parse(score);
                var scoreAgainst = Game4T2Score.Text;
                Team2PointsAgainst += Int32.Parse(score);
            }
            else if (c4t1 == "team7")
            {
                var score = Game4T1Score.Text;
                Team3Score += Int32.Parse(score);
                var scoreAgainst = Game4T2Score.Text;
                Team3PointsAgainst += Int32.Parse(score);
            }
            else
            {
                var score = Game4T1Score.Text;
                Team4Score += Int32.Parse(score);
                Team4PointsAgainst += Int32.Parse(score);
                var scoreAgainst = Game4T2Score.Text;
                Team4PointsAgainst += Int32.Parse(score);
            }
            Game4T1Score.Clear();
        }

        private void scoreCollectC4T2()
        {
            if (c4t2 == "team5")
            {
                var score = Game4T2Score.Text;
                Team1Score += Int32.Parse(score);
                var scoreAgainst = Game4T1Score.Text;
                Team1PointsAgainst += Int32.Parse(score);
            }
            else if (c4t2 == "team6")
            {
                var score = Game4T2Score.Text;
                Team2Score += Int32.Parse(score);
                var scoreAgainst = Game4T1Score.Text;
                Team2PointsAgainst += Int32.Parse(score);
            }
            else if (c4t2 == "team7")
            {
                var score = Game4T2Score.Text;
                Team3Score += Int32.Parse(score);
                var scoreAgainst = Game4T1Score.Text;
                Team3PointsAgainst += Int32.Parse(score);
            }
            else
            {
                var score = Game4T2Score.Text;
                Team4Score += Int32.Parse(score);
                Team4PointsAgainst += Int32.Parse(score);
                var scoreAgainst = Game4T1Score.Text;
                Team4PointsAgainst += Int32.Parse(score);
            }
            Game4T2Score.Clear();
        }

        private void assignGames1stHalf()
        {
            //Game 1 Players
            Game1.Add(team1Players[0].ToString());
            Game1.Add(team1Players[1]);
            Game1.Add(team4Players[0]);
            Game1.Add(team4Players[1]);
            Game1.Add("team1");
            Game1.Add("team4");
            //Game 2 Players
            Game2.Add(team3Players[0]);
            Game2.Add(team3Players[1]);
            Game2.Add(team2Players[0]);
            Game2.Add(team2Players[1]);
            Game2.Add("team3");
            Game2.Add("team2");
            //Game 3 Players
            Game3.Add(team1Players[1]);
            Game3.Add(team1Players[2]);
            Game3.Add(team3Players[1]);
            Game3.Add(team3Players[2]);
            Game3.Add("team1");
            Game3.Add("team3");
            //Game 4 Players
            Game4.Add(team2Players[1]);
            Game4.Add(team2Players[2]);
            Game4.Add(team4Players[1]);
            Game4.Add(team4Players[2]);
            Game4.Add("team2");
            Game4.Add("team4");
            //Game 5 Players
            Game5.Add(team1Players[0]);
            Game5.Add(team1Players[2]);
            Game5.Add(team2Players[0]);
            Game5.Add(team2Players[2]);
            Game5.Add("team1");
            Game5.Add("team2");
            //Game 6 Players
            Game6.Add(team3Players[0]);
            Game6.Add(team3Players[2]);
            Game6.Add(team4Players[0]);
            Game6.Add(team4Players[2]);
            Game6.Add("team3");
            Game6.Add("team4");
            //Game 7 Players
            Game7.Add(team1Players[0]);
            Game7.Add(team1Players[1]);
            Game7.Add(team3Players[0]);
            Game7.Add(team3Players[1]);
            Game7.Add("team1");
            Game7.Add("team3");
            //Game 8 Players
            Game8.Add(team2Players[0]);
            Game8.Add(team2Players[1]);
            Game8.Add(team4Players[0]);
            Game8.Add(team4Players[1]);
            Game8.Add("team2");
            Game8.Add("team4");
            //Game 9 Players
            Game9.Add(team1Players[1]);
            Game9.Add(team1Players[2]);
            Game9.Add(team4Players[1]);
            Game9.Add(team4Players[2]);
            Game9.Add("team1");
            Game9.Add("team4");
            //Game 10 Players
            Game10.Add(team2Players[1]);
            Game10.Add(team2Players[2]);
            Game10.Add(team3Players[1]);
            Game10.Add(team3Players[2]); 
            Game10.Add("team2");
            Game10.Add("team3");
            //Game 11 Players
            Game11.Add(team1Players[0]);
            Game11.Add(team1Players[2]);
            Game11.Add(team2Players[0]);
            Game11.Add(team2Players[2]);
            Game11.Add("team1");
            Game11.Add("team2");
            //Game 12 Players
            Game12.Add(team4Players[0]);
            Game12.Add(team4Players[2]);
            Game12.Add(team3Players[0]);
            Game12.Add(team3Players[2]);
            Game12.Add("team4");
            Game12.Add("team3");

            GamesList.Add(Game1);
            GamesList.Add(Game2);
            //GamesList.Add(Game3);
            //GamesList.Add(Game4);
            //GamesList.Add(Game5);
            //GamesList.Add(Game6);
            //GamesList.Add(Game7);
            //GamesList.Add(Game8);
            //GamesList.Add(Game9);
            //GamesList.Add(Game10);
            //GamesList.Add(Game11);
            //GamesList.Add(Game12);
        }

        private void assignGames2ndHalf()
        {
            //Game 13 Players
            Game13.Add(team5Players[0].ToString());
            Game13.Add(team5Players[1]);
            Game13.Add(team8Players[0]);
            Game13.Add(team8Players[1]);
            Game13.Add("team5");
            Game13.Add("team8");
            //Game 14 Players
            Game14.Add(team7Players[0]);
            Game14.Add(team7Players[1]);
            Game14.Add(team6Players[0]);
            Game14.Add(team6Players[1]);
            Game14.Add("team7");
            Game14.Add("team6");
            //Game 15 Players
            Game15.Add(team5Players[1]);
            Game15.Add(team5Players[2]);
            Game15.Add(team7Players[1]);
            Game15.Add(team7Players[2]);
            Game15.Add("team5");
            Game15.Add("team7");
            //Game 16 Players
            Game16.Add(team6Players[1]);
            Game16.Add(team6Players[2]);
            Game16.Add(team8Players[1]);
            Game16.Add(team8Players[2]);
            Game16.Add("team6");
            Game16.Add("team8");
            //Game 17 Players
            Game17.Add(team5Players[0]);
            Game17.Add(team5Players[2]);
            Game17.Add(team6Players[0]);
            Game17.Add(team6Players[2]);
            Game17.Add("team5");
            Game17.Add("team6");
            //Game 18 Players
            Game18.Add(team7Players[0]);
            Game18.Add(team7Players[2]);
            Game18.Add(team8Players[0]);
            Game18.Add(team8Players[2]);
            Game18.Add("team7");
            Game18.Add("team8");
            //Game 19 Players
            Game19.Add(team5Players[0]);
            Game19.Add(team5Players[1]);
            Game19.Add(team7Players[0]);
            Game19.Add(team7Players[1]);
            Game19.Add("team5");
            Game19.Add("team7");
            //Game 20 Players
            Game20.Add(team6Players[0]);
            Game20.Add(team6Players[1]);
            Game20.Add(team8Players[0]);
            Game20.Add(team8Players[1]);
            Game20.Add("team6");
            Game20.Add("team8");
            //Game 21 Players
            Game21.Add(team5Players[1]);
            Game21.Add(team5Players[2]);
            Game21.Add(team8Players[1]);
            Game21.Add(team8Players[2]);
            Game21.Add("team5");
            Game21.Add("team8");
            //Game 22 Players
            Game22.Add(team6Players[1]);
            Game22.Add(team6Players[2]);
            Game22.Add(team7Players[1]);
            Game22.Add(team7Players[2]);
            Game22.Add("team6");
            Game22.Add("team7");
            //Game 23 Players
            Game23.Add(team5Players[0]);
            Game23.Add(team5Players[2]);
            Game23.Add(team6Players[0]);
            Game23.Add(team6Players[2]);
            Game23.Add("team5");
            Game23.Add("team6");
            //Game 24 Players
            Game24.Add(team8Players[0]);
            Game24.Add(team8Players[2]);
            Game24.Add(team7Players[0]);
            Game24.Add(team7Players[2]);
            Game24.Add("team8");
            Game24.Add("team7");

            GamesList2.Add(Game13);
            GamesList2.Add(Game14);
            //GamesList2.Add(Game15);
            //GamesList2.Add(Game16);
            //GamesList2.Add(Game17);
            //GamesList2.Add(Game18);
            //GamesList2.Add(Game19);
            //GamesList2.Add(Game20);
            //GamesList2.Add(Game21);
            //GamesList2.Add(Game22);
            //GamesList2.Add(Game23);
            //GamesList2.Add(Game24);
        }

        private void Court1Details()
        {
            if (GamesList.Count > 0)
            {
                var selectedGame = GamesList[0];
                string p1 = selectedGame[0].ToString() + "\n" + "+" + "\n" + selectedGame[1].ToString();
                G1P1.Text = p1;

                string p2 = selectedGame[2].ToString() + "\n" + "+" + "\n" + selectedGame[3].ToString();
                G1P2.Text = p2;

                c1t1 = GamesList[0][4];
                c1t2 = GamesList[0][5];
                GamesList.RemoveAt(0);
            }
            else
            {
                var selectedGame = GamesList[0];
                string p1 = "" + "\n" + "+" + "\n" + "";
                C2NG1.Text = p1;

                string p2 = "" + "\n" + "+" + "\n" + "";
                C2NG2.Text = p2;
            }
            if (GamesList.Count == 0 && GamesList2.Count == 0)
            {
                Next.IsEnabled = true;
            }
        }

        private void Court2Details()
        {
            if (GamesList.Count > 0)
            {
                var selectedGame = GamesList[0];
                string p1 = selectedGame[0].ToString() + "\n" + "+" + "\n" + selectedGame[1].ToString();
                G2P1.Text = p1;

                string p2 = selectedGame[2].ToString() + "\n" + "+" + "\n" + selectedGame[3].ToString();
                G2P2.Text = p2;

                c2t1 = GamesList[0][4];
                c2t2 = GamesList[0][5];
                GamesList.RemoveAt(0);
            }
            else
            {
                var selectedGame = GamesList[0];
                string p1 = "" + "\n" + "+" + "\n" + "";
                C2NG1.Text = p1;

                string p2 = "" + "\n" + "+" + "\n" + "";
                C2NG2.Text = p2;
            }
            if (GamesList.Count == 0 && GamesList2.Count == 0)
            {
                Next.IsEnabled = true;
            }
        }

        private void Court2Next()
        {
            if (GamesList.Count > 0)
            {
                var selectedGame = GamesList[0];
                string p1 = selectedGame[0].ToString() + "\n" + "+" + "\n" + selectedGame[1].ToString();
                C2NG1.Text = p1;

                string p2 = selectedGame[2].ToString() + "\n" + "+" + "\n" + selectedGame[3].ToString();
                C2NG2.Text = p2;
            }
            else
            {

                string p1 = "" + "\n" + "+" + "\n" + "";
                C2NG1.Text = p1;

                string p2 = "" + "\n" + "+" + "\n" + "";
                C2NG2.Text = p2;
            }
        }

        private void Court3Details()
        {
            if (GamesList2.Count > 0)
            {
                var selectedGame = GamesList2[0];
                string p1 = selectedGame[0].ToString() + "\n" + "+" + "\n" + selectedGame[1].ToString();
                G3P1.Text = p1;

                string p2 = selectedGame[2].ToString() + "\n" + "+" + "\n" + selectedGame[3].ToString();
                G3P2.Text = p2;

                c3t1 = GamesList2[0][4];
                c3t2 = GamesList2[0][5];
                GamesList2.RemoveAt(0);
            }
            else
            {
                var selectedGame = GamesList2[0];
                string p1 = "" + "\n" + "+" + "\n" + "";
                C4NG1.Text = p1;

                string p2 = "" + "\n" + "+" + "\n" + "";
                C4NG2.Text = p2;
            }
            if (GamesList.Count == 0 && GamesList2.Count == 0)
            {
                Next.IsEnabled = true;
            }

        }



        private void Court4Details()
        {
            if (GamesList2.Count > 0)
            {
                var selectedGame = GamesList2[0];
                string p1 = selectedGame[0].ToString() + "\n" + "+" + "\n" + selectedGame[1].ToString();
                G4P1.Text = p1;

                string p2 = selectedGame[2].ToString() + "\n" + "+" + "\n" + selectedGame[3].ToString();
                G4P2.Text = p2;

                c4t1 = GamesList2[0][4];
                c4t2 = GamesList2[0][5];
                GamesList2.RemoveAt(0);
            }
            else
            {
                var selectedGame = GamesList2[0];
                string p1 = "" + "\n" + "+" + "\n" + "";
                C4NG1.Text = p1;

                string p2 = "" + "\n" + "+" + "\n" + "";
                C4NG2.Text = p2;
            }
            if (GamesList.Count == 0 && GamesList2.Count == 0)
            {
                Next.IsEnabled = true;
            }
        }

        private void Court4Next()
        {
            if (GamesList2.Count > 0)
            {
                var selectedGame = GamesList2[0];
                string p1 = selectedGame[0].ToString() + "\n" + "+" + "\n" + selectedGame[1].ToString();
                C4NG1.Text = p1;

                string p2 = selectedGame[2].ToString() + "\n" + "+" + "\n" + selectedGame[3].ToString();
                C4NG2.Text = p2;
            }
            else
            {

                string p1 = "" + "\n" + "+" + "\n" + "";
                C4NG1.Text = p1;

                string p2 = "" + "\n" + "+" + "\n" + "";
                C4NG2.Text = p2;
            }
        }

        private void Game1Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var T1score = Game1T1Score.Text;
                var T1S = Int32.Parse(T1score);
                var T2score = Game1T2Score.Text;
                var T2S = Int32.Parse(T2score);

                if ((T1S == 21) && (T2S < 21) || (T2S == 21) && (T1S < 21))
                {
                    C1Info.Text = "";
                    scoreCollectC1T1();
                    scoreCollectC1T2();
                    Court1Details();
                    Court2Next();
                }
                else
                {
                    C1Info.Text = "Scores must be to 21 with no setting";
                }
            }
            catch
            {
                C1Info.Text = "A score must be entered";
            }
        }

        private void Game2Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var T1score = Game2T1Score.Text;
                var T1S = Int32.Parse(T1score);
                var T2score = Game2T2Score.Text;
                var T2S = Int32.Parse(T2score);

                if ((T1S == 21) && (T2S < 21) || (T2S == 21) && (T1S < 21))
                {
                    C2Info.Text = "";
                    scoreCollectC2T1();
                    scoreCollectC2T2();
                    Court2Details();
                    Court2Next();
                }
                else
                {
                    C2Info.Text = "Scores must be to 21 with no setting";
                }
            }
            catch
            {
                C2Info.Text = "A score must be entered";
            }
        }

        private void Game3Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var T1score = Game3T1Score.Text;
                var T1S = Int32.Parse(T1score);
                var T2score = Game3T2Score.Text;
                var T2S = Int32.Parse(T2score);

                if ((T1S == 21) && (T2S < 21) || (T2S == 21) && (T1S < 21))
                {
                    C3Info.Text = "";
                    scoreCollectC3T1();
                    scoreCollectC3T2();
                    Court3Details();
                    Court4Next();
                }
                else
                {
                    C3Info.Text = "Scores must be to 21 with no setting";
                }
            }
            catch
            {
                C3Info.Text = "A score must be entered";
            }
        }

        private void Game4Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var T1score = Game4T1Score.Text;
                var T1S = Int32.Parse(T1score);
                var T2score = Game4T2Score.Text;
                var T2S = Int32.Parse(T2score);

                if ((T1S == 21) && (T2S < 21) || (T2S == 21) && (T1S < 21))
                {
                    C4Info.Text = "";
                    scoreCollectC4T1();
                    scoreCollectC4T2();
                    Court4Details();
                    Court4Next();
                }
                else
                {
                    C4Info.Text = "Scores must be to 21 with no setting";
                }
            }
            catch
            {
                C4Info.Text = "A score must be entered";
            }
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new Knockouts(Team1Score, Team2Score, Team3Score, Team4Score, Team5Score, Team6Score, Team7Score, Team8Score, Team1PointsAgainst, Team2PointsAgainst, Team3PointsAgainst, Team4PointsAgainst, Team5PointsAgainst, Team6PointsAgainst, Team7PointsAgainst, Team8PointsAgainst, Team1Wins, Team2Wins, Team3Wins, Team4Wins, Team5Wins, Team6Wins, Team7Wins, Team8Wins, team1Players, team2Players, team3Players, team4Players, team5Players, team6Players, team7Players, team8Players); 
            newForm.Show();
            this.Close();
        }
    }
}
