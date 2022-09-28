using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public void RemoveRandomElement()
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, this.Count-1);

            Console.WriteLine($"Removing element at index -> {randomIndex} which is {this[randomIndex]}");
            
            this.RemoveAt(randomIndex);
        }

        public string RandomString()
        {
            string elementAtIndex = string.Empty;
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, this.Count-1);
            return elementAtIndex = this[randomIndex];
        }

    }
}
