using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class GenericList<T> where T : IComparable
    {
        private int numberOfElements;
        private T[] items;

        public GenericList(int capacity)
        {
            items = new T[capacity];
            numberOfElements = 0;
        }
        
        //adding element
        public void Add(T element)
        {
            TryAutoGrow();
            items[numberOfElements] = element;
            numberOfElements++;
        }

        //accessing element by index
        public T Get(int index)
        {
            if (index > numberOfElements - 1 || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of bounds");
            }
            return items[index];
        }

        //removing element by index
        public void RemoveAt(int index)
        {
            if (index > numberOfElements - 1 || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of bounds");
            }
            for (int i = index; i < numberOfElements - 1; i++)
            {
                items[i] = items[i + 1];
            }
            numberOfElements--;
            items[numberOfElements] = default(T);
        }

        //inserting element at given position
        public void InsertAt(int index, T element)
        {
            TryAutoGrow();
            if (index > numberOfElements || index < 0)
            {
                throw new IndexOutOfRangeException("Index is out of bounds");
            }

            for (int i = index + 1; i < numberOfElements; i++)
            {
                items[i + 1] = items[i];
            }
            items[index] = element;
            if (index == numberOfElements)
            {
                numberOfElements++;
            }
        }

        //clearing the list
        public void Clear()
        {
            Array.Clear(items, 0, items.Length);
            numberOfElements = 0;
        }

        //finding element by its value
        public int Find(T element)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < numberOfElements; i++)
            {
                result.AppendLine(items[i].ToString());
            }
            return result.ToString();
        }

        private void TryAutoGrow()
        {
            if (numberOfElements == items.Length)
            {
                T[] newArray = new T[items.Length * 2];
                for (int i = 0; i < items.Length; i++)
                {
                    newArray[i] = items[i];
                }
                this.items = newArray;
            }
        }

        public T Min<U>() where U : IComparable
        {
            T min = this.items[0];
            foreach (T item in this.items)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                } 
            }

            return min;
        }

        public T Max<U>() where U : IComparable
        {
            T max = this.items[0];
            foreach (T item in this.items)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }
    }
}
 