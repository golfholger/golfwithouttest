namespace NerdGolfTracker
{
    public static class Formatter
    {
        public static string GetSchlagName(int anzahl)
        {
            string result = "Schläge";
            if (anzahl == 1)
            {
                result = "Schlag";
            }
            return result;
        }
    }
}
