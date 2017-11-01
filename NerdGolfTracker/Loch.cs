namespace NerdGolfTracker
{
    class Loch
    {
        public int AnzahlSchlaege { get; private set; }

        public void ErhoeheSchlaganzahl()
        {
            AnzahlSchlaege++;
        }

        public void ErniedrigeSchlaganzahl()
        {
            AnzahlSchlaege--;
        }
    }
}
