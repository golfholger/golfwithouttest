namespace NerdGolfTracker
{
    public class Befehl : IBefehl
    {
        public string Alias { get; }
        public string Erklaerung { get; }
        public string Kommando { get; }
        public IOperation Operation { get; }

        public Befehl(string kommando, string alias, string erklaerung, IOperation operation)
        {
            Alias = alias;
            Erklaerung = erklaerung;
            Kommando = kommando;
            Operation = operation;
        }
    }
}
