namespace NerdGolfTracker.Operationen
{
    public class Lochausgabe : IOperation
    {
        public string FuehreAus(IScorecard scorecard, ITracker tracker)
        {
            return $"auf dem {scorecard.Lochnummer}. Loch.";
        }
    }
}