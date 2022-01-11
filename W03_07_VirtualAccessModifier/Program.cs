using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_07_VirtualAccessModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            Console.WriteLine(b.ToString()); // namespace.classname -> "Override override override :D"

            b.Print();

            Product p = new Product();
            p.Print();

            b.Print();

            TV t = new TV();
            t.Print();

            Console.ReadKey();
        }
    }
}
