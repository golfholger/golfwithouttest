using Microsoft.VisualStudio.TestTools.UnitTesting;
using NerdGolfTracker;

namespace UnitTests
{
    [TestClass]
    public class EinfacheScorecardTest
    {
        private IScorecard _scorecard;

        [TestInitialize]
        public void InitialisiereScorecard()
        {
            _scorecard = new EinfacheScorecard();
        }

        [TestMethod]
        public void InkrementiertSchlagzahlEinmal()
        {
            Assert.AreEqual(_scorecard.AnzahlSchlaege, 42);
            Assert.AreEqual(_scorecard.Lochnummer, 0);
        }
    }
}