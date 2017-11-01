namespace NerdGolfTracker.Operationen
{
    public class Undo : IOperation
    {
        public string FuehreAus(IScorecard scorecard, ITracker tracker)
        {
            scorecard.MacheLetzteAktionRueckgaengig();
            return "Letzter Befehl r�ckg�ngig gemacht. ";
        }
    }
}