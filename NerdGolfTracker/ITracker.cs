
namespace NerdGolfTracker
{
    public interface ITracker
    {
        bool Beendet { get; set; }
        string ReagiereAuf(string kommando);
        string Starte();
    }
}
