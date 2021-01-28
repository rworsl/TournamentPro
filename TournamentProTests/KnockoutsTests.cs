using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TournamentPro;

namespace TournamentPro.Tests
{
    [TestClass()]
    public class KnockoutsTests
    {
        [TestMethod()]
        public void KnockoutsTest()
        {
        }

        [TestMethod()]
        public void PointsForTest()
        {

        }

        
        [TestMethod()]
        [STAThread]
        public void pickRandomFromFourTest()
        {
            var bm = new Knockouts();

            //var test1 = new Knockouts(1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1);
            string a = "1";
            string b = "2";
            string c = "3";
            string d = "4";

            var result = pickRandomFromFour("1", "2", "3", "4");
        }

        [TestMethod()]
        public void KnockoutsTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AssignGamesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void TeamLossesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PointsForTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SortPointsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LowestPointsAgainstFromTwoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LowestPointsAgainstFromFourTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GamesWonFromFourTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GamesLostFromFourTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LowestPointsAgainstFromThreeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GamesWonFromThreeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GamesLostFromThreeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GamesWonFromTwoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GamesLostFromTwoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void pickRandomFromTwoTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void pickRandomFromThreeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void pickRandomFromFourTest1()
        {
            Assert.Fail();
        }
    }
}