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

        [DataRow]
        [TestMethod()]
        public void KnockoutsTest()
        {
            var test = new Knockouts(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

            Assert.AreEqual("Team1", test);
        }

        [TestMethod()]
        public void PointsForTest()
        {
            var test = new Knockouts(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            var example = new PointsFor();


            Assert.AreEqual("Team1", example);
        }
    }
}