namespace NerdGolfTracker.Operationen
{
    public class Folgeoperation : IOperation
    {
        public IOperation[] Operationen { get; }

        public Folgeoperation(params IOperation[] operationen)
        {
            Operationen = operationen;
        }

        public string FuehreAus(IScorecard scorecard, ITracker tracker)
        {
            var result = "";
            foreach (var operation in Operationen)
            {
                result += operation.FuehreAus(scorecard, tracker);
            }
            return result;
        }
    }
}
