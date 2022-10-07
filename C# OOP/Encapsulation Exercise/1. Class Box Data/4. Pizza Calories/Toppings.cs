using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Toppings
    {
        public Toppings(string typeOfTopping, double weight)
        {
            this.TypeOfTopping = typeOfTopping.ToLower();
            this.Weight = weight;
        }

        Dictionary<string, double> toppings = new Dictionary<string, double>()
        {
            {"meat", 1.2 },
            {"veggies", 0.8 },
            {"cheese", 1.1 },
            {"sauce", 0.9 }
        };

        private double weight;
        private string typeOfTopping;

        public double Weight
        {
            get { return weight; }

            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.typeOfTopping} weight should be in the range [1..50].");
                }
                    weight = value;
            }
        }

        public string TypeOfTopping
        {
            get { return typeOfTopping; }

            private set
            {
                if (!toppings.ContainsKey(value))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                typeOfTopping = value;
            }
        }


        public double Calories
        {
            get { return caloriesToppings(); }
        }

        public double caloriesToppings()
        {
            return (2 * this.Weight) * toppings[this.typeOfTopping];
        }
    }
}
