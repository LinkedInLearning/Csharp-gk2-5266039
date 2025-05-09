using System.Xml;

namespace KonversionVonObjekten
{
    class Mitarbeiter
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
    }

    class Manager
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public decimal Bonus { get; set; }
    }


    internal class Program
    {
        static void BuildList(List<object> list)
        {
            Mitarbeiter m = new Mitarbeiter();
            m.Vorname = "Mirko";
            m.Nachname = "Matytschak";
            list.Add(m);
            var ma = new Manager();
            ma.Vorname = "Johnny";
            ma.Nachname = "Controlletti";
            ma.Bonus = 200000;
            list.Add(ma);
        }

        static void ShowList(List<object> list)
        {
            foreach (var obj in list)
            {
                if (obj is Mitarbeiter m)
                {
                    Console.WriteLine($"{m.Vorname} {m.Nachname}");
                }
                if (obj is Manager ma)
                {
                    Console.WriteLine($"{ma.Vorname} {ma.Nachname} {ma.Bonus}");
                }
            }
        }

        static void Main(string[] args)
        {
            List<object> l = new List<object>();
            BuildList(l);
            ShowList(l);
        }
    }
}
