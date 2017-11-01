namespace NerdGolfTracker
{
    public interface IBefehl
    {
        string Kommando { get; }
        IOperation Operation { get; }
        string Erklaerung { get; }
        string Alias { get; }
    }
}