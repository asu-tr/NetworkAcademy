using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_12_Abstract_Example
{
    public class Square:Shape
    {
        public int SideLength;

        public Square()
        {
            ShapeName = "Kare";
        }

        public override void CalculatePerimeter()
        {
            Console.WriteLine("Çevresi = " + 4 * SideLength);
        }

        public override void CalculateArea()
        {
            Console.WriteLine("Alanı = " + Math.Pow(SideLength, 2));
        }
    }
}
