namespace GenericsAnlegen
{
    class Mitarbeiter
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
    }

    class LogDecorator<T> where T: new()
    {
        T theObject;

        public LogDecorator()
        {
            this.theObject = new T();
        }

        public T Value
        {
            get
            {
                Console.WriteLine($"Objekt wurde abgeholt: {theObject.GetType()}");
                return theObject;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var d1 = new LogDecorator<Mitarbeiter>();

            //....

            var m2 = d1.Value;
            m2.Vorname = "Mirko";
        }
    }
}
