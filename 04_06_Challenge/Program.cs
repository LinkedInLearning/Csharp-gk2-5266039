namespace Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Datei wird gelesen...");
            string inhalt = DateiLesen("Datei.txt");
            Console.WriteLine($"Datei-Inhalt: {inhalt}");
        }

        static string DateiLesen(string dateiPfad)
        {
            return File.ReadAllText( dateiPfad );
        }
    }
}
