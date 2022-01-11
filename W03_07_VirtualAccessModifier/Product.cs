using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_07_VirtualAccessModifier
{
    public class Product:Base
    {
        public override void Print()
        {
            Console.WriteLine("Product class, override method");
        }
    }
}
