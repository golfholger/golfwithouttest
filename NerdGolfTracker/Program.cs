using System;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker
{
    internal class Program
    {
        static void Main()
        {
            var startoperation = new Folgeoperation(new Lochbegruessung(), new Lochausgabe());
            var tracker = new Tracker(new EinfacherInterpreter(), startoperation, new EinfacheScorecard());
            Console.WriteLine(tracker.Starte());
            while (!tracker.Beendet)
            {
                var befehl = Console.ReadLine();
                Console.WriteLine(tracker.ReagiereAuf(befehl));                
            }
            Console.ReadLine();            
        }
    }
}
