using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void AskForFood()
        {
            Console.WriteLine("Hoot Hoot");
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }

        public override void FeedAnimal(string foodType, int quantity)
        {
            if (foodType == "Meat")
            {
                this.Weight += quantity * 0.25;
                this.FoodEaten += quantity;
            }
            else
            {
                Console.WriteLine($"Owl does not eat {foodType}!");
            }
        }
    }
}
