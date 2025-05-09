namespace Operatorüberladung
{
    internal class Program
    {
        public struct Complex
        {
            double real;
            double imaginary;

            public Complex(double r, double i)
            {
                this.real = r;
                this.imaginary = i;
            }

            public static Complex operator +(Complex c1, Complex c2)
            {
                return new Complex(c1.real + c2.real, c1.imaginary + c2.imaginary);
            }

            public override string ToString()
            {
                return $"{real} + i{imaginary}";
            }
        }
        static void Main(string[] args)
        {
            var c1 = new Complex(1, 2);
            var c2 = new Complex(3, 4);
            var c3 = c1 + c2;
            Console.WriteLine(c3);
        }
    }
}
