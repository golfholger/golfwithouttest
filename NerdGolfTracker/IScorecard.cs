namespace NerdGolfTracker
{
    public interface IScorecard
    {
        int AnzahlSchlaege { get; }
        int AnzahlSchlaegeTotal { get; }
        int Lochnummer { get; }

        void ErhoeheAnzahlSchlaege();
        void MacheLetzteAktionRueckgaengig();
        void SchliesseLochAb();
    }
}