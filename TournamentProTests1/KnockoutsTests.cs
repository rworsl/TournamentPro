using Microsoft.VisualStudio.TestTools.UnitTesting;
using TournamentPro;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TournamentPro.Tests
{
    [TestClass()]
    public class KnockoutsTests
    {
        [STAThread]
        [TestMethod()]
        public void KnockoutsTest()
        {
            new Knockouts(5, 4, 3, 2, 1, 1, 1, 1, 4, 6, 1, 1, 1, 1, 1, 1, 4, 5, 1, 1, 1, 1, 1, 1);
        }

        [TestMethod()]
        public void TeamLossesTest()
        {

        }

        [TestMethod()]
        public void PointsForTest()
        {

        }

        [STAThread]
        [TestMethod()]
        public void LowestPointsAgainstFromTwoTest()
        {
            //new Knockouts(5, 4, 3, 2, 1, 1, 1, 1, 4, 6, 1, 1, 1, 1, 1, 1, 4, 5, 1, 1, 1, 1, 1, 1);
            var dm = TournamentPro.Knockouts.LowestPointsAgainstFromTwo("Team1", "Team2");
            Assert.AreEqual("Team1", dm[0]);
        }

        [TestMethod()]
        public void LowestPointsAgainstFromFourTest()
        {

        }

        [TestMethod()]
        public void GamesWonFromFourTest()
        {

        }

        [TestMethod()]
        public void GamesLostFromFourTest()
        {

        }

        [TestMethod()]
        public void LowestPointsAgainstFromThreeTest()
        {

        }

        [TestMethod()]
        public void GamesWonFromThreeTest()
        {

        }

        [TestMethod()]
        public void GamesLostFromThreeTest()
        {

        }

        [TestMethod()]
        public void GamesWonFromTwoTest()
        {

        }

        [TestMethod()]
        public void GamesLostFromTwoTest()
        {
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

        }
    }
}