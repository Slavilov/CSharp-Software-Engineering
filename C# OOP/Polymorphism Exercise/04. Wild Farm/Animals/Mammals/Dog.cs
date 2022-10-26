using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Woof!");
        }
        public override void FeedAnimal(string foodType, int quantity)
        {
            if (foodType == "Meat")
            {
                this.Weight += quantity * 0.40;
                this.FoodEaten += quantity;
            }
            else
            {
                Console.WriteLine($"Dog does not eat {foodType}!");
            }
        }
    }
}
