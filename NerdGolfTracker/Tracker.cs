namespace NerdGolfTracker
{
    public class Tracker : ITracker
    {
        private readonly IOperation _startoperation;
        private readonly IScorecard _scorecard;
        private readonly IInterpreter _interpreter;
        
        public Tracker(IInterpreter interpreter, IOperation startoperation, IScorecard einfacheScorecard)
        {
            _interpreter = interpreter;
            _startoperation = startoperation;
            _scorecard = einfacheScorecard;
            Beendet = false;
        }

        public string ReagiereAuf(string kommando)
        {
            return _interpreter.OperationFuer(kommando).FuehreAus(_scorecard, this);
        }

        public string Starte()
        {
            return _startoperation.FuehreAus(_scorecard, this);
        }

        public bool Beendet { get; set; }
    }

}