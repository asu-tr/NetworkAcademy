using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_11_Abstract
{
    public abstract class BaseClass
    {
        public DateTime RegistrationDate;

        public void test()
        {
            Console.WriteLine("test method " + RegistrationDate);
        }

        public abstract void TestAbstract();

        public BaseClass()
        {
            Console.WriteLine("BaseClass constructor");
        }

        public BaseClass(int i)
        {
            Console.WriteLine("BaseClass constructor with parameter.");
        }
    }
}
