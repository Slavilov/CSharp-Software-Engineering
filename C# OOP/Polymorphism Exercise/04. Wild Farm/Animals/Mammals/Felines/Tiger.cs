using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("ROAR!!!");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        public override void FeedAnimal(string foodType, int quantity)
        {
            if (foodType == "Meat")
            {
                this.Weight += quantity * 1.00;
                this.FoodEaten += quantity;
            }
            else
            {
                Console.WriteLine($"Tiger does not eat {foodType}!");
            }
        }
    }
}
