namespace Challenge
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Datei wird gelesen...");
            string inhalt = await DateiLesenAsync("Datei.txt");
            Console.WriteLine($"Datei-Inhalt: {inhalt}");
        }

        static async Task<string> DateiLesenAsync(string dateiPfad)
        {
            return await File.ReadAllTextAsync( dateiPfad );
        }
    }
}
