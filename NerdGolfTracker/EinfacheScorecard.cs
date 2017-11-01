using System.Collections.Generic;
using System.Linq;

namespace NerdGolfTracker
{
    public class EinfacheScorecard : IScorecard
    {
        public int AnzahlSchlaege => AktuellesLoch.AnzahlSchlaege;

        public int AnzahlSchlaegeTotal
        {
            get
            {
                return _loecher.Values.Sum(loch => loch.AnzahlSchlaege);
            }
        }
        public int Lochnummer { get; private set; }
        readonly Dictionary<int, Loch> _loecher  = new Dictionary<int, Loch>();

        private Loch AktuellesLoch
        {
            get
            {
                if(!_loecher.ContainsKey(Lochnummer)) _loecher.Add(Lochnummer, new Loch());
                return _loecher[Lochnummer];
            }
        }


        public EinfacheScorecard()
        {
            Lochnummer = 1;
        }

        public void SchliesseLochAb()
        {
            Lochnummer++;
        }

        public void ErhoeheAnzahlSchlaege()
        {
            AktuellesLoch.ErhoeheSchlaganzahl();
        }

        public void MacheLetzteAktionRueckgaengig()
        {
            if (AktuellesLoch.AnzahlSchlaege > 0)
            {
                AktuellesLoch.ErniedrigeSchlaganzahl();
            }
            else if (AktuellesLoch.AnzahlSchlaege == 0 && Lochnummer > 1)
            {
                Lochnummer--;
            }
        }
    }
}