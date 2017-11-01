namespace NerdGolfTracker.Operationen
{
    public class Lochwechsel : IOperation
    {
        public string FuehreAus(IScorecard scorecard, ITracker tracker)
        {
            scorecard.SchliesseLochAb();
            return "";
        }
    }
}