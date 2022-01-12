using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_12_Abstract_Example
{
     public abstract class Shape
    {
        protected string ShapeName;

        public void WriteShapeName()
        {
            Console.WriteLine("Şekil adı: " + ShapeName);
        }

        abstract public void CalculatePerimeter();

        abstract public void CalculateArea();
    }
}
