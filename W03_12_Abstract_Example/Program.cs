using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_12_Abstract_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.radius = 3;

            circle.WriteShapeName();
            circle.CalculatePerimeter();
            circle.CalculateArea();

            Square square = new Square();
            square.SideLength = 3;

            square.WriteShapeName();
            square.CalculatePerimeter();
            square.CalculateArea();

            Console.ReadLine();
        }
    }
}
