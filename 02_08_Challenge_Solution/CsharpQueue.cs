
using System;
using System.Collections.Generic;

namespace Challenge_Lösung
{
    public class CsharpQueue<T>
    {
        private List<T> elemente = new List<T>();

        public void Enqueue(T item)
        {
            elemente.Add( item );
        }

        public T Dequeue()
        {
            if (elemente.Count == 0)
                throw new InvalidOperationException( "Die Warteschlange ist leer" );

            T item = elemente[0];
            elemente.RemoveAt( 0 );
            return item;
        }

        public int Count => elemente.Count;
    }
}
