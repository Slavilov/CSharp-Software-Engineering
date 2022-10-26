using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Squeak");
        }

        public override void FeedAnimal(string foodType, int quantity)
        {
            if (foodType == "Fruit" || foodType == "Vegetable")
            {
                this.Weight += quantity * 0.10;
                this.FoodEaten += quantity;
            }
            else
            {
                Console.WriteLine($"Mouse does not eat {foodType}!");
            }
        }
    }
}
