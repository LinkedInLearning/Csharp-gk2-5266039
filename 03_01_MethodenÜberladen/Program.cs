namespace MethodenÜberladen
{
    class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static double Add(double a, double b, double c = 0)
        {
            return a + b + c;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
             Console.WriteLine($"{a} + {b} = {Calculator.Add(a,b)}");

            double c = Calculator.Add(b, 4.4);
            Console.WriteLine(c);

        }
    }
}
