using System;

namespace NerdGolfTracker.Operationen
{
    public class Hilfe : IOperation
    {
        public string FuehreAus(IScorecard scorecard, ITracker tracker)
        {
            var hilfstexte = Konfiguration.Befehle.ConvertAll(HilfstextFuer);
            return "Ich helfe dir beim Fuehren der Scorecard. Ich reagiere auf folgende Befehle: " + Environment.NewLine +
                   string.Join(Environment.NewLine, hilfstexte);            
        }

        private string HilfstextFuer(IBefehl befehl)
        {
            var kommandoText = befehl.Kommando;

            // Alias im Kommando suchen und mit [] wrappen
            var aliasPosition = kommandoText.IndexOf(befehl.Alias, StringComparison.InvariantCultureIgnoreCase);
            var textBisAlias = kommandoText.Substring(0, aliasPosition);
            var textNachAlias = kommandoText.Substring(aliasPosition + befehl.Alias.Length);            
            
            var result = $" * \"{textBisAlias}[{befehl.Alias}]{textNachAlias}\" {befehl.Erklaerung}";

            // Default Befehl kennzeichnen
            if (befehl.Kommando == Konfiguration.DefaultBefehl)
            {
                result += " (default bei ENTER)";
            }

            return result;
        }
    }
}