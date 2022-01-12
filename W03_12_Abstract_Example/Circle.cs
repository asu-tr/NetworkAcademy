using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_12_Abstract_Example
{
    public class Circle:Shape
    {
        public int radius;
        public const float pi = 3.14f;

        public override void CalculatePerimeter()
        {
            Console.WriteLine("Çevresi = " + 2 * pi * radius);
        }

        public override void CalculateArea()
        {
            Console.WriteLine("Alanı = " + pi * Math.Pow(radius, 2));
        }

        public Circle()
        {
            ShapeName = "Daire";
        }
    }
}
