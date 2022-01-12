using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_11_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseClass b1 = new BaseClass();

            Customer customer = new Customer();
            customer.RegistrationDate = DateTime.Now;
            customer.test();

            Console.ReadKey();
        }
    }
}
