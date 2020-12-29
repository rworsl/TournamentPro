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

        List<string> Game1;
        List<string> Game2;
        List<string> Game3;
        List<string> Game4;
        List<string> Game5;
        List<string> Game6;
        List<string> Game7;
        List<string> Game8;
        List<string> Game9;
        List<string> Game10;
        List<string> Game11;
        List<string> Game12;
        List<string> Game13;
        List<string> Game14;
        List<string> Game15;
        List<string> Game16;
        List<string> Game17;
        List<string> Game18;
        List<string> Game19;
        List<string> Game20;
        List<string> Game21;
        List<string> Game22;
        List<string> Game23;
        List<string> Game24;

        List<List<string>> GamesList;

        public GroupStage(List<string> t1, List<string> t2, List<string> t3, List<string> t4, List<string> t5, List<string> t6, List<string> t7, List<string> t8)
        {
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
            InitializeComponent();
        }

        private void assignGames1stHalf()
        {
            //Game 1 Players
            Game1.Add(team1Players[0]);
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
            G1P1.Text = Game1[0] + "\n" + Game1[1];
        }


        private void Game1Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
