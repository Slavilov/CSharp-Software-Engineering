using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._Custom_Comparator
{
    public class CustomComparator : IEnumerable
    {
        public CustomComparator(List<int> outsideElements)
        {
            this.elements = outsideElements;
        }

        private List<int> elements;

        public List<int> Elements
        {
            get { return elements; }
            set { elements = value; }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (i % 2 != 0)
                {
                    yield return elements[i];
                }
            }

            for (int i = 0; i < elements.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return elements[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)elements).GetEnumerator();
        }
    }
}
