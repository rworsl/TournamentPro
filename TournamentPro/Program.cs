using System;
using System.Collections.Generic;

namespace ConsoleApp2
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

        static int Team1For = 0;
        static int Team2For = 0;
        static int Team3For = 0;
        static int Team4For = 0;
        static int Team5For = 0;
        static int Team6For = 0;
        static int Team7For = 0;
        static int Team8For = 0;

        static int Team1PointsAgainst = 0;
        static int Team2PointsAgainst = 0;
        static int Team3PointsAgainst = 0;
        static int Team4PointsAgainst = 0;
        static int Team5PointsAgainst = 0;
        static int Team6PointsAgainst = 0;
        static int Team7PointsAgainst = 0;
        static int Team8PointsAgainst = 0;

        static int Team1Wins = 0;
        static int Team2Wins = 0;
        static int Team3Wins = 0;
        static int Team4Wins = 0;
        static int Team5Wins = 0;
        static int Team6Wins = 0;
        static int Team7Wins = 0;
        static int Team8Wins = 0;

        static int Team1Losses = 0;
        static int Team2Losses = 0;
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
            sortTopPoints();
        }

        /*
         * [7,7,5,4] Top 2 the same
         * [7,6,6,4] Middle 2 the same
         * [7,6,6,6] Bottom 3 the same
         * [7,7,7,4] Top 3 the same
         * [7,7,7,7] All the same
         * [7,6,5,4] All different
        */

        static void sortTopPoints()
        {
            pointsFor.Sort();
            pointsFor.Reverse();

            //All Teams on different points gained
            if ((pointsFor[0] != pointsFor[1]) && (pointsFor[1] != pointsFor[2]))
            {
                if(Team1For == pointsFor[0])
                {
                    FirstHalfTopTeam = "Team1";
                    if(Team2For == pointsFor[1])
                    {
                        FirstHalfSecondTeam = "Team2";
                    }
                    else if (Team3For == pointsFor[1])
                    {
                        FirstHalfSecondTeam = "Team3";
                    }
                    else
                    {
                        FirstHalfSecondTeam = "Team4";
                    }
                }
                else if(Team2For == pointsFor[0])
                {
                    FirstHalfTopTeam = "Team2";
                    if (Team1For == pointsFor[1])
                    {
                        FirstHalfSecondTeam = "Team1";
                    }
                    else if (Team3For == pointsFor[1])
                    {
                        FirstHalfSecondTeam = "Team3";
                    }
                    else
                    {
                        FirstHalfSecondTeam = "Team4";
                    }
                }
                else if(Team3For == pointsFor[0])
                {
                    FirstHalfTopTeam = "Team3";
                    if (Team1For == pointsFor[1])
                    {
                        FirstHalfSecondTeam = "Team1";
                    }
                    else if (Team2For == pointsFor[1])
                    {
                        FirstHalfSecondTeam = "Team2";
                    }
                    else
                    {
                        FirstHalfSecondTeam = "Team4";
                    }
                }
                else
                {
                    FirstHalfTopTeam = "Team4";
                    if (Team1For == pointsFor[1])
                    {
                        FirstHalfSecondTeam = "Team1";
                    }
                    else if (Team2For == pointsFor[1])
                    {
                        FirstHalfSecondTeam = "Team2";
                    }
                    else
                    {
                        FirstHalfSecondTeam = "Team3";
                    }
                }
            }

            //Top 2 teams have the same points
            if ((pointsFor[0] == pointsFor[1]) && (pointsFor[1] != pointsFor[2]))
            {

            }

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

        private static int LowestPointsAgainstFromTwo(int teamOne, int teamTwo)
        {
            if (teamOne > teamTwo)
            {
                return teamTwo;
            }
            else if(teamTwo > teamOne)
            {
                return teamOne;
            }
            else
            {
                //needs to look at games won
                return 0;
            }
        }

        private static int LowestPointsAgainstFromThree(int teamOne, int teamTwo, int teamThree)
        {
            if ((teamOne < teamTwo) && (teamOne < teamThree))
            {
                return teamOne;
            }
            else if ((teamTwo < teamOne) && (teamTwo < teamThree))
            {
                return teamTwo;
            }
            else if ((teamThree < teamOne) && (teamTwo > teamThree))
            {
                return teamThree;
            }
            else
            {
                //needs to look at games won
                return 0;
            }
        }

        private static List<int> LowestPointsAgainstFromFour(int teamOne, int teamTwo, int teamThree, int teamFour)
        {
            List<int> lowestScores = new List<int> { };

            lowestScores.Add(teamOne);
            lowestScores.Add(teamTwo);
            lowestScores.Add(teamThree);
            lowestScores.Add(teamFour);
            lowestScores.Sort();

            List<int> output = new List<int> { };

            if ((lowestScores[0] < lowestScores[1]) && (lowestScores[1] < lowestScores[2]))
            {
                //lowest scores are all different so just pick the two lowest
                output.Add(lowestScores[0]);
                output.Add(lowestScores[1]);
            }
            else if((lowestScores[0] < lowestScores[1]) && (lowestScores[1] == lowestScores[2]) && (lowestScores[1] != lowestScores[3]))
            {
                //lowest score is unique, and middle two are the same
            }
            else if ((lowestScores[0] < lowestScores[1]) && (lowestScores[1] == lowestScores[2]) && (lowestScores[1] == lowestScores[3]))
            {
                //lowest score is unique, and top 3 are the same
            }
            else if ((lowestScores[0] == lowestScores[1]) && (lowestScores[1] != lowestScores[2]))
            {
                //lowest 2 scores are the same
            }
            else if ((lowestScores[0] == lowestScores[2]) && (lowestScores[0] != lowestScores[3]))
            {
                //lowest 3 scores are the same
            }
            else if (lowestScores[0] == lowestScores[3])
            {
                //all scores are the same
            }
            return output;
        }


        private static string pickRandomFromTwo(string teamOne, string teamTwo)
        {
            List<string> teams = new List<string> { };
            teams.Add(teamOne);
            teams.Add(teamTwo);
            Random rnd = new Random();
            int selected = rnd.Next(1,3);
            string chosen = teams[selected];
            return chosen;
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
