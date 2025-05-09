using CalcLib;

namespace Dlls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            Console.WriteLine($"{a} + {b} = {Calculator.Add(a, b)}");
        }
    }
}
