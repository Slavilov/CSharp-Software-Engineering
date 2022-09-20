using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators_and_Comparators_Exercise
{
    public class ListyIterator<T>
    {
       public ListyIterator(List<T> elements)
       {
           this.elements = elements;
       }

        private List<T> elements;
        private int index = 0;

        public List<T> Elements
        {
            get { return elements; }
            set { elements = value; }
        }

        public int Index
        {
            get { return index; }
            private set { index = value; }
        }

        public void Create(params T[] elements)
        {
            this.elements = new List<T>(elements);
        }

        public bool Move()
        {
            if (this.index < this.elements.Count-1)
            {
                index++;
                Console.WriteLine("True");
                return true;
            }
            Console.WriteLine("False");
            return false;
        }

        public bool HasNext()
        {
            if (this.index < this.elements.Count-1)
            {
                Console.WriteLine("True");
                return true;
            }
            Console.WriteLine("False");
            return false;
        }

        public void Print()
        {
            if (this.elements.Count > 0 && this.index > -1)
            {
                Console.WriteLine(this.elements[this.index]);
            }
            else
            {
                throw new Exception("Invalid Operation!");
            }
        }
    }
}
