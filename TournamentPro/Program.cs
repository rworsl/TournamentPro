using System;
using System.Collections.Generic;

namespace TournamentPro
{
    class Program
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
        static int Team2For = 3;
        static int Team3For = 4;
        static int Team4For = 2;
        static int Team5For = 0;
        static int Team6For = 0;
        static int Team7For = 0;
        static int Team8For = 0;

        static int Team1PointsAgainst = 2;
        static int Team2PointsAgainst = 3;
        static int Team3PointsAgainst = 3;
        static int Team4PointsAgainst = 1;
        static int Team5PointsAgainst = 0;
        static int Team6PointsAgainst = 0;
        static int Team7PointsAgainst = 0;
        static int Team8PointsAgainst = 0;

        static int Team1Wins = 5;
        static int Team2Wins = 3;
        static int Team3Wins = 4;
        static int Team4Wins = 0;
        static int Team5Wins = 0;
        static int Team6Wins = 0;
        static int Team7Wins = 0;
        static int Team8Wins = 0;

        static int Team1Losses = 6;
        static int Team2Losses = 6;
        static int Team3Losses = 0;
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

        static void Main(string[] args)
        {
            SortPoints();
            PointsFor();
        }

        /*
         * [7,7,5,4] Top 2 the same
         * [7,6,6,4] Middle 2 the same
         * [7,6,6,6] Bottom 3 the same
         * [7,7,7,4] Top 3 the same
         * [7,7,7,7] All the same
         * [7,6,5,4] All different
         * [7,6,5,5] Bottom two the same
        */

        static void PointsFor()
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

            //Top 3 teams have the same points
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

                //Allocate second team
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

                //Allocate third team
                if (inputTeam1 == "Team1" && inputTeam2 == "Team2")
                {
                    //Allocate second team
                    if (Team3[0] == pointsFor[2])
                    {
                        inputTeam3 = "Team3";
                    }
                    else
                    {
                        inputTeam3 = "Team4";
                    }
                }
                else if (inputTeam1 == "Team1" && inputTeam2 == "Team3")
                {
                    //Allocate second team
                    if (Team2[0] == pointsFor[2])
                    {
                        inputTeam3 = "Team2";
                    }
                    else
                    {
                        inputTeam3 = "Team4";
                    }
                }
                else if (inputTeam1 == "Team1" && inputTeam2 == "Team4")
                {
                    //Allocate second team
                    if (Team2[0] == pointsFor[2])
                    {
                        inputTeam3 = "Team2";
                    }
                    else
                    {
                        inputTeam3 = "Team3";
                    }
                }
                else if (inputTeam1 == "Team2" && inputTeam2 == "Team3")
                {
                    //Allocate second team
                    if (Team1[0] == pointsFor[2])
                    {
                        inputTeam3 = "Team1";
                    }
                    else
                    {
                        inputTeam3 = "Team4";
                    }
                }


                var results = LowestPointsAgainstFromThree(inputTeam1, inputTeam2, inputTeam3);

                FirstHalfTopTeam = results[0];
                FirstHalfSecondTeam = results[1];
            }

            //Bottom 3 teams have the same points
            if ((pointsFor[0] != pointsFor[1]) && (pointsFor[1] == pointsFor[3]))
            {
            }

            //All teams have the same points
            if ((pointsFor[0] == pointsFor[3]))
            {
            }

            Console.WriteLine(FirstHalfTopTeam);
            Console.WriteLine(FirstHalfSecondTeam);
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

            //Allocate team to third team for points comparison
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

        private static string pickRandomFromThree(string teamOne, string teamTwo, string teamThree)
        {
            List<string> teams = new List<string> { };
            teams.Add(teamOne);
            teams.Add(teamTwo);
            teams.Add(teamThree);
            Random rnd = new Random();
            int selected = rnd.Next(1, 4);
            string chosen = teams[selected];
            return chosen;
        }

        private static string pickRandomFromFour(string teamOne, string teamTwo, string teamThree, string teamFour)
        {
            List<string> teams = new List<string> { };
            teams.Add(teamOne);
            teams.Add(teamTwo);
            teams.Add(teamThree);
            teams.Add(teamFour);
            Random rnd = new Random();
            int selected = rnd.Next(0, 4);
            string chosenOne = teams[selected];
            teams.RemoveAt(selected);
            int selected2 = rnd.Next(0, 3);
            string chosenTwo = teams[selected2];
            return chosenOne + " " + chosenTwo;
        }
    }
}
