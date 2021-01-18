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

        static string FirstHalfTopTeam = "";
        static string FirstHalfSecondTeam = "";

        static void Main(string[] args)
        {
            SortPoints();
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



            /*
            if (pointsFor[0] == pointsFor[3]) 
            {
                //all four are the same score
                string returned = pickRandomFromFour("team1", "team2", "team3", "team4");

                teams = LowestPointsAgainstFromFour(Team1PointsAgainst, Team2PointsAgainst, Team3PointsAgainst, Team4PointsAgainst);

                FirstHalfTopTeam = teams[0];
                FirstHalfSecondTeam = teams[1];

                Console.WriteLine(returned); 

            }
            else if (pointsFor[1] == pointsFor[3])
            {
                //bottom 3 are the same score
                Console.WriteLine("items 2, 3 and 4 are the same");
            }
            else if (pointsFor[0] == pointsFor[1])
            {
                //solve which order the top 2 are
                string returned = pickRandomFromTwo("team1", "team2");
                Console.WriteLine("items 1 and 2 are the same");
            }
            else if (pointsFor[1] == pointsFor[2])
            {
                //solve which team goes in 2nd
                var selectedScore = LowestPointsAgainstFromTwo(pointsFor[1], pointsFor[2]);
                
                if(selectedScore == Team1PointsAgainst)
                {
                    FirstHalfSecondTeam = "Team1";
                }
                else if (selectedScore == Team2PointsAgainst)
                {
                    FirstHalfSecondTeam = "Team2";
                }
                else if (selectedScore == Team3PointsAgainst)
                {
                    FirstHalfSecondTeam = "Team3";
                }
                else if (selectedScore == Team4PointsAgainst)
                {
                    FirstHalfSecondTeam = "Team4";
                }

                Console.WriteLine("items 2 and 3 are the same");
            }
            else if (pointsFor[0] == pointsFor[2])
            {
                //solve which team goes in 2nd
                Console.WriteLine("items 1, 2 and 3 are the same");
            }
            else
            {
                //No duplicates so top 2 are just the first 2 items
                Console.WriteLine(pointsFor[0] + ", " + pointsFor[1]);
            }
            */

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
