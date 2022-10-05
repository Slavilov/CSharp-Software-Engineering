using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxData
{
    public class Box
    {


        private double length;
        private double width;
        private double height;

        public double Length
        {
            get { return length; }

           private set 
            {
                if (value > 0)
                {
                    length = value; 
                }
                else
                {
                    throw new ArgumentException($"{this.Length} cannot be zero or negative.");
                }
            }
        }

        public double Width
        {
            get { return width; }

            private set 
            {
                if (value > 0)
                {
                    width = value; 
                }
                else
                {
                    throw new ArgumentException($"{this.Width} cannot be zero or negative.");
                }
            }
        }

        public double Height
        {
            get { return height; }

            private set 
            { 
                if (value > 0)
                {
                    height = value; 
                }
                else
                {
                    throw new ArgumentException($"{this.Height} cannot be zero or negative.");
                }
            }
        }

        public double SurfaceArea ()
        {
            double surfaceArea = 2 * (this.length * this.width) + 2 * (this.length * this.height) + 2 * (this.height * this.width);
            return surfaceArea;
        }
        public double LateralSurfaceArea()
        {
            return 2 * this.height * (this.length + this.width);
        }
        public double Volume()
        {
            return this.length * this.width * this.height;
        }
    }
}
