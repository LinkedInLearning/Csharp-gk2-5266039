using ExternalLib;

namespace AccessModifiers
{
    internal class InternalClass
    {
        protected int i;
        protected class NestedClass
        { }

        protected void Foo() { }
    }

    internal class Program : ExternalClass
    {
        void Bar()
        {
            Foo();

            i = 42;
        }
        static void Main(string[] args)
        {
            InternalClass ic;
            ExternalClass ec;
            new Program().Bar();
            Console.WriteLine("Hello, World!");
        }
    }
}
