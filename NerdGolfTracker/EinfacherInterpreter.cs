using System.Linq;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : IInterpreter
    {
        public IOperation OperationFuer(string kommando)
        {
            var befehle = Konfiguration.Befehle;
            kommando = kommando.Trim();

            // Default Befehl ermitteln
            if (kommando == "")
            {
                return befehle.Single(x => x.Kommando == Konfiguration.DefaultBefehl).Operation;
            }

            var befehlAusfuehren = befehle.Find(befehl => kommando == befehl.Kommando || kommando == befehl.Alias);
            return befehlAusfuehren != null ? befehlAusfuehren.Operation : Konfiguration.FalscheEingabe;
        }
    }
}
