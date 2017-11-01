using System.Collections.Generic;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker
{
    public static class Konfiguration
    {
        public static readonly List<IBefehl> Befehle = new List<IBefehl>
        {
            new Befehl("Hilfe", "H", "zeigt Dir diese Erklaerung", new Hilfe()),
            new Befehl("Naechstes Loch", "N", "bringt Dich zum naechsten Loch", new Folgeoperation(new Lochwechsel(), new Lochbegruessung(), new Lochausgabe())),
            new Befehl("Schlage Ball", "S", "zaehlt einen Schlag", new Folgeoperation(new Schlag(), new Schlagausgabe(), new Lochausgabe())),
            new Befehl("Zeige Zwischenergebnis", "Z", "zeigt die Gesamtanzahl der Schläge an", new Zwischenergebnisausgabe()),
            new Befehl("Habe fertig", "f", "beendet die Anwendung", new Folgeoperation(new Zwischenergebnisausgabe(), new Beenden())),
            new Befehl("Undo", "U", "macht den letzten ändernde Befehl rückgängig", new Folgeoperation(new Undo(), new Schlagausgabe(), new Lochausgabe())),
        };

        public static readonly string DefaultBefehl = "Schlage Ball";

        public static readonly IOperation FalscheEingabe = new Folgeoperation(new FalscheEingabe(), new Hilfe());
    }
}
