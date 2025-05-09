namespace StatischeKlassen
{
    static class Definitions
    {

        public static readonly string Author = "Mirko Matytschak";

        public static string GetDefinitionOf(string alias)
        {
            return "";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            if (Definitions.Author.StartsWith("Mirko"))
                Console.WriteLine("Alles Bestens");

        }
    }
}
