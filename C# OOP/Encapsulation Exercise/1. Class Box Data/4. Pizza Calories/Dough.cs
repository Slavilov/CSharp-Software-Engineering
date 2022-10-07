using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Dough
    {
        public Dough(string flourType, string bakingTechnique, double weight)
        {
            this.FlourType = flourType.ToLower();
            this.bakingTechnique = bakingTechnique.ToLower();
            this.weight = weight;
        }

        private Dictionary<string, double> modifiers = new Dictionary<string, double>
        {
            {"white", 1.5 },
            {"wholegrain", 1.0 },
            {"crispy", 0.9 },
            {"chewy", 1.1 },
            {"homemade", 1.0}
        };

        private string flourType;
        private string bakingTechnique;
        private double weight;


        public string FlourType
        {
            get { return flourType; }

            private set
            {
                if (!modifiers.ContainsKey(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                flourType = value;
            }
        }


        public string BakingTechnique
        {
            get { return bakingTechnique; }

            private set
            {
                if (!modifiers.ContainsKey(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                bakingTechnique = value;
            }
        }

        public double Weight
        {
            get { return weight; }

            private set
            {
                if (value < 0.0 || value > 200.0)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                
                weight = value;
            }
        }

        public double Calories
        {
            get { return caloriesDough(); }
        }

        public double caloriesDough()
        {
            return (2 * this.Weight) * modifiers[this.flourType] * modifiers[this.bakingTechnique];
        }

    }
}
