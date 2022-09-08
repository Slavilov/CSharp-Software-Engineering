using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Car
    {
        public Car()
        {

        }
        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
        }

        public Car(string model, Engine engine, int weight):this(model, engine)
        {
            this.weight = weight;
        }

        public Car(string model, Engine engine, string color):this(model, engine)
        {
            this.color = color;
        }

        public Car(string model, Engine engine, int Weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }

        private string model;
        private int weight;
        private string color = "";
        private Engine engine;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
