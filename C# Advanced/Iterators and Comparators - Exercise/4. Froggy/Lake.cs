using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Froggy
{
    public class Lake<T> : IEnumerable<int>
    {
        public Lake(List<int> elements)
        {
            this.stones = elements;
        }

        private List<int> stones;

        public List<int> Stones
        {
            get { return stones; }
            set { stones = value; }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return stones[i];
                }
            }
            for (int i = stones.Count - 1; i >= 0; i--)
            {
                if (i %2 != 0)
                {
                    yield return stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)stones).GetEnumerator();
        }
    }
}
