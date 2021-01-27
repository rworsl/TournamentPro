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
        static List<int> Team1 = new List<int> { };
        static List<int> Team2 = new List<int> { };
        static List<int> Team3 = new List<int> { };
        static List<int> Team4 = new List<int> { };

        static List<int> Team5 = new List<int> { };
        static List<int> Team6 = new List<int> { };
        static List<int> Team7 = new List<int> { };
        static List<int> Team8 = new List<int> { };

        static int Team1For = 4;
        static int Team2For = 4;
        static int Team3For = 4;
        static int Team4For = 4;
        static int Team5For = 0;
        static int Team6For = 0;
        static int Team7For = 0;
        static int Team8For = 0;

        static int Team1PointsAgainst = 3;
        static int Team2PointsAgainst = 2;
        static int Team3PointsAgainst = 3;
        static int Team4PointsAgainst = 3;
        static int Team5PointsAgainst = 0;
        static int Team6PointsAgainst = 0;
        static int Team7PointsAgainst = 0;
        static int Team8PointsAgainst = 0;

        static int Team1Wins = 3;
        static int Team2Wins = 3;
        static int Team3Wins = 3;
        static int Team4Wins = 4;
        static int Team5Wins = 0;
        static int Team6Wins = 0;
        static int Team7Wins = 0;
        static int Team8Wins = 0;

        static int Team1Losses = 6;
        static int Team2Losses = 5;
        static int Team3Losses = 6;
        static int Team4Losses = 0;
        static int Team5Losses = 0;
        static int Team6Losses = 0;
        static int Team7Losses = 0;
        static int Team8Losses = 0;

        static List<int> pointsFor = new List<int> { };
        static List<int> pointsAgainst = new List<int> { };
        static List<int> gamesFor = new List<int> { };
        static List<int> gamesAgainst = new List<int> { };

        static string FirstHalfTopTeam = "";
        static string FirstHalfSecondTeam = "";

        public Knockouts(int T1Score, int T2Score, int T3Score, int T4Score, int T5Score, int T6Score, int T7Score, int T8Score, int T1PointsAgainst, int T2PointsAgainst, int T3PointsAgainst, int T4PointsAgainst, int T5PointsAgainst, int T6PointsAgainst, int T7PointsAgainst, int T8PointsAgainst, int T1Wins, int T2Wins, int T3Wins, int T4Wins, int T5Wins, int T6Wins, int T7Wins, int T8Wins)
        {
            //InitializeComponent();
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
            SortPoints();
            PointsFor();
            AssignGames();
        }

        private void AssignGames()
        {
            string K1T1Text = FirstHalfTopTeam;
            string K1T2Text = FirstHalfSecondTeam;
            K1T1.Text = K1T1Text;
            K1T2.Text = K1T2Text;
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
        public static string PointsFor()
        {

            List<List<int>> TeamsList = new List<List<int>> { };
            TeamsList.Add(Team1);
            TeamsList.Add(Team2);
            TeamsList.Add(Team3);
            TeamsList.Add(Team4);

            pointsFor.Sort();
            pointsFor.Reverse();
            //All Teams on different points gained ---------- DONE!!!
            if ((pointsFor[0] != pointsFor[1]) && (pointsFor[1] != pointsFor[2]) && (pointsFor[2] != pointsFor[3]))
            {
                //Allocate top team
                if (Team1[0] == pointsFor[0])
                {
                    FirstHalfTopTeam = "Team1";
                }
                else if (Team2[0] == pointsFor[0])
                {
                    FirstHalfTopTeam = "Team2";
                }
                else if (Team3[0] == pointsFor[0])
                {
                    FirstHalfTopTeam = "Team3";
                }
                else
                {
                    FirstHalfTopTeam = "Team4";
                }

                //Allocate second team
                if (Team1[0] == pointsFor[1])
                {
                    FirstHalfSecondTeam = "Team1";
                }
                else if (Team2[0] == pointsFor[1])
                {
                    FirstHalfSecondTeam = "Team2";
                }
                else if (Team3[0] == pointsFor[1])
                {
                    FirstHalfSecondTeam = "Team3";
                }
                else
                {
                    FirstHalfSecondTeam = "Team4";
                }
            }

            //Bottom 2 teams have the same points ---------- DONE!!!
            if ((pointsFor[0] != pointsFor[1]) && (pointsFor[1] != pointsFor[2]) && (pointsFor[2] == pointsFor[3]))
            {
                //Allocate top team
                if (Team1[0] == pointsFor[0])
                {
                    FirstHalfTopTeam = "Team1";
                }
                else if (Team2[0] == pointsFor[0])
                {
                    FirstHalfTopTeam = "Team2";
                }
                else if (Team3[0] == pointsFor[0])
                {
                    FirstHalfTopTeam = "Team3";
                }
                else
                {
                    FirstHalfTopTeam = "Team4";
                }

                //Allocate second team
                if (Team1[0] == pointsFor[1])
                {
                    FirstHalfSecondTeam = "Team1";
                }
                else if (Team2[0] == pointsFor[1])
                {
                    FirstHalfSecondTeam = "Team2";
                }
                else if (Team3[0] == pointsFor[1])
                {
                    FirstHalfSecondTeam = "Team3";
                }
                else
                {
                    FirstHalfSecondTeam = "Team4";
                }
            }

            //Top 2 teams have the same points ---------- DONE!!!
            if ((pointsFor[0] == pointsFor[1]) && (pointsFor[1] != pointsFor[2]))
            {
                var inputTeam1 = "";
                var inputTeam2 = "";

                //Allocate top team
                if (Team1[0] == pointsFor[0])
                {
                    inputTeam1 = "Team1";
                }
                else if (Team2[0] == pointsFor[0])
                {
                    inputTeam1 = "Team2";
                }
                else if (Team3[0] == pointsFor[0])
                {
                    inputTeam1 = "Team3";
                }
                else
                {
                    inputTeam1 = "Team4";
                }

                if (inputTeam1 == "Team1")
                {
                    //Allocate second team
                    if (Team2[0] == pointsFor[1])
                    {
                        inputTeam2 = "Team2";
                    }
                    else if (Team3[0] == pointsFor[1])
                    {
                        inputTeam2 = "Team3";
                    }
                    else
                    {
                        inputTeam2 = "Team4";
                    }
                }

                else if (inputTeam1 == "Team2")
                {
                    //Allocate second team
                    if (Team1[0] == pointsFor[1])
                    {
                        inputTeam2 = "Team1";
                    }
                    else if (Team3[0] == pointsFor[1])
                    {
                        inputTeam2 = "Team3";
                    }
                    else
                    {
                        inputTeam2 = "Team4";
                    }
                }

                else if (inputTeam1 == "Team3")
                {
                    //Allocate second team
                    if (Team1[0] == pointsFor[1])
                    {
                        inputTeam2 = "Team1";
                    }
                    else if (Team2[0] == pointsFor[1])
                    {
                        inputTeam2 = "Team2";
                    }
                    else
                    {
                        inputTeam2 = "Team4";
                    }
                }

                else
                {
                    //Allocate second team
                    if (Team1[0] == pointsFor[1])
                    {
                        inputTeam2 = "Team1";
                    }
                    else if (Team2[0] == pointsFor[1])
                    {
                        inputTeam2 = "Team2";
                    }
                    else
                    {
                        inputTeam2 = "Team3";
                    }
                }

                var results = LowestPointsAgainstFromTwo(inputTeam1, inputTeam2);

                FirstHalfTopTeam = results[0];
                FirstHalfSecondTeam = results[1];
            }

            //Middle 2 teams have the same points ---------- DONE!!!
            if ((pointsFor[0] != pointsFor[1]) && (pointsFor[1] == pointsFor[2]) && (pointsFor[1] != pointsFor[3]))
            {
                var inputTeam1 = "";
                var inputTeam2 = "";

                //Allocate top team
                if (Team1[0] == pointsFor[1])
                {
                    inputTeam1 = "Team1";
                }
                else if (Team2[0] == pointsFor[1])
                {
                    inputTeam1 = "Team2";
                }
                else if (Team3[0] == pointsFor[1])
                {
                    inputTeam1 = "Team3";
                }
                else
                {
                    inputTeam1 = "Team4";
                }

                if (inputTeam1 == "Team1")
                {
                    //Allocate second team
                    if (Team2[0] == pointsFor[2])
                    {
                        inputTeam2 = "Team2";
                    }
                    else if (Team3[0] == pointsFor[2])
                    {
                        inputTeam2 = "Team3";
                    }
                    else
                    {
                        inputTeam2 = "Team4";
                    }
                }

                else if (inputTeam1 == "Team2")
                {
                    //Allocate second team
                    if (Team1[0] == pointsFor[2])
                    {
                        inputTeam2 = "Team1";
                    }
                    else if (Team3[0] == pointsFor[2])
                    {
                        inputTeam2 = "Team3";
                    }
                    else
                    {
                        inputTeam2 = "Team4";
                    }
                }

                else if (inputTeam1 == "Team3")
                {
                    //Allocate second team
                    if (Team1[0] == pointsFor[2])
                    {
                        inputTeam2 = "Team1";
                    }
                    else if (Team2[0] == pointsFor[2])
                    {
                        inputTeam2 = "Team2";
                    }
                    else
                    {
                        inputTeam2 = "Team4";
                    }
                }

                else
                {
                    //Allocate second team
                    if (Team1[0] == pointsFor[2])
                    {
                        inputTeam2 = "Team1";
                    }
                    else if (Team2[0] == pointsFor[2])
                    {
                        inputTeam2 = "Team2";
                    }
                    else
                    {
                        inputTeam2 = "Team3";
                    }
                }

                var results = LowestPointsAgainstFromTwo(inputTeam1, inputTeam2);

                if (Team1For == pointsFor[0])
                {
                    FirstHalfTopTeam = "Team1";
                }
                else if (Team2For == pointsFor[0])
                {
                    FirstHalfTopTeam = "Team2";
                }
                else if (Team3For == pointsFor[0])
                {
                    FirstHalfTopTeam = "Team3";
                }
                else
                {
                    FirstHalfTopTeam = "Team4";
                }

                FirstHalfSecondTeam = results[0];

            }

            //Top 3 teams have the same points ---------- DONE!!!
            if ((pointsFor[0] == pointsFor[2]) && (pointsFor[1] != pointsFor[3]))
            {
                var inputTeam1 = "";
                var inputTeam2 = "";
                var inputTeam3 = "";

                //Allocate top team
                if (Team1[0] == pointsFor[0])
                {
                    inputTeam1 = "Team1";
                }
                else if (Team2[0] == pointsFor[0])
                {
                    inputTeam1 = "Team2";
                }
                else if (Team3[0] == pointsFor[0])
                {
                    inputTeam1 = "Team3";
                }
                else
                {
                    inputTeam1 = "Team4";
                }

                //Allocate second and third team
                if (inputTeam1 == "Team1")
                {
                    if (Team2[0] == pointsFor[3])
                    {
                        inputTeam2 = "Team3";
                        inputTeam3 = "Team4";
                    }
                    else if (Team3[0] == pointsFor[3])
                    {
                        inputTeam2 = "Team2";
                        inputTeam3 = "Team4";
                    }
                    else if (Team4[0] == pointsFor[3])
                    {
                        inputTeam2 = "Team2";
                        inputTeam3 = "Team3";
                    }
                }
                else if (inputTeam1 == "Team2")
                {
                    if (Team1[0] == pointsFor[3])
                    {
                        inputTeam2 = "Team3";
                        inputTeam3 = "Team4";
                    }
                    else if (Team3[0] == pointsFor[3])
                    {
                        inputTeam2 = "Team1";
                        inputTeam3 = "Team4";
                    }
                    else if (Team4[0] == pointsFor[3])
                    {
                        inputTeam2 = "Team1";
                        inputTeam3 = "Team3";
                    }
                }
                else if (inputTeam1 == "Team3")
                {
                    if (Team1[0] == pointsFor[3])
                    {
                        inputTeam2 = "Team2";
                        inputTeam3 = "Team4";
                    }
                    else if (Team2[0] == pointsFor[3])
                    {
                        inputTeam2 = "Team1";
                        inputTeam3 = "Team4";
                    }
                    else if (Team4[0] == pointsFor[3])
                    {
                        inputTeam2 = "Team1";
                        inputTeam3 = "Team2";
                    }
                }
                else if (inputTeam1 == "Team4")
                {
                    if (Team1[0] == pointsFor[3])
                    {
                        inputTeam2 = "Team2";
                        inputTeam3 = "Team3";
                    }
                    else if (Team2[0] == pointsFor[3])
                    {
                        inputTeam2 = "Team1";
                        inputTeam3 = "Team3";
                    }
                    else if (Team3[0] == pointsFor[3])
                    {
                        inputTeam2 = "Team1";
                        inputTeam3 = "Team2";
                    }
                }

                var results = LowestPointsAgainstFromThree(inputTeam1, inputTeam2, inputTeam3);

                FirstHalfTopTeam = results[0];
                FirstHalfSecondTeam = results[1];
            }

            //Bottom 3 teams have the same points ---------- DONE!!!
            if ((pointsFor[0] != pointsFor[1]) && (pointsFor[1] == pointsFor[3]))
            {
                var inputTeam1 = "";
                var inputTeam2 = "";
                var inputTeam3 = "";

                //Allocate top team
                if (Team1[0] == pointsFor[1])
                {
                    inputTeam1 = "Team1";
                }
                else if (Team2[0] == pointsFor[1])
                {
                    inputTeam1 = "Team2";
                }
                else if (Team3[0] == pointsFor[1])
                {
                    inputTeam1 = "Team3";
                }
                else
                {
                    inputTeam1 = "Team4";
                }

                //Allocate second and third team
                if (inputTeam1 == "Team1")
                {
                    if (Team2[0] == pointsFor[0])
                    {
                        inputTeam2 = "Team3";
                        inputTeam3 = "Team4";
                    }
                    else if (Team3[0] == pointsFor[0])
                    {
                        inputTeam2 = "Team2";
                        inputTeam3 = "Team4";
                    }
                    else if (Team4[0] == pointsFor[0])
                    {
                        inputTeam2 = "Team2";
                        inputTeam3 = "Team3";
                    }
                }
                else if (inputTeam1 == "Team2")
                {
                    if (Team1[0] == pointsFor[0])
                    {
                        inputTeam2 = "Team3";
                        inputTeam3 = "Team4";
                    }
                    else if (Team3[0] == pointsFor[0])
                    {
                        inputTeam2 = "Team1";
                        inputTeam3 = "Team4";
                    }
                    else if (Team4[0] == pointsFor[0])
                    {
                        inputTeam2 = "Team1";
                        inputTeam3 = "Team3";
                    }
                }
                else if (inputTeam1 == "Team3")
                {
                    if (Team1[0] == pointsFor[0])
                    {
                        inputTeam2 = "Team2";
                        inputTeam3 = "Team4";
                    }
                    else if (Team2[0] == pointsFor[0])
                    {
                        inputTeam2 = "Team1";
                        inputTeam3 = "Team4";
                    }
                    else if (Team4[0] == pointsFor[0])
                    {
                        inputTeam2 = "Team1";
                        inputTeam3 = "Team2";
                    }
                }
                else if (inputTeam1 == "Team4")
                {
                    if (Team1[0] == pointsFor[0])
                    {
                        inputTeam2 = "Team2";
                        inputTeam3 = "Team3";
                    }
                    else if (Team2[0] == pointsFor[0])
                    {
                        inputTeam2 = "Team1";
                        inputTeam3 = "Team3";
                    }
                    else if (Team3[0] == pointsFor[0])
                    {
                        inputTeam2 = "Team1";
                        inputTeam3 = "Team2";
                    }
                }


                var results = LowestPointsAgainstFromThree(inputTeam1, inputTeam2, inputTeam3);

                FirstHalfTopTeam = results[0];
                if (Team1[0] == pointsFor[0])
                {
                    FirstHalfTopTeam = "Team1";
                }
                else if (Team2[0] == pointsFor[0])
                {
                    FirstHalfTopTeam = "Team2";
                }
                else if (Team3[0] == pointsFor[0])
                {
                    FirstHalfTopTeam = "Team3";
                }
                else
                {
                    FirstHalfTopTeam = "Team4";
                }
                FirstHalfSecondTeam = results[0];
            }

            //All teams have the same points
            if ((pointsFor[0] == pointsFor[3]))
            {
                var inputTeam1 = "Team1";
                var inputTeam2 = "Team2";
                var inputTeam3 = "Team3";
                var inputTeam4 = "Team4";

                var results = LowestPointsAgainstFromFour(inputTeam1, inputTeam2, inputTeam3, inputTeam4);

                FirstHalfTopTeam = results[0];
                FirstHalfSecondTeam = results[1];
            }

            Console.WriteLine(FirstHalfTopTeam);
            Console.WriteLine(FirstHalfSecondTeam);
            return FirstHalfTopTeam;
        }
        private static void SortPoints()
        {
            Team1.Add(Team1For);
            Team1.Add(Team1PointsAgainst);
            Team1.Add(Team1Wins);
            Team1.Add(Team1Losses);

            Team2.Add(Team2For);
            Team2.Add(Team2PointsAgainst);
            Team2.Add(Team2Wins);
            Team2.Add(Team2Losses);

            Team3.Add(Team3For);
            Team3.Add(Team3PointsAgainst);
            Team3.Add(Team3Wins);
            Team3.Add(Team3Losses);

            Team4.Add(Team4For);
            Team4.Add(Team4PointsAgainst);
            Team4.Add(Team4Wins);
            Team4.Add(Team4Losses);

            pointsFor.Add(Team1For);
            pointsFor.Add(Team2For);
            pointsFor.Add(Team3For);
            pointsFor.Add(Team4For);

            pointsAgainst.Add(Team1For);
            pointsAgainst.Add(Team2For);
            pointsAgainst.Add(Team3For);
            pointsAgainst.Add(Team4For);

            gamesFor.Add(Team1Wins);
            gamesFor.Add(Team2Wins);
            gamesFor.Add(Team3Wins);
            gamesFor.Add(Team4Wins);

            gamesAgainst.Add(Team1Losses);
            gamesAgainst.Add(Team2Losses);
            gamesAgainst.Add(Team3Losses);
            gamesAgainst.Add(Team4Losses);
        }
        private static List<string> LowestPointsAgainstFromTwo(string teamOne, string teamTwo)
        {
            List<string> results = new List<string> { };
            string FirstTeam = "";
            string SecondTeam = "";
            int compare1 = 0;
            int compare2 = 0;

            //Allocate team to First team for points comparison
            if (teamOne == "Team1")
            {
                compare1 = Team1[1];
                FirstTeam = "Team1";
            }
            else if (teamOne == "Team2")
            {
                compare1 = Team2[1];
                FirstTeam = "Team2";
            }
            else if (teamOne == "Team3")
            {
                compare1 = Team3[1];
                FirstTeam = "Team3";
            }
            else
            {
                compare1 = Team4[1];
                FirstTeam = "Team4";
            }

            //Allocate team to Second team for points comparison
            if (teamTwo == "Team1")
            {
                compare2 = Team1[1];
                SecondTeam = "Team1";
            }
            else if (teamTwo == "Team2")
            {
                compare2 = Team2[1];
                SecondTeam = "Team2";
            }
            else if (teamTwo == "Team3")
            {
                compare2 = Team3[1];
                SecondTeam = "Team3";
            }
            else
            {
                compare2 = Team4[1];
                SecondTeam = "Team4";
            }

            //Do the actual comparison, results will either a draw or one team with lower points than the other
            if (compare1 < compare2)
            {
                results.Add(FirstTeam);
                results.Add(SecondTeam);
            }
            else if (compare1 > compare2)
            {
                results.Add(SecondTeam);
                results.Add(FirstTeam);
            }
            else
            {
                //Go to Games Won
                results = GamesWonFromTwo(FirstTeam, SecondTeam);
            }

            return results;
        }
        private static List<string> LowestPointsAgainstFromFour(string teamOne, string teamTwo, string teamThree, string teamFour)
        {
            List<string> results = new List<string> { };
            string FirstTeam = "";
            string SecondTeam = "";
            string ThirdTeam = "";
            string FourthTeam = "";
            int compare1 = Team1[1];
            int compare2 = Team2[1];
            int compare3 = Team3[1];
            int compare4 = Team4[1];
            List<int> scores = new List<int> { };

            scores.Add(compare1);
            scores.Add(compare2);
            scores.Add(compare3);
            scores.Add(compare4);
            scores.Sort();

            //Do the actual comparison, results will either a draw or one team with lower points than the other

            // top 3 are all different -------------- DONE!
            if ((scores[0] != scores[1]) && (scores[1] != scores[2]))
            {
                //assigns first team to results list -------------- DONE!
                if (scores[0] == compare1)
                {
                    results.Add("Team1");
                }
                else if (scores[0] == compare2)
                {
                    results.Add("Team2");
                }
                else if (scores[0] == compare3)
                {
                    results.Add("Team3");
                }
                else
                {
                    results.Add("Team4");
                }

                //assigns second team to results list -------------- DONE!
                if (scores[1] == compare1)
                {
                    results.Add("Team1");
                }
                else if (scores[1] == compare2)
                {
                    results.Add("Team2");
                }
                else if (scores[1] == compare3)
                {
                    results.Add("Team3");
                }
                else
                {
                    results.Add("Team4");
                }
            }
            // top 2 are the same -------------- DONE!
            else if ((scores[0] == scores[1]) && (scores[1] != scores[2]))
            {
                if (scores[0] == compare1)
                {
                    if (scores[1] == compare2)
                    {
                        GamesWonFromTwo(FirstTeam, SecondTeam);
                    }
                    else if (scores[1] == compare3)
                    {
                        GamesWonFromTwo(FirstTeam, ThirdTeam);
                    }
                    else if (scores[1] == compare4)
                    {
                        GamesWonFromTwo(FirstTeam, FourthTeam);
                    }
                }
                else if (scores[0] == compare2)
                {
                    if (scores[1] == compare1)
                    {
                        GamesWonFromTwo(SecondTeam, FirstTeam);
                    }
                    else if (scores[1] == compare3)
                    {
                        GamesWonFromTwo(SecondTeam, ThirdTeam);
                    }
                    else if (scores[1] == compare4)
                    {
                        GamesWonFromTwo(SecondTeam, FourthTeam);
                    }
                }
                else if (scores[0] == compare3)
                {
                    if (scores[1] == compare1)
                    {
                        GamesWonFromTwo(ThirdTeam, FirstTeam);
                    }
                    else if (scores[1] == compare2)
                    {
                        GamesWonFromTwo(ThirdTeam, SecondTeam);
                    }
                    else if (scores[1] == compare4)
                    {
                        GamesWonFromTwo(ThirdTeam, FourthTeam);
                    }
                }
                else if (scores[0] == compare4)
                {
                    if (scores[1] == compare1)
                    {
                        GamesWonFromTwo(FourthTeam, FirstTeam);
                    }
                    else if (scores[1] == compare2)
                    {
                        GamesWonFromTwo(FourthTeam, SecondTeam);
                    }
                    else if (scores[1] == compare3)
                    {
                        GamesWonFromTwo(FourthTeam, ThirdTeam);
                    }
                }
            }
            // middle 2 are the same -------------- DONE!
            else if ((scores[0] != scores[1]) && (scores[1] == scores[2]) && (scores[2] != scores[3]))
            {
                //Assigns results[0] from the top score
                if (scores[0] == compare1)
                {
                    results.Add("Team1");
                }
                else if (scores[0] == compare2)
                {
                    results.Add("Team2");
                }
                else if (scores[0] == compare3)
                {
                    results.Add("Team3");
                }
                else
                {
                    results.Add("Team4");
                }

                if (scores[1] == compare1)
                {
                    if (scores[2] == compare2)
                    {
                        GamesWonFromTwo(FirstTeam, SecondTeam);
                    }
                    else if (scores[2] == compare3)
                    {
                        GamesWonFromTwo(FirstTeam, ThirdTeam);
                    }
                    else if (scores[2] == compare4)
                    {
                        GamesWonFromTwo(FirstTeam, FourthTeam);
                    }
                }
                else if (scores[1] == compare2)
                {
                    if (scores[2] == compare1)
                    {
                        GamesWonFromTwo(SecondTeam, FirstTeam);
                    }
                    else if (scores[2] == compare3)
                    {
                        GamesWonFromTwo(SecondTeam, ThirdTeam);
                    }
                    else if (scores[2] == compare4)
                    {
                        GamesWonFromTwo(SecondTeam, FourthTeam);
                    }
                }
                else if (scores[1] == compare3)
                {
                    if (scores[2] == compare1)
                    {
                        GamesWonFromTwo(ThirdTeam, FirstTeam);
                    }
                    else if (scores[2] == compare2)
                    {
                        GamesWonFromTwo(ThirdTeam, SecondTeam);
                    }
                    else if (scores[2] == compare4)
                    {
                        GamesWonFromTwo(ThirdTeam, FourthTeam);
                    }
                }
                else if (scores[1] == compare4)
                {
                    if (scores[2] == compare1)
                    {
                        GamesWonFromTwo(FourthTeam, FirstTeam);
                    }
                    else if (scores[2] == compare2)
                    {
                        GamesWonFromTwo(FourthTeam, SecondTeam);
                    }
                    else if (scores[2] == compare3)
                    {
                        GamesWonFromTwo(FourthTeam, ThirdTeam);
                    }
                }

                //scores[0] needs assigning to the FristHalfTopTeam
                //scores[1] and [2] get pushed into games for
            }
            // top 3 are the same -------------- DONE!
            else if ((scores[0] == scores[2]) && (scores[2] != scores[3]))
            {
                // 1,2,3
                if ((scores[0] == compare1) && (scores[0] == compare2) && (scores[0] == compare3))
                {
                    teamOne = "Team1";
                    teamTwo = "Team2";
                    teamThree = "Team3";
                    var spare = GamesWonFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                    results.Add(spare[1]);
                }
                // 1,2,4
                else if ((scores[0] == compare1) && (scores[0] == compare2) && (scores[0] == compare4))
                {
                    teamOne = "Team1";
                    teamTwo = "Team2";
                    teamThree = "Team4";
                    var spare = GamesWonFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                    results.Add(spare[1]);
                }
                // 1,3,4
                else if ((scores[0] == compare1) && (scores[0] == compare3) && (scores[0] == compare4))
                {
                    teamOne = "Team1";
                    teamTwo = "Team3";
                    teamThree = "Team4";
                    var spare = GamesWonFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                    results.Add(spare[1]);
                }
                // 2,3,4
                else if ((scores[0] == compare2) && (scores[0] == compare3) && (scores[0] == compare4))
                {
                    teamOne = "Team2";
                    teamTwo = "Team3";
                    teamThree = "Team4";
                    var spare = GamesWonFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                    results.Add(spare[1]);
                }
            }
            // bottom 3 are the same
            else if ((scores[0] != scores[1]) && (scores[1] == scores[3]))
            {
                //scores[0] needs assigning to the FristHalfTopTeam
                //scores[1] and [2] and [3] get pushed into games for
                // 1,2,3
                if (scores[0] == compare1)
                {
                    results.Add("Team1");
                }
                else if (scores[0] == compare2)
                {
                    results.Add("Team2");
                }
                else if (scores[0] == compare3)
                {
                    results.Add("Team3");
                }
                else
                {
                    results.Add("Team4");
                }


                if ((scores[1] == compare1) && (scores[1] == compare2) && (scores[1] == compare3))
                {
                    teamOne = "Team1";
                    teamTwo = "Team2";
                    teamThree = "Team3";
                    var spare = GamesWonFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                }
                // 1,2,4
                else if ((scores[1] == compare1) && (scores[1] == compare2) && (scores[1] == compare4))
                {
                    teamOne = "Team1";
                    teamTwo = "Team2";
                    teamThree = "Team4";
                    var spare = GamesWonFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                }
                // 1,3,4
                else if ((scores[1] == compare1) && (scores[1] == compare3) && (scores[1] == compare4))
                {
                    teamOne = "Team1";
                    teamTwo = "Team3";
                    teamThree = "Team4";
                    var spare = GamesWonFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                }
                // 2,3,4
                else if ((scores[1] == compare2) && (scores[1] == compare3) && (scores[1] == compare4))
                {
                    teamOne = "Team2";
                    teamTwo = "Team3";
                    teamThree = "Team4";
                    var spare = GamesWonFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                }
            }
            // should handle if they are all the same
            else
            {
                var spare = GamesWonFromFour(teamOne, teamTwo, teamThree, teamFour);
                results.Add(spare[0]);
                results.Add(spare[1]);
            }

            return results;
        }
        private static List<string> GamesWonFromFour(string teamOne, string teamTwo, string teamThree, string teamFour)
        {
            List<string> results = new List<string> { };
            string FirstTeam = "";
            string SecondTeam = "";
            string ThirdTeam = "";
            string FourthTeam = "";
            int compare1 = Team1[2];
            int compare2 = Team2[2];
            int compare3 = Team3[2];
            int compare4 = Team4[2];
            List<int> scores = new List<int> { };

            scores.Add(compare1);
            scores.Add(compare2);
            scores.Add(compare3);
            scores.Add(compare4);
            scores.Sort();
            scores.Reverse();

            //Do the actual comparison, results will either a draw or one team with lower points than the other

            // top 3 are all different -------------- DONE!
            if ((scores[0] != scores[1]) && (scores[1] != scores[2]))
            {
                //assigns first team to results list -------------- DONE!
                if (scores[0] == compare1)
                {
                    results.Add("Team1");
                }
                else if (scores[0] == compare2)
                {
                    results.Add("Team2");
                }
                else if (scores[0] == compare3)
                {
                    results.Add("Team3");
                }
                else
                {
                    results.Add("Team4");
                }

                //assigns second team to results list -------------- DONE!
                if (scores[1] == compare1)
                {
                    results.Add("Team1");
                }
                else if (scores[1] == compare2)
                {
                    results.Add("Team2");
                }
                else if (scores[1] == compare3)
                {
                    results.Add("Team3");
                }
                else
                {
                    results.Add("Team4");
                }
            }
            // top 2 are the same -------------- DONE!
            else if ((scores[0] == scores[1]) && (scores[1] != scores[2]))
            {
                if (scores[0] == compare1)
                {
                    if (scores[1] == compare2)
                    {
                        GamesLostFromTwo(FirstTeam, SecondTeam);
                    }
                    else if (scores[1] == compare3)
                    {
                        GamesLostFromTwo(FirstTeam, ThirdTeam);
                    }
                    else if (scores[1] == compare4)
                    {
                        GamesLostFromTwo(FirstTeam, FourthTeam);
                    }
                }
                else if (scores[0] == compare2)
                {
                    if (scores[1] == compare1)
                    {
                        GamesLostFromTwo(SecondTeam, FirstTeam);
                    }
                    else if (scores[1] == compare3)
                    {
                        GamesLostFromTwo(SecondTeam, ThirdTeam);
                    }
                    else if (scores[1] == compare4)
                    {
                        GamesLostFromTwo(SecondTeam, FourthTeam);
                    }
                }
                else if (scores[0] == compare3)
                {
                    if (scores[1] == compare1)
                    {
                        GamesLostFromTwo(ThirdTeam, FirstTeam);
                    }
                    else if (scores[1] == compare2)
                    {
                        GamesLostFromTwo(ThirdTeam, SecondTeam);
                    }
                    else if (scores[1] == compare4)
                    {
                        GamesLostFromTwo(ThirdTeam, FourthTeam);
                    }
                }
                else if (scores[0] == compare4)
                {
                    if (scores[1] == compare1)
                    {
                        GamesLostFromTwo(FourthTeam, FirstTeam);
                    }
                    else if (scores[1] == compare2)
                    {
                        GamesLostFromTwo(FourthTeam, SecondTeam);
                    }
                    else if (scores[1] == compare3)
                    {
                        GamesLostFromTwo(FourthTeam, ThirdTeam);
                    }
                }
            }
            // middle 2 are the same -------------- DONE!
            else if ((scores[0] != scores[1]) && (scores[1] == scores[2]) && (scores[2] != scores[3]))
            {
                //Assigns results[0] from the top score
                if (scores[0] == compare1)
                {
                    results.Add("Team1");
                }
                else if (scores[0] == compare2)
                {
                    results.Add("Team2");
                }
                else if (scores[0] == compare3)
                {
                    results.Add("Team3");
                }
                else
                {
                    results.Add("Team4");
                }

                if (scores[1] == compare1)
                {
                    if (scores[2] == compare2)
                    {
                        GamesLostFromTwo(FirstTeam, SecondTeam);
                    }
                    else if (scores[2] == compare3)
                    {
                        GamesLostFromTwo(FirstTeam, ThirdTeam);
                    }
                    else if (scores[2] == compare4)
                    {
                        GamesLostFromTwo(FirstTeam, FourthTeam);
                    }
                }
                else if (scores[1] == compare2)
                {
                    if (scores[2] == compare1)
                    {
                        GamesLostFromTwo(SecondTeam, FirstTeam);
                    }
                    else if (scores[2] == compare3)
                    {
                        GamesLostFromTwo(SecondTeam, ThirdTeam);
                    }
                    else if (scores[2] == compare4)
                    {
                        GamesLostFromTwo(SecondTeam, FourthTeam);
                    }
                }
                else if (scores[1] == compare3)
                {
                    if (scores[2] == compare1)
                    {
                        GamesLostFromTwo(ThirdTeam, FirstTeam);
                    }
                    else if (scores[2] == compare2)
                    {
                        GamesLostFromTwo(ThirdTeam, SecondTeam);
                    }
                    else if (scores[2] == compare4)
                    {
                        GamesLostFromTwo(ThirdTeam, FourthTeam);
                    }
                }
                else if (scores[1] == compare4)
                {
                    if (scores[2] == compare1)
                    {
                        GamesLostFromTwo(FourthTeam, FirstTeam);
                    }
                    else if (scores[2] == compare2)
                    {
                        GamesLostFromTwo(FourthTeam, SecondTeam);
                    }
                    else if (scores[2] == compare3)
                    {
                        GamesLostFromTwo(FourthTeam, ThirdTeam);
                    }
                }

                //scores[0] needs assigning to the FristHalfTopTeam
                //scores[1] and [2] get pushed into games for
            }
            // top 3 are the same -------------- DONE!
            else if ((scores[0] == scores[2]) && (scores[2] != scores[3]))
            {
                // 1,2,3
                if ((scores[0] == compare1) && (scores[0] == compare2) && (scores[0] == compare3))
                {
                    teamOne = "Team1";
                    teamTwo = "Team2";
                    teamThree = "Team3";
                    var spare = GamesLostFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                    results.Add(spare[1]);
                }
                // 1,2,4
                else if ((scores[0] == compare1) && (scores[0] == compare2) && (scores[0] == compare4))
                {
                    teamOne = "Team1";
                    teamTwo = "Team2";
                    teamThree = "Team4";
                    var spare = GamesLostFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                    results.Add(spare[1]);
                }
                // 1,3,4
                else if ((scores[0] == compare1) && (scores[0] == compare3) && (scores[0] == compare4))
                {
                    teamOne = "Team1";
                    teamTwo = "Team3";
                    teamThree = "Team4";
                    var spare = GamesLostFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                    results.Add(spare[1]);
                }
                // 2,3,4
                else if ((scores[0] == compare2) && (scores[0] == compare3) && (scores[0] == compare4))
                {
                    teamOne = "Team2";
                    teamTwo = "Team3";
                    teamThree = "Team4";
                    var spare = GamesLostFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                    results.Add(spare[1]);
                }
            }
            // bottom 3 are the same
            else if ((scores[0] != scores[1]) && (scores[1] == scores[3]))
            {
                //scores[0] needs assigning to the FristHalfTopTeam
                //scores[1] and [2] and [3] get pushed into games for
                // 1,2,3
                if (scores[0] == compare1)
                {
                    results.Add("Team1");
                }
                else if (scores[0] == compare2)
                {
                    results.Add("Team2");
                }
                else if (scores[0] == compare3)
                {
                    results.Add("Team3");
                }
                else
                {
                    results.Add("Team4");
                }


                if ((scores[1] == compare1) && (scores[1] == compare2) && (scores[1] == compare3))
                {
                    teamOne = "Team1";
                    teamTwo = "Team2";
                    teamThree = "Team3";
                    var spare = GamesLostFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                }
                // 1,2,4
                else if ((scores[1] == compare1) && (scores[1] == compare2) && (scores[1] == compare4))
                {
                    teamOne = "Team1";
                    teamTwo = "Team2";
                    teamThree = "Team4";
                    var spare = GamesLostFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                }
                // 1,3,4
                else if ((scores[1] == compare1) && (scores[1] == compare3) && (scores[1] == compare4))
                {
                    teamOne = "Team1";
                    teamTwo = "Team3";
                    teamThree = "Team4";
                    var spare = GamesLostFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                }
                // 2,3,4
                else if ((scores[1] == compare2) && (scores[1] == compare3) && (scores[1] == compare4))
                {
                    teamOne = "Team2";
                    teamTwo = "Team3";
                    teamThree = "Team4";
                    var spare = GamesLostFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                }
            }
            // should handle if they are all the same
            else
            {
                var spare = GamesLostFromFour(teamOne, teamTwo, teamThree, teamFour);
                results.Add(spare[0]);
                results.Add(spare[1]);
            }

            return results;
        }
        private static List<string> GamesLostFromFour(string teamOne, string teamTwo, string teamThree, string teamFour)
        {
            List<string> results = new List<string> { };
            string FirstTeam = "";
            string SecondTeam = "";
            string ThirdTeam = "";
            string FourthTeam = "";
            int compare1 = Team1[3];
            int compare2 = Team2[3];
            int compare3 = Team3[3];
            int compare4 = Team4[3];
            List<int> scores = new List<int> { };

            scores.Add(compare1);
            scores.Add(compare2);
            scores.Add(compare3);
            scores.Add(compare4);
            scores.Sort();

            //Do the actual comparison, results will either a draw or one team with lower points than the other

            // top 3 are all different -------------- DONE!
            if ((scores[0] != scores[1]) && (scores[1] != scores[2]))
            {
                //assigns first team to results list -------------- DONE!
                if (scores[0] == compare1)
                {
                    results.Add("Team1");
                }
                else if (scores[0] == compare2)
                {
                    results.Add("Team2");
                }
                else if (scores[0] == compare3)
                {
                    results.Add("Team3");
                }
                else
                {
                    results.Add("Team4");
                }

                //assigns second team to results list -------------- DONE!
                if (scores[1] == compare1)
                {
                    results.Add("Team1");
                }
                else if (scores[1] == compare2)
                {
                    results.Add("Team2");
                }
                else if (scores[1] == compare3)
                {
                    results.Add("Team3");
                }
                else
                {
                    results.Add("Team4");
                }
            }
            // top 2 are the same -------------- DONE!
            else if ((scores[0] == scores[1]) && (scores[1] != scores[2]))
            {
                if (scores[0] == compare1)
                {
                    if (scores[1] == compare2)
                    {
                        pickRandomFromTwo(FirstTeam, SecondTeam);
                    }
                    else if (scores[1] == compare3)
                    {
                        pickRandomFromTwo(FirstTeam, ThirdTeam);
                    }
                    else if (scores[1] == compare4)
                    {
                        pickRandomFromTwo(FirstTeam, FourthTeam);
                    }
                }
                else if (scores[0] == compare2)
                {
                    if (scores[1] == compare1)
                    {
                        pickRandomFromTwo(SecondTeam, FirstTeam);
                    }
                    else if (scores[1] == compare3)
                    {
                        pickRandomFromTwo(SecondTeam, ThirdTeam);
                    }
                    else if (scores[1] == compare4)
                    {
                        pickRandomFromTwo(SecondTeam, FourthTeam);
                    }
                }
                else if (scores[0] == compare3)
                {
                    if (scores[1] == compare1)
                    {
                        pickRandomFromTwo(ThirdTeam, FirstTeam);
                    }
                    else if (scores[1] == compare2)
                    {
                        pickRandomFromTwo(ThirdTeam, SecondTeam);
                    }
                    else if (scores[1] == compare4)
                    {
                        pickRandomFromTwo(ThirdTeam, FourthTeam);
                    }
                }
                else if (scores[0] == compare4)
                {
                    if (scores[1] == compare1)
                    {
                        pickRandomFromTwo(FourthTeam, FirstTeam);
                    }
                    else if (scores[1] == compare2)
                    {
                        pickRandomFromTwo(FourthTeam, SecondTeam);
                    }
                    else if (scores[1] == compare3)
                    {
                        pickRandomFromTwo(FourthTeam, ThirdTeam);
                    }
                }
            }
            // middle 2 are the same -------------- DONE!
            else if ((scores[0] != scores[1]) && (scores[1] == scores[2]) && (scores[2] != scores[3]))
            {
                //Assigns results[0] from the top score
                if (scores[0] == compare1)
                {
                    results.Add("Team1");
                }
                else if (scores[0] == compare2)
                {
                    results.Add("Team2");
                }
                else if (scores[0] == compare3)
                {
                    results.Add("Team3");
                }
                else
                {
                    results.Add("Team4");
                }

                if (scores[1] == compare1)
                {
                    if (scores[2] == compare2)
                    {
                        pickRandomFromTwo(FirstTeam, SecondTeam);
                    }
                    else if (scores[2] == compare3)
                    {
                        pickRandomFromTwo(FirstTeam, ThirdTeam);
                    }
                    else if (scores[2] == compare4)
                    {
                        pickRandomFromTwo(FirstTeam, FourthTeam);
                    }
                }
                else if (scores[1] == compare2)
                {
                    if (scores[2] == compare1)
                    {
                        pickRandomFromTwo(SecondTeam, FirstTeam);
                    }
                    else if (scores[2] == compare3)
                    {
                        pickRandomFromTwo(SecondTeam, ThirdTeam);
                    }
                    else if (scores[2] == compare4)
                    {
                        pickRandomFromTwo(SecondTeam, FourthTeam);
                    }
                }
                else if (scores[1] == compare3)
                {
                    if (scores[2] == compare1)
                    {
                        pickRandomFromTwo(ThirdTeam, FirstTeam);
                    }
                    else if (scores[2] == compare2)
                    {
                        pickRandomFromTwo(ThirdTeam, SecondTeam);
                    }
                    else if (scores[2] == compare4)
                    {
                        pickRandomFromTwo(ThirdTeam, FourthTeam);
                    }
                }
                else if (scores[1] == compare4)
                {
                    if (scores[2] == compare1)
                    {
                        pickRandomFromTwo(FourthTeam, FirstTeam);
                    }
                    else if (scores[2] == compare2)
                    {
                        pickRandomFromTwo(FourthTeam, SecondTeam);
                    }
                    else if (scores[2] == compare3)
                    {
                        pickRandomFromTwo(FourthTeam, ThirdTeam);
                    }
                }

                //scores[0] needs assigning to the FristHalfTopTeam
                //scores[1] and [2] get pushed into games for
            }
            // top 3 are the same -------------- DONE!
            else if ((scores[0] == scores[2]) && (scores[2] != scores[3]))
            {
                // 1,2,3
                if ((scores[0] == compare1) && (scores[0] == compare2) && (scores[0] == compare3))
                {
                    teamOne = "Team1";
                    teamTwo = "Team2";
                    teamThree = "Team3";
                    var spare = pickRandomFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                    results.Add(spare[1]);
                }
                // 1,2,4
                else if ((scores[0] == compare1) && (scores[0] == compare2) && (scores[0] == compare4))
                {
                    teamOne = "Team1";
                    teamTwo = "Team2";
                    teamThree = "Team4";
                    var spare = pickRandomFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                    results.Add(spare[1]);
                }
                // 1,3,4
                else if ((scores[0] == compare1) && (scores[0] == compare3) && (scores[0] == compare4))
                {
                    teamOne = "Team1";
                    teamTwo = "Team3";
                    teamThree = "Team4";
                    var spare = pickRandomFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                    results.Add(spare[1]);
                }
                // 2,3,4
                else if ((scores[0] == compare2) && (scores[0] == compare3) && (scores[0] == compare4))
                {
                    teamOne = "Team2";
                    teamTwo = "Team3";
                    teamThree = "Team4";
                    var spare = pickRandomFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                    results.Add(spare[1]);
                }
            }
            // bottom 3 are the same
            else if ((scores[0] != scores[1]) && (scores[1] == scores[3]))
            {
                //scores[0] needs assigning to the FristHalfTopTeam
                //scores[1] and [2] and [3] get pushed into games for
                // 1,2,3
                if (scores[0] == compare1)
                {
                    results.Add("Team1");
                }
                else if (scores[0] == compare2)
                {
                    results.Add("Team2");
                }
                else if (scores[0] == compare3)
                {
                    results.Add("Team3");
                }
                else
                {
                    results.Add("Team4");
                }


                if ((scores[1] == compare1) && (scores[1] == compare2) && (scores[1] == compare3))
                {
                    teamOne = "Team1";
                    teamTwo = "Team2";
                    teamThree = "Team3";
                    var spare = pickRandomFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                }
                // 1,2,4
                else if ((scores[1] == compare1) && (scores[1] == compare2) && (scores[1] == compare4))
                {
                    teamOne = "Team1";
                    teamTwo = "Team2";
                    teamThree = "Team4";
                    var spare = pickRandomFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                }
                // 1,3,4
                else if ((scores[1] == compare1) && (scores[1] == compare3) && (scores[1] == compare4))
                {
                    teamOne = "Team1";
                    teamTwo = "Team3";
                    teamThree = "Team4";
                    var spare = pickRandomFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                }
                // 2,3,4
                else if ((scores[1] == compare2) && (scores[1] == compare3) && (scores[1] == compare4))
                {
                    teamOne = "Team2";
                    teamTwo = "Team3";
                    teamThree = "Team4";
                    var spare = pickRandomFromThree(teamOne, teamTwo, teamThree);
                    results.Add(spare[0]);
                }
            }
            // should handle if they are all the same
            else
            {
                var spare = pickRandomFromFour(teamOne, teamTwo, teamThree, teamFour);
                results.Add(spare[0]);
                results.Add(spare[1]);
            }

            return results;
        }
        private static List<string> LowestPointsAgainstFromThree(string teamOne, string teamTwo, string teamThree)
        {
            List<string> results = new List<string> { };
            string FirstTeam = "";
            string SecondTeam = "";
            string ThirdTeam = "";
            int compare1 = 0;
            int compare2 = 0;
            int compare3 = 0;

            //Allocate team to First team for points comparison
            if (teamOne == "Team1")
            {
                compare1 = Team1[1];
                FirstTeam = "Team1";
            }
            else if (teamOne == "Team2")
            {
                compare1 = Team2[1];
                FirstTeam = "Team2";
            }
            else if (teamOne == "Team3")
            {
                compare1 = Team3[1];
                FirstTeam = "Team3";
            }
            else
            {
                compare1 = Team4[1];
                FirstTeam = "Team4";
            }

            //Allocate team to Second team for points comparison
            if (teamTwo == "Team1")
            {
                compare2 = Team1[1];
                SecondTeam = "Team1";
            }
            else if (teamTwo == "Team2")
            {
                compare2 = Team2[1];
                SecondTeam = "Team2";
            }
            else if (teamTwo == "Team3")
            {
                compare2 = Team3[1];
                SecondTeam = "Team3";
            }
            else
            {
                compare2 = Team4[1];
                SecondTeam = "Team4";
            }

            //Allocate team to Third team for points comparison
            if (teamThree == "Team1")
            {
                compare3 = Team1[1];
                ThirdTeam = "Team1";
            }
            else if (teamThree == "Team2")
            {
                compare3 = Team2[1];
                ThirdTeam = "Team2";
            }
            else if (teamThree == "Team3")
            {
                compare3 = Team3[1];
                ThirdTeam = "Team3";
            }
            else
            {
                compare3 = Team4[1];
                ThirdTeam = "Team4";
            }

            //Do the actual comparison, results will either a draw or one team with lower points than the other
            // 1,2,3
            if ((compare1 < compare2) && (compare2 < compare3))
            {
                results.Add(FirstTeam);
                results.Add(SecondTeam);
                results.Add(ThirdTeam);
            }
            // 1,3,2
            else if ((compare1 < compare2) && (compare2 > compare3) && (compare1 < compare3))
            {
                results.Add(FirstTeam);
                results.Add(ThirdTeam);
                results.Add(SecondTeam);
            }
            // 2,1,3
            else if ((compare1 > compare2) && (compare2 < compare3) && (compare1 < compare3))
            {
                results.Add(SecondTeam);
                results.Add(FirstTeam);
                results.Add(ThirdTeam);

            }
            // 2,3,1
            else if ((compare1 > compare2) && (compare2 < compare3) && (compare1 > compare3))
            {
                results.Add(SecondTeam);
                results.Add(ThirdTeam);
                results.Add(FirstTeam);
            }
            // 3,2,1
            else if ((compare1 > compare2) && (compare2 > compare3) && (compare1 > compare3))
            {
                results.Add(SecondTeam);
                results.Add(FirstTeam);
                results.Add(ThirdTeam);

            }
            //handles 3,1,2
            else if ((compare1 < compare2) && (compare2 > compare3) && (compare1 > compare3))
            {
                results.Add(SecondTeam);
                results.Add(FirstTeam);
                results.Add(ThirdTeam);

            }
            //handles draw with top 2 [1=2,3]
            else if ((compare1 == compare2) && (compare2 < compare3))
            {
                results = GamesWonFromTwo(FirstTeam, SecondTeam);
            }
            //handles draw with top 2 [1=3,2]
            else if ((compare1 == compare3) && (compare2 > compare3))
            {
                results = GamesWonFromTwo(FirstTeam, ThirdTeam);
            }
            //handles draw with top 2 [2=3,1]
            else if ((compare2 == compare3) && (compare2 < compare1))
            {
                results = GamesWonFromTwo(SecondTeam, ThirdTeam);
            }
            //handles draw with bottom 2 [3, 1=2]
            else if ((compare1 == compare2) && (compare2 > compare3))
            {
                var deets = GamesWonFromTwo(FirstTeam, SecondTeam);
                results.Add(ThirdTeam);
                results.Add(deets[0]);
            }
            //handles draw with bottom 2 [2, 1=3]
            else if ((compare1 == compare3) && (compare2 < compare3))
            {
                var deets = GamesWonFromTwo(FirstTeam, ThirdTeam);
                results.Add(SecondTeam);
                results.Add(deets[0]);
            }
            //handles draw with bottom 2 [1, 2=3]
            else if ((compare2 == compare3) && (compare2 > compare1))
            {
                var deets = GamesWonFromTwo(SecondTeam, ThirdTeam);
                results.Add(FirstTeam);
                results.Add(deets[0]);
            }
            //handles draw with all three
            else
            {
                //Go to games won from three
                results = GamesWonFromThree(FirstTeam, SecondTeam, ThirdTeam);
            }

            return results;
        }
        private static List<string> GamesWonFromThree(string teamOne, string teamTwo, string teamThree)
        {
            List<string> results = new List<string> { };
            string FirstTeam = "";
            string SecondTeam = "";
            string ThirdTeam = "";
            int compare1 = 0;
            int compare2 = 0;
            int compare3 = 0;

            //Allocate team to First team for points comparison
            if (teamOne == "Team1")
            {
                compare1 = Team1[2];
                FirstTeam = "Team1";
            }
            else if (teamOne == "Team2")
            {
                compare1 = Team2[2];
                FirstTeam = "Team2";
            }
            else if (teamOne == "Team3")
            {
                compare1 = Team3[2];
                FirstTeam = "Team3";
            }
            else
            {
                compare1 = Team4[2];
                FirstTeam = "Team4";
            }

            //Allocate team to Second team for points comparison
            if (teamTwo == "Team1")
            {
                compare2 = Team1[2];
                SecondTeam = "Team1";
            }
            else if (teamTwo == "Team2")
            {
                compare2 = Team2[2];
                SecondTeam = "Team2";
            }
            else if (teamTwo == "Team3")
            {
                compare2 = Team3[2];
                SecondTeam = "Team3";
            }
            else
            {
                compare2 = Team4[2];
                SecondTeam = "Team4";
            }

            //Allocate team to Third team for points comparison
            if (teamThree == "Team1")
            {
                compare3 = Team1[2];
                ThirdTeam = "Team1";
            }
            else if (teamThree == "Team2")
            {
                compare3 = Team2[2];
                ThirdTeam = "Team2";
            }
            else if (teamThree == "Team3")
            {
                compare3 = Team3[2];
                ThirdTeam = "Team3";
            }
            else
            {
                compare3 = Team4[2];
                ThirdTeam = "Team4";
            }

            //Do the actual comparison, results will either a draw or one team with lower points than the other
            // 1,2,3
            if ((compare1 < compare2) && (compare2 < compare3))
            {
                results.Add(FirstTeam);
                results.Add(SecondTeam);
                results.Add(ThirdTeam);
            }
            // 1,3,2
            else if ((compare1 < compare2) && (compare2 > compare3) && (compare1 < compare3))
            {
                results.Add(FirstTeam);
                results.Add(ThirdTeam);
                results.Add(SecondTeam);
            }
            // 2,1,3
            else if ((compare1 > compare2) && (compare2 < compare3) && (compare1 < compare3))
            {
                results.Add(SecondTeam);
                results.Add(FirstTeam);
                results.Add(ThirdTeam);

            }
            // 2,3,1
            else if ((compare1 > compare2) && (compare2 < compare3) && (compare1 > compare3))
            {
                results.Add(SecondTeam);
                results.Add(ThirdTeam);
                results.Add(FirstTeam);
            }
            // 3,2,1
            else if ((compare1 > compare2) && (compare2 > compare3) && (compare1 > compare3))
            {
                results.Add(SecondTeam);
                results.Add(FirstTeam);
                results.Add(ThirdTeam);

            }
            //handles 3,1,2
            else if ((compare1 < compare2) && (compare2 > compare3) && (compare1 > compare3))
            {
                results.Add(SecondTeam);
                results.Add(FirstTeam);
                results.Add(ThirdTeam);

            }
            //handles draw with top 2 [1=2,3]
            else if ((compare1 == compare2) && (compare2 < compare3))
            {
                results = GamesLostFromTwo(FirstTeam, SecondTeam);
            }
            //handles draw with top 2 [1=3,2]
            else if ((compare1 == compare3) && (compare2 > compare3))
            {
                results.Add(SecondTeam);
                var blah = GamesLostFromTwo(FirstTeam, ThirdTeam);
                results.Add(blah[0]);
            }
            //handles draw with top 2 [2=3,1]
            else if ((compare2 == compare3) && (compare2 < compare1))
            {
                results.Add(SecondTeam);
                var blah = GamesLostFromTwo(SecondTeam, ThirdTeam);
                results.Add(blah[0]);
            }
            //handles draw with bottom 2 [3, 1=2]
            else if ((compare1 == compare2) && (compare2 > compare3))
            {
                var deets = GamesLostFromTwo(FirstTeam, SecondTeam);
                results.Add(ThirdTeam);
                results.Add(deets[0]);
            }
            //handles draw with bottom 2 [2, 1=3]
            else if ((compare1 == compare3) && (compare2 < compare3))
            {
                var deets = GamesLostFromTwo(FirstTeam, ThirdTeam);
                results.Add(SecondTeam);
                results.Add(deets[0]);
            }
            //handles draw with bottom 2 [1, 2=3]
            else if ((compare2 == compare3) && (compare2 > compare1))
            {
                var deets = GamesLostFromTwo(SecondTeam, ThirdTeam);
                results.Add(FirstTeam);
                results.Add(deets[0]);
            }
            //handles draw with all three
            else
            {
                //Go to games won from three
                results = GamesLostFromThree(FirstTeam, SecondTeam, ThirdTeam);
            }

            return results;
        }
        private static List<string> GamesLostFromThree(string teamOne, string teamTwo, string teamThree)
        {
            List<string> results = new List<string> { };
            string FirstTeam = "";
            string SecondTeam = "";
            string ThirdTeam = "";
            int compare1 = 0;
            int compare2 = 0;
            int compare3 = 0;

            //Allocate team to First team for points comparison
            if (teamOne == "Team1")
            {
                compare1 = Team1[3];
                FirstTeam = "Team1";
            }
            else if (teamOne == "Team2")
            {
                compare1 = Team2[3];
                FirstTeam = "Team2";
            }
            else if (teamOne == "Team3")
            {
                compare1 = Team3[3];
                FirstTeam = "Team3";
            }
            else
            {
                compare1 = Team4[3];
                FirstTeam = "Team4";
            }

            //Allocate team to Second team for points comparison
            if (teamTwo == "Team1")
            {
                compare2 = Team1[3];
                SecondTeam = "Team1";
            }
            else if (teamTwo == "Team2")
            {
                compare2 = Team2[3];
                SecondTeam = "Team2";
            }
            else if (teamTwo == "Team3")
            {
                compare2 = Team3[3];
                SecondTeam = "Team3";
            }
            else
            {
                compare2 = Team4[3];
                SecondTeam = "Team4";
            }

            //Allocate team to Third team for points comparison
            if (teamThree == "Team1")
            {
                compare3 = Team1[3];
                ThirdTeam = "Team1";
            }
            else if (teamThree == "Team2")
            {
                compare3 = Team2[3];
                ThirdTeam = "Team2";
            }
            else if (teamThree == "Team3")
            {
                compare3 = Team3[3];
                ThirdTeam = "Team3";
            }
            else
            {
                compare3 = Team4[3];
                ThirdTeam = "Team4";
            }

            //Do the actual comparison, results will either a draw or one team with lower points than the other
            // 1,2,3
            if ((compare1 < compare2) && (compare2 < compare3))
            {
                results.Add(FirstTeam);
                results.Add(SecondTeam);
                results.Add(ThirdTeam);
            }
            // 1,3,2
            else if ((compare1 < compare2) && (compare2 > compare3) && (compare1 < compare3))
            {
                results.Add(FirstTeam);
                results.Add(ThirdTeam);
                results.Add(SecondTeam);
            }
            // 2,1,3
            else if ((compare1 > compare2) && (compare2 < compare3) && (compare1 < compare3))
            {
                results.Add(SecondTeam);
                results.Add(FirstTeam);
                results.Add(ThirdTeam);

            }
            // 2,3,1
            else if ((compare1 > compare2) && (compare2 < compare3) && (compare1 > compare3))
            {
                results.Add(SecondTeam);
                results.Add(ThirdTeam);
                results.Add(FirstTeam);
            }
            // 3,2,1
            else if ((compare1 > compare2) && (compare2 > compare3) && (compare1 > compare3))
            {
                results.Add(SecondTeam);
                results.Add(FirstTeam);
                results.Add(ThirdTeam);

            }
            //handles 3,1,2
            else if ((compare1 < compare2) && (compare2 > compare3) && (compare1 > compare3))
            {
                results.Add(SecondTeam);
                results.Add(FirstTeam);
                results.Add(ThirdTeam);

            }
            //handles draw with top 2 [1=2,3]
            else if ((compare1 == compare2) && (compare2 < compare3))
            {
                results = pickRandomFromTwo(FirstTeam, SecondTeam);
            }
            //handles draw with top 2 [1=3,2]
            else if ((compare1 == compare3) && (compare2 > compare3))
            {
                results = pickRandomFromTwo(FirstTeam, ThirdTeam);
            }
            //handles draw with top 2 [2=3,1]
            else if ((compare2 == compare3) && (compare2 < compare1))
            {
                results = pickRandomFromTwo(SecondTeam, ThirdTeam);
            }
            //handles draw with bottom 2 [3, 1=2]
            else if ((compare1 == compare2) && (compare2 > compare3))
            {
                var deets = pickRandomFromTwo(FirstTeam, SecondTeam);
                results.Add(ThirdTeam);
                results.Add(deets[0]);
            }
            //handles draw with bottom 2 [2, 1=3]
            else if ((compare1 == compare3) && (compare2 < compare3))
            {
                var deets = pickRandomFromTwo(FirstTeam, ThirdTeam);
                results.Add(SecondTeam);
                results.Add(deets[0]);
            }
            //handles draw with bottom 2 [1, 2=3]
            else if ((compare2 == compare3) && (compare2 > compare1))
            {
                var deets = pickRandomFromTwo(SecondTeam, ThirdTeam);
                results.Add(FirstTeam);
                results.Add(deets[0]);
            }
            //handles draw with all three
            else
            {
                //Go to games won from three
                results = pickRandomFromThree(FirstTeam, SecondTeam, ThirdTeam);
            }

            return results;
        }
        private static List<string> GamesWonFromTwo(string teamOne, string teamTwo)
        {
            List<string> results = new List<string> { };
            string FirstTeam = "";
            string SecondTeam = "";
            int compare1 = 0;
            int compare2 = 0;

            //Allocate team to First team for points comparison
            if (teamOne == "Team1")
            {
                compare1 = Team1[2];
                FirstTeam = "Team1";
            }
            else if (teamOne == "Team2")
            {
                compare1 = Team2[2];
                FirstTeam = "Team2";
            }
            else if (teamOne == "Team3")
            {
                compare1 = Team3[2];
                FirstTeam = "Team3";
            }
            else
            {
                compare1 = Team4[2];
                FirstTeam = "Team4";
            }

            //Allocate team to Second team for points comparison
            if (teamTwo == "Team1")
            {
                compare2 = Team1[2];
                SecondTeam = "Team1";
            }
            else if (teamTwo == "Team2")
            {
                compare2 = Team2[2];
                SecondTeam = "Team2";
            }
            else if (teamTwo == "Team3")
            {
                compare2 = Team3[2];
                SecondTeam = "Team3";
            }
            else
            {
                compare2 = Team4[2];
                SecondTeam = "Team4";
            }

            //Do the actual comparison, results will either a draw or one team with lower points than the other
            if (compare1 > compare2)
            {
                results.Add(FirstTeam);
                results.Add(SecondTeam);
            }
            else if (compare1 < compare2)
            {
                results.Add(SecondTeam);
                results.Add(FirstTeam);
            }
            else
            {
                //Go to Games Lost
                results = GamesLostFromTwo(FirstTeam, SecondTeam);
            }

            return results;
        }
        private static List<string> GamesLostFromTwo(string teamOne, string teamTwo)
        {
            List<string> results = new List<string> { };
            string FirstTeam = "";
            string SecondTeam = "";
            int compare1 = 0;
            int compare2 = 0;

            //Allocate team to First team for points comparison
            if (teamOne == "Team1")
            {
                compare1 = Team1[3];
                FirstTeam = "Team1";
            }
            else if (teamOne == "Team2")
            {
                compare1 = Team2[3];
                FirstTeam = "Team2";
            }
            else if (teamOne == "Team3")
            {
                compare1 = Team3[3];
                FirstTeam = "Team3";
            }
            else
            {
                compare1 = Team4[3];
                FirstTeam = "Team4";
            }

            //Allocate team to Second team for points comparison
            if (teamTwo == "Team1")
            {
                compare2 = Team1[3];
                SecondTeam = "Team1";
            }
            else if (teamTwo == "Team2")
            {
                compare2 = Team2[3];
                SecondTeam = "Team2";
            }
            else if (teamTwo == "Team3")
            {
                compare2 = Team3[3];
                SecondTeam = "Team3";
            }
            else
            {
                compare2 = Team4[3];
                SecondTeam = "Team4";
            }

            //Do the actual comparison, results will either a draw or one team with lower points than the other
            if (compare1 < compare2)
            {
                results.Add(FirstTeam);
                results.Add(SecondTeam);
            }
            else if (compare1 > compare2)
            {
                results.Add(SecondTeam);
                results.Add(FirstTeam);
            }
            else
            {
                //Go to Random From Two
                results = pickRandomFromTwo(FirstTeam, SecondTeam);
            }

            return results;
        }
        private static List<string> pickRandomFromTwo(string teamOne, string teamTwo)
        {
            List<string> RawTeams = new List<string> { };
            List<string> FinalTeams = new List<string> { };
            RawTeams.Add(teamOne);
            RawTeams.Add(teamTwo);
            Random rnd = new Random();
            int selected = rnd.Next(0, 2);
            FinalTeams.Add(RawTeams[selected]);
            RawTeams.RemoveAt(selected);
            FinalTeams.Add(RawTeams[0]);
            return FinalTeams;
        }
        private static List<string> pickRandomFromThree(string teamOne, string teamTwo, string teamThree)
        {
            List<string> RawTeams = new List<string> { };
            List<string> FinalTeams = new List<string> { };
            RawTeams.Add(teamOne);
            RawTeams.Add(teamTwo);
            RawTeams.Add(teamThree);
            Random rnd = new Random();
            int selected = rnd.Next(0, 3);
            FinalTeams.Add(RawTeams[selected]);
            RawTeams.RemoveAt(selected);
            int selected2 = rnd.Next(0, 2);
            FinalTeams.Add(RawTeams[selected2]);
            return FinalTeams;
        }
        private static List<string> pickRandomFromFour(string teamOne, string teamTwo, string teamThree, string teamFour)
        {
            List<string> RawTeams = new List<string> { };
            List<string> FinalTeams = new List<string> { };
            RawTeams.Add(teamOne);
            RawTeams.Add(teamTwo);
            RawTeams.Add(teamThree);
            RawTeams.Add(teamFour);
            Random rnd = new Random();
            int selected = rnd.Next(0, 4);
            FinalTeams.Add(RawTeams[selected]);
            RawTeams.RemoveAt(selected);
            int selected2 = rnd.Next(0, 3);
            FinalTeams.Add(RawTeams[selected2]);
            return FinalTeams;
        }
    }
}