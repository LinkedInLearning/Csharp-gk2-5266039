
using PersistenteKlassen;

namespace PartielleKlassen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mitarbeiter m = new Mitarbeiter();
            m.Vorname = "Mirko";
            m.Nachname = "Matytschak";


            Console.WriteLine($"{m.Vorname} {m.Nachname}");
        }
    }
}
