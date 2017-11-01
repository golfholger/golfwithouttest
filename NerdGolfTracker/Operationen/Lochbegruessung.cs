namespace NerdGolfTracker.Operationen
{
    public class Lochbegruessung : IOperation
    {
        public string FuehreAus(IScorecard scorecard, ITracker tracker)
        {
            return "Du bist jetzt ";
        }
    }
}