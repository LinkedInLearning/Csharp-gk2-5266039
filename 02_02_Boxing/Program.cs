using System.Collections;

namespace Boxing
{
    struct Point
    {
        public int X;
        public int Y;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var al = new ArrayList();

            al.Add("Hallo");
            al.Add(42);
            Point point = new Point();
            point.X = 42;
            point.Y = 42;
            al.Add(point);

            var o = (Point)al[2];

            Console.WriteLine(typeof(object).IsValueType);
        }
    }
}
