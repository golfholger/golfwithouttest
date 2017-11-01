namespace NerdGolfTracker.Operationen
{
    public class Schlagausgabe : IOperation
    {
        public string FuehreAus(IScorecard scorecard, ITracker tracker)
        {
            return $"Du hast {scorecard.AnzahlSchlaege} {Formatter.GetSchlagName(scorecard.AnzahlSchlaege)} ";
        }
    }
}