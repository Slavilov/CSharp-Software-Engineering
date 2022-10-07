using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Pizza
    {
        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Toppings>();
        }

        private string name;
        private Dough dough;
        private List<Toppings> toppings;
        private double calories;

        public double Calories
        {
            get { return totalCalories(); }
        }


        public string Name
        {
            get { return name; }

            private set
            {
                if (value == "" && value.Length <= 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        public List<Toppings> Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }

        public int numberOfToppings()
        {
            return toppings.Count;
        }

        private double totalCalories()
        {
            return dough.Calories + toppings.Select(x => x.Calories).Sum();
        }

        public void AddTopping(Toppings topping)
        {
            if (this.toppings.Count < 10)
            {
                toppings.Add(topping);
            }
            else
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }

        //public void addDough(Dough dough)
        //{
        //    this.Dough = dough;
        //}
    }
}
