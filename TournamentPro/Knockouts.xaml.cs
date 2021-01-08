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
    /// Interaction logic for Knockouts.xaml
    /// </summary>
    public partial class Knockouts : Window
    {
        int Team1For = 0;
        int Team2For = 0;
        int Team3For = 0;
        int Team4For = 0;
        int Team5For = 0;
        int Team6For = 0;
        int Team7For = 0;
        int Team8For = 0;

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

        int Team1Losses = 0;
        int Team2Losses = 0;
        int Team3Losses = 0;
        int Team4Losses = 0;
        int Team5Losses = 0;
        int Team6Losses = 0;
        int Team7Losses = 0;
        int Team8Losses = 0;

        List<(string,int)> PointsFor = new List<(string,int)> { };
        List<(string, int)> PointsAgainst = new List<(string, int)> { };
        List<(string, int)> Wins = new List<(string, int)> { };
        List<(string, int)> Losses = new List<(string, int)> { };

        string FirstHalfTopTeam = "";
        string FirstHalfSecondTeam = "";

        public Knockouts(int T1Score = 0, int T2Score = 0, int T3Score = 0, int T4Score = 0, int T5Score = 0, int T6Score = 0, int T7Score = 0, int T8Score = 0, int T1PointsAgainst = 0, int T2PointsAgainst = 0, int T3PointsAgainst = 0, int T4PointsAgainst = 0, int T5PointsAgainst = 0, int T6PointsAgainst = 0, int T7PointsAgainst = 0, int T8PointsAgainst = 0, int T1Wins = 0, int T2Wins = 0, int T3Wins = 0, int T4Wins = 0, int T5Wins = 0, int T6Wins = 0, int T7Wins = 0, int T8Wins = 0)
        {
            InitializeComponent();
            Team1For = T1Score;
            Team2For = T2Score;
            Team3For = T3Score;
            Team4For = T4Score;
            Team5For = T5Score;
            Team6For = T6Score;
            Team7For = T7Score;
            Team8For = T8Score;

            Team1PointsAgainst = T1PointsAgainst;
            Team2PointsAgainst = T2PointsAgainst;
            Team3PointsAgainst = T3PointsAgainst;
            Team4PointsAgainst = T4PointsAgainst;
            Team5PointsAgainst = T5PointsAgainst;
            Team6PointsAgainst = T6PointsAgainst;
            Team7PointsAgainst = T7PointsAgainst;
            Team8PointsAgainst = T8PointsAgainst;

            Team1Wins = T1Wins;
            Team2Wins = T2Wins;
            Team3Wins = T3Wins;
            Team4Wins = T4Wins;
            Team5Wins = T5Wins;
            Team6Wins = T6Wins;
            Team7Wins = T7Wins;
            Team8Wins = T8Wins;

            TeamLosses();
        }

        private void TeamLosses()
        {
            Team1Losses = 8 - Team1Wins;
            Team2Losses = 8 - Team2Wins;
            Team3Losses = 8 - Team3Wins;
            Team4Losses = 8 - Team4Wins;
            Team5Losses = 8 - Team5Wins;
            Team6Losses = 8 - Team6Wins;
            Team7Losses = 8 - Team7Wins;
            Team8Losses = 8 - Team8Wins;
        }

        private void FirstHalfToSet()
        {
            if ((Team1For > Team2For) && (Team1For > Team3For) && (Team1For > Team4For))
            {
                FirstHalfTopTeam = "Team1";
            }
            else if ((Team2For > Team1For) && (Team2For > Team3For) && (Team2For > Team4For))
            {
                FirstHalfTopTeam = "Team2";
            }
            else if ((Team3For > Team1For) && (Team3For > Team2For) && (Team3For > Team4For))
            {
                FirstHalfTopTeam = "Team3";
            }
            else if ((Team4For > Team1For) && (Team4For > Team2For) && (Team4For > Team3For))
            {
                FirstHalfTopTeam = "Team4";
            }
            else
            {
                //Work out points against
            }
        }

    }
}
