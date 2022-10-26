using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Meow");
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }

        public override void FeedAnimal(string foodType, int quantity)
        {
            if (foodType == "Meat" || foodType == "Vegetable")
            {
                this.Weight += quantity * 0.30;
                this.FoodEaten += quantity;
            }
            else
            {
                Console.WriteLine($"Cat does not eat {foodType}!");
            }
        }
    }
}
