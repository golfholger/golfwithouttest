namespace NerdGolfTracker.Operationen
{
    public class Zwischenergebnisausgabe : IOperation
    {
        public string FuehreAus(IScorecard scorecard, ITracker tracker)
        {
            return $"Du hast insgesamt {scorecard.AnzahlSchlaegeTotal} {Formatter.GetSchlagName(scorecard.AnzahlSchlaegeTotal)} gemacht.";
        }
    }
}