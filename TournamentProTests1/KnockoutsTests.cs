using Microsoft.VisualStudio.TestTools.UnitTesting;
using TournamentPro;
using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentPro.Tests
{
    [TestClass()]
    public class KnockoutsTests
    {
        [STAThread]
        [TestMethod()]
        public void KnockoutsTest()
        {
            new Knockouts(5, 4, 3, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4, 5, 1, 1, 1, 1, 1, 1);
        }

        [TestMethod()]
        public void TeamLossesTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PointsForTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LowestPointsAgainstFromTwoTest()
        {
            new Knockouts(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4, 5, 1, 1, 1, 1, 1, 1);
            //int Team2Losses = 5;
            var dm = TournamentPro.Knockouts.pickRandomFromTwo("Team1", "Team2");
            Assert.AreEqual("Team1", dm[0]);
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
            new Knockouts(1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4, 5, 1, 1, 1, 1, 1, 1);
            //int Team2Losses = 5;
            var dm = TournamentPro.Knockouts.pickRandomFromTwo("Team1", "Team2");
            Assert.AreEqual("Team1",dm[0]);
        }

        [TestMethod()]
        public void pickRandomFromTwoTest()
        {
            var dm = TournamentPro.Knockouts.pickRandomFromTwo("a", "b");
            Assert.IsTrue(dm[0].Equals("a") || (dm[0].Equals("b")));
        }

        [TestMethod()]
        public void pickRandomFromThreeTest()
        {
            var dm = TournamentPro.Knockouts.pickRandomFromThree("a", "b", "c");
            Assert.IsTrue(dm[0].Equals("a") || (dm[0].Equals("b")) || (dm[0].Equals("c")));
        }

        [TestMethod()]
        public void pickRandomFromFourTest()
        {
            Assert.Fail();
        }
    }
}