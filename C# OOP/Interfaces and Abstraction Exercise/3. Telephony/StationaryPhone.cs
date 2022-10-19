using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class StationaryPhone : ICalling
    {
        public void Calling(int number)
        {
            Console.WriteLine($"Dialing... {number}");
        }
    }
}
