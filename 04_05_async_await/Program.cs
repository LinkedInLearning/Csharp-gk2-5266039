namespace async_await
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await new Program().DoIt();
        }

        async Task DoIt()
        {
            string s = await ReadStringAsync();
            Console.WriteLine(s);
        }

        string ReadString()
        {
            StreamReader sr1 = new StreamReader("Datei1.txt");
            StreamReader sr2 = new StreamReader("Datei2.txt");
            string s1 = sr1.ReadToEnd();
            string s2 = sr2.ReadToEnd();
            return s1 + s2;
        }

        async Task<string> ReadStringAsync()
        {
            StreamReader sr1 = new StreamReader("Datei1.txt");
            StreamReader sr2 = new StreamReader("Datei2.txt");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            string s1 = await sr1.ReadToEndAsync();
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            string s2 = await sr2.ReadToEndAsync();
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            return s1 + s2;
        }
    }
}
