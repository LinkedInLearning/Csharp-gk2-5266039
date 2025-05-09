
namespace Interfaces.AC
{
    abstract class A
    {
        public virtual void Foo()
        {
            Console.WriteLine("A.Foo");
        }
    }

    class B : A
    {
        public override void Foo()
        {
            Console.WriteLine("B.Foo");
        }
        public virtual int Bar(int x)
        {
            return 42;
        }
    }

    class C : A
    {
        public override void Foo()
        {
            Console.WriteLine("C.Foo");
        }
        public virtual int Bar(int x)
        {
            return 23;
        }
    }

    // Dieser Code kompiliert nicht, weil Mehrfachvererbung in C#
    // nicht möglich ist.
    class D : B, C
    {
        public void Func()
        {
            Foo();
            int i = Bar(2);
        }
    }
}
