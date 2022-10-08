using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int heigth;

        public Rectangle(int width, int heigth)
        {
            this.width = width;
            this.heigth = heigth;
        }

        public void Draw()
        {
            DrawLine('*', '*');
            for (int i = 0; i < heigth-2; i++)
            {
                DrawLine('*', ' ');
            }
            DrawLine('*', '*');
        }

        private void DrawLine(char boundary, char inner)
        {
            Console.WriteLine($"{boundary}{new string(inner, width -2)}{boundary}");
        }
    }
}
