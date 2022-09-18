using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleExercise
{
    public class CustomTuple<T1,T2>
    {
        public CustomTuple(T1 firstElement, T2 secondElement)
        {
            this.firstElement = firstElement;
            this.secondElement = secondElement;
        }

        private T1 firstElement;
        private T2 secondElement;

        public T1 FirstElement
        {
            get { return firstElement; }
            private set { firstElement = value; }
        }

        public T2 SecondElement
        {
            get { return secondElement; }
           private set { secondElement = value; }
        }

    }
}
