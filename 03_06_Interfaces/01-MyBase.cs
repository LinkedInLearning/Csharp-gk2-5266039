
namespace Interfaces.AbstrakteDefinitionen
{
    abstract class MyBase
    {
        private int i;

        public void Foo()
        {
            Console.WriteLine($"Foo{i}");
        }

        public abstract int Bar(int i);

        public abstract string Name { get; set; }
    }

    // Die Modifizierer public und abstract sind unnötig,
    // weil Mitglieder von Interfaces immer public und abstract sind.
    interface IMyBase
    {
        void Foo();

        int Bar(int i);

        string Name { get; set; }
    }
}
