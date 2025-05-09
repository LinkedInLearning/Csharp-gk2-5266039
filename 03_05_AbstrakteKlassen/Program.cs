namespace AbstrakteKlassen
{
    abstract class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }

        public virtual string Name => $"{Vorname} {Nachname}";


        public override string ToString()
        {
            return Name;
        }
    }

    class Mitarbeiter : Person
    {
        public override string ToString()
        {
            return $"{base.ToString()}, Bonus: Nope";
        }
    }

    class Manager : Person
    {
        public decimal Bonus { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}, Bonus: {Bonus}";
        }
    }


    internal class Program
    {
        static void BuildList(List<Person> list)
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

        static void ShowList(List<Person> list)
        {
            foreach (var obj in list)
            {
                Console.WriteLine(obj.ToString());
            }
        }

        static void Main(string[] args)
        {
            var l = new List<Person>();
            BuildList(l);
            ShowList(l);

            // Dieser Code kompiliert nicht.
            // var p = new Person();
        }
    }

}
