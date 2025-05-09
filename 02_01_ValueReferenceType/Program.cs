namespace ValueReferenceType
{
    internal class Program
    {
        class ClassPoint
        {
            public int X;
            public int Y;
        }

        struct StructPoint
        {
            public int X;
            public int Y;
        }


        static void Main(string[] args)
        {
            int i = 42;

            ClassPoint cp = new ClassPoint();
            cp.X = 42;
            cp.Y = 43;

            StructPoint sp = new StructPoint();
            sp.X = 42;
            sp.Y = 43;

            Foo(sp, cp);

            Console.WriteLine($"cp: {cp.X}");
            Console.WriteLine($"sp: {sp.X}");

            object o = sp;
            var sp2 = (StructPoint)o;
        }

        static void Foo(StructPoint sp, ClassPoint cp)
        {
            sp.X = 12343;
            cp.X = 7373737;
        }

    }
}
