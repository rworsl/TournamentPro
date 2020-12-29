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
        int Team1Score = 0;
        int Team2Score = 0;
        int Team3Score = 0;
        int Team4Score = 0;
        int Team5Score = 0;
        int Team6Score = 0;
        int Team7Score = 0;
        int Team8Score = 0;

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

        public GroupStage(List<string> t1, List<string> t2, List<string> t3, List<string> t4, List<string> t5, List<string> t6, List<string> t7, List<string> t8)
        {
            InitializeComponent();
            team1Players = t1;
            team2Players = t2;
            team3Players = t3;
            team4Players = t4;
            team5Players = t5;
            team6Players = t6;
            team7Players = t7;
            team8Players = t8;
            assignGames1stHalf();
            Court1Details();
        }

        private void assignGames1stHalf()
        {
            //Game 1 Players
            Game1.Add(team1Players[0].ToString());
            Game1.Add(team1Players[1]);
            Game1.Add(team4Players[0]);
            Game1.Add(team4Players[1]);
            //Game 2 Players
            Game2.Add(team3Players[0]);
            Game2.Add(team3Players[1]);
            Game2.Add(team2Players[0]);
            Game2.Add(team2Players[1]);
            //Game 3 Players
            Game3.Add(team1Players[1]);
            Game3.Add(team1Players[2]);
            Game3.Add(team3Players[1]);
            Game3.Add(team3Players[2]);
            //Game 4 Players
            Game4.Add(team2Players[1]);
            Game4.Add(team2Players[2]);
            Game4.Add(team4Players[1]);
            Game4.Add(team4Players[2]);
            //Game 5 Players
            Game5.Add(team1Players[0]);
            Game5.Add(team1Players[2]);
            Game5.Add(team2Players[0]);
            Game5.Add(team2Players[2]);
            //Game 6 Players
            Game6.Add(team3Players[0]);
            Game6.Add(team3Players[2]);
            Game6.Add(team4Players[0]);
            Game6.Add(team4Players[2]);
            //Game 7 Players
            Game7.Add(team1Players[0]);
            Game7.Add(team1Players[1]);
            Game7.Add(team3Players[0]);
            Game7.Add(team3Players[1]);
            //Game 8 Players
            Game8.Add(team2Players[0]);
            Game8.Add(team2Players[1]);
            Game8.Add(team4Players[0]);
            Game8.Add(team4Players[1]);
            //Game 9 Players
            Game9.Add(team1Players[1]);
            Game9.Add(team1Players[2]);
            Game9.Add(team4Players[1]);
            Game9.Add(team4Players[2]);
            //Game 10 Players
            Game10.Add(team2Players[1]);
            Game10.Add(team2Players[2]);
            Game10.Add(team3Players[1]);
            Game10.Add(team3Players[2]);
            //Game 11 Players
            Game11.Add(team1Players[0]);
            Game11.Add(team1Players[2]);
            Game11.Add(team2Players[0]);
            Game11.Add(team2Players[2]);
            //Game 12 Players
            Game12.Add(team4Players[0]);
            Game12.Add(team4Players[2]);
            Game12.Add(team3Players[0]);
            Game12.Add(team3Players[2]);

            GamesList.Add(Game1);
            GamesList.Add(Game2);
            GamesList.Add(Game3);
            GamesList.Add(Game4);
            GamesList.Add(Game5);
            GamesList.Add(Game6);
            GamesList.Add(Game7);
            GamesList.Add(Game8);
            GamesList.Add(Game9);
            GamesList.Add(Game10);
            GamesList.Add(Game11);
            GamesList.Add(Game12);
        }

        private void Court1Details()
        {
            string p1 = Game1[0].ToString() + "\n" + "+" + "\n" + Game1[1].ToString();
            G1P1.Text = p1;
            string p2 = Game1[2].ToString() + "\n" + "+" + "\n" + Game1[3].ToString();
            G1P1.Text = p2;
        }


        private void Game1Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
