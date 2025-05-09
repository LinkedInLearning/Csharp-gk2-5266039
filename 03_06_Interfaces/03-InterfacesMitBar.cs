
namespace Interfaces.MitBar
{
    interface A
    {
        void Foo();
    }

    interface B : A
    {
        int Bar(int x);
        void Bax();
    }

    interface C : A
    {
        int Bar(int x);
    }

    // Dieser Code kompiliert, weil ein und dieselbe Implementierung
    // die Vorgaben aus mehreren Interfaces erfüllen kann.
    class D : B, C
    {
        public int Bar(int x)
        {
            Console.WriteLine("Bar");
            return 23;
        }

        public void Bax()
        {
        }

        public void Foo()
        {
            Console.WriteLine("Foo");
        }
    }

}
