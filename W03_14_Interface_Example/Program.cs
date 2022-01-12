using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_14_Interface_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want Multiply or Addition? (M/A)");
            string option = Console.ReadLine().ToUpper();

            decimal result = 0;

            if (option == "M")
            {
                Multiply m = new Multiply();
                result = m.Calculate();
            }
            else if (option == "A")
            {
                Addition a = new Addition();
                result = a.Calculate();
            }
            else
                Console.WriteLine("INVALID OPTION");

            Console.WriteLine("The result is " + result);
            Console.ReadLine();
        }
    }
}
