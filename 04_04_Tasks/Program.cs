namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks = new Task[10];

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = StartTask(i);
            }

            Task.WaitAll(tasks);
        }

        static Task StartTask(int i)
        {
            return Task.Run(() =>
            {
                Console.WriteLine(i);
            });
        }
    }
}
