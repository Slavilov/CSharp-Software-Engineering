using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxSwapper
{
    internal class CustomList<T>
    {
        public CustomList()
        {
            customList = new List<T>();
        }

        private List<T> customList;

        public List<T> CstmList
        {
            get { return customList; }
            private set { customList = value; }
        }

        public void AddToCustomList(T element)
        {
            customList.Add(element);
        }

        public void BoxSwapper(int n1, int n2)
        {
            T temporaryBox = customList[n1];
            customList[n1] = customList[n2];
            customList[n2] = temporaryBox;
        }

        public void Foreach()
        {
            foreach (var element in customList)
            {
                Console.WriteLine(element);
            }
        }
    }
}
