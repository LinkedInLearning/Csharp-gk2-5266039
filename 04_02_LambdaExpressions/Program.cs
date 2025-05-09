namespace Delegates
{
    internal class Program
    {
        void DoIt()
        {
            List<int> list = new List<int> { 6, 1, 7, 3, 23 };

            list.Sort((i1, i2) => i1 - i2);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            new Program().DoIt();
        }
    }
}
