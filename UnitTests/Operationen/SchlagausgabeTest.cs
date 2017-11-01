using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestClass]
    public class SchlagausgabeTest
    {
        private Mock<IScorecard> _scorecardStub;
        private Schlagausgabe _schlagausgabe;
            
        [TestInitialize]
        public void Init()
        {
            _scorecardStub = new Mock<IScorecard>();
            _schlagausgabe = new Schlagausgabe();
        }

        [TestMethod]
        public void GibtSchlagzahlenAus()
        {
            _scorecardStub.Setup(scorecard => scorecard.AnzahlSchlaege).Returns(1);
            StringAssert.Contains(_schlagausgabe.FuehreAus(_scorecardStub.Object, null), "11 Schlaege");
        }

   }
}