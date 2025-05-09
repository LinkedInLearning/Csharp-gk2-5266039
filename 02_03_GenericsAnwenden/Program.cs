using System.Collections.Generic;

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
            var list = new List<Point>();

            Point point = new Point();
            point.X = 42;
            point.Y = 42;
            list.Add(point);
            point = new Point();
            point.X = 43;
            point.Y = 43;
            list.Add(point);
            point = new Point();
            point.X = 43;
            point.Y = 44;
            list.Add(point);

            var o = list[2];  // o ist vom Typ Point

            foreach (var p in list)
            {
                // p ist vom Typ Point
                Console.WriteLine($"{p.X},{p.Y}");
            }
        }
    }
}
