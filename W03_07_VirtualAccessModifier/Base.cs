using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_07_VirtualAccessModifier
{
    public class Base
    {
        public override string ToString()
        {
            return "Override override override :D";
        }

        public virtual void Print()
        {
            Console.WriteLine("This is virtual one.");
        }
    }
}
