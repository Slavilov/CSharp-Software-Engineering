using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ShoeStore
{
    public class Shoe
    {
        public Shoe(string brand, string type, double size, string material)
        {
            this.Brand = brand;
            this.Type = type;
            this.Size = size;
            this.Material = material;
        }

        private string brand;
        private string type;
        private double size;
        private string material;

        public string Brand
        {
            get { return brand; }
            private set { brand = value; }
        }

        public string Type
        {
            get { return type; }
            private set { type = value; }
        }

        public double Size
        {
            get { return size; }
            private set { size = value; }
        }

        public string Material
        {
            get { return material; }
            private set { material = value; }
        }

        public override string ToString()
        {
            return $"Size {this.size}, {this.material} {this.brand} {this.type} shoe.";
        }
    }
}
