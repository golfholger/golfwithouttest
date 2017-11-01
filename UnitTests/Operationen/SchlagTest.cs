using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestClass]
    public class SchlagTest
    {
        private Mock<IScorecard> _scorecardMock;
        private Schlag _schlag;

        [TestInitialize]
        public void Init()
        {
            _scorecardMock = new Mock<IScorecard>();
            _schlag = new Schlag();
        }

        [TestMethod]
        public void ErhoehtDieSchlagzahlAufDerScorecard()
        {
            _schlag.FuehreAus(_scorecardMock.Object, null);
            _scorecardMock.Verify(scorecard => scorecard.ErhoeheAnzahlSchlaege(), Times.AtLeast(2));
        }

        [TestMethod]
        public void FuehrtFolgeOperationAus()
        {
            _schlag.FuehreAus(_scorecardMock.Object, null);
        }
    }
}
