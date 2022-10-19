using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class SmartPhone : ICalling, IBrowsing
    {
        public void Browsing(string website)
        {
            Console.WriteLine($"Browsing: {website}!");
        }

        public void Calling(int number)
        {
            Console.WriteLine($"Calling... {number}");
        }
    }
}
