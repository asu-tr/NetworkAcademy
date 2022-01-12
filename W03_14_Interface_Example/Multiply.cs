using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_14_Interface_Example
{
    internal class Multiply : Imath
    {
        public decimal n1 { get; set; }
        public decimal n2 { get; set; }

        public decimal Calculate()
        {
            Console.Write("Number 1: ");
            n1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Number 2: ");
            n2 = Convert.ToDecimal(Console.ReadLine());

            return n1 * n2;
        }
    }
}
