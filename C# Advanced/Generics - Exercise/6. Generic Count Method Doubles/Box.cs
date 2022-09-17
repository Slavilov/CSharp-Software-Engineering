using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxSwapper
{
    internal class Box<T> where T : IComparable
    {
        public Box()
        {
            elements = new List<T>();
        }

        private List<T> elements;

        public List<T> Elements
        {
            get { return elements; }
            private set { elements = value; }
        }

        public void AddToBox(T element)
        {
            elements.Add(element);
        }
        public override string ToString()
        {
            return $"{elements[0].GetType()}: {elements[0]}";
        }

        public int NumOfElementsLargerThanGivenElement(T element)
        {
            int counter = 0;

            foreach (var item in elements)
            {
                if (item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }

    }
}