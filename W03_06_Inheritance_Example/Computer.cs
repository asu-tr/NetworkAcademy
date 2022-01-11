using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_06_Inheritance_Example
{
    public sealed class Computer:Product
    {
        public string Processor { get; set; }
        public int Memory { get; set; }
        public string GPU { get; set; }
    }
}
