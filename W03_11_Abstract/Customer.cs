using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_11_Abstract
{
    public class Customer:BaseClass
    {
        public int CustomerID { get; set; }

        public override void TestAbstract()
        {
            throw new NotImplementedException();
        }

        public Customer()
        {
            Console.WriteLine("Customer constructor.");
        }
        public Customer(int i):base(i)
        {
            Console.WriteLine("Customer constructor with parameter");
        }
    }
}
