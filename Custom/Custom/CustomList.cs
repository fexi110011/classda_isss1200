using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom
{
    internal class CustomList<T>
    {
        private T[] elements;
        private int size;
        private int capacity;
        public CustomList(int initialCapacity =4 )
        {
            capacity = initialCapacity;
            elements = new T[capacity];
            size = 0;
        }
        public void Add( T item )
        {
            if (size == capacity)
            {
                capacity *= 2;
                T[] newElements = new T[capacity];
                Array.Copy(elements,newElements,size);
                elements = newElements;
            }
            elements[size++] = item;
        }
        public T Find(Predicate<T> axtar)
        {
            for ( int i = 0; i < size; i++ )
            {
                if( axtar( elements[i] ) )
                {
                    return elements[i];
                }
            }
            return default( T );
        }
        public List<T> FindAll(Predicate<T> match)
        {
            List<T> result = new List<T>();   
            for( int i = 0;i < size; i++ )
            {
                if( match(elements[i]))
                {
                    result.Add(elements[i]);
                }
            }
            return result;
        }
        public void Remove(Predicate<T> match)
        {
            int index = -1;
            for( int i = 0; i<size; i++ )
            {
                if (match(elements[i]))
                {
                    index = i;
                }
            }
            if( index == -1)
            {
                Console.WriteLine("Bele bir element yoxdur");
            }
            for( int i = index; index < size; i++)
            {
                elements[i] = elements[index];
            }

            elements[size - 1] = default(T);
            size--;
            Console.WriteLine("element silindi");
        }

    }
}
