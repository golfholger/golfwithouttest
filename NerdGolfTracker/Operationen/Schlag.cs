namespace NerdGolfTracker.Operationen
{
    public class Schlag : IOperation
    {
        public string FuehreAus(IScorecard scorecard, ITracker tracker)
        {
            scorecard.ErhoeheAnzahlSchlaege();
            return "";
        }
    }
}