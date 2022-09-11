using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private readonly List<T> elements = new List<T>();

        private int count = 0;

        public int Counter
        {
            get { return count; }
            private set { count = value; }
        }


        public void Add(T element)
        {
            elements.Add(element);
            count++;
        }

        public T Remove()
        {
            T result = elements[count-1];
            count--;
            elements.Remove(result);
            return result;
        }
    }
}
