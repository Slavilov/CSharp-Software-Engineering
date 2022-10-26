using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; private protected set; }
        public double Weight { get; private protected set; }
        public int FoodEaten { get; set; }

        public abstract void AskForFood();

        public abstract void FeedAnimal(string foodType, int quantity);
    }
}
