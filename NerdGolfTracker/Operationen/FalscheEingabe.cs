using System;

namespace NerdGolfTracker.Operationen
{
    public class FalscheEingabe : IOperation
    {
        public string FuehreAus(IScorecard scorecard, ITracker tracker)
        {
            return "Falsche Eingabe. Unbekannter Befehl." + Environment.NewLine + Environment.NewLine;
        }
    }
}
