using System;

namespace Challenge_Lösung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Verwendung mit int
            CsharpQueue<int> intQueue = new CsharpQueue<int>();
            intQueue.Enqueue( 1 );
            intQueue.Enqueue( 2 );
            Console.WriteLine("intQueue.Dequeue():");
            Console.WriteLine( $"  {intQueue.Dequeue()}" );
            Console.WriteLine( $"  {intQueue.Dequeue()}" );
            // Verwendung mit string
            CsharpQueue<string> stringQueue = new CsharpQueue<string>();
            stringQueue.Enqueue( "Hallo" );
            stringQueue.Enqueue( "Welt" );
            Console.WriteLine( "stringQueue.Dequeue():" );
            Console.WriteLine( $"  {stringQueue.Dequeue()}" );
            Console.WriteLine( $"  {stringQueue.Dequeue()}" );
        }
    }
}
