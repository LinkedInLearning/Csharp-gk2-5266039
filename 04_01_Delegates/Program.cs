namespace Delegates
{
    internal class Program
    {
        void DoIt()
        {
            List<int> list = new List<int> { 6, 1, 7, 3, 23 };

            list.Sort(Ascending);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

        }

        int Ascending(int i1, int i2)
        {
            return i1 - i2;
        }

        int Descending(int i1, int i2)
        {
            return i2 - i1;
        }

        static void Main(string[] args)
        {
            new Program().DoIt();
        }
    }
}
