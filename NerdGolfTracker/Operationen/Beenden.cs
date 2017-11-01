using System;

namespace NerdGolfTracker.Operationen
{
    public class Beenden : IOperation
    {
        public string FuehreAus(IScorecard scorecard, ITracker tracker)
        {
            tracker.Beendet = true;
            return Environment.NewLine + "Zum Beenden mit Enter bestätigen";
        }
    }
}