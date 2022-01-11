using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_05_Inheritance
{
    public class Base
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void BaseMethod()
        {
            Console.WriteLine("BaseMethod1");
        }

        protected void BaseProtectedMethod()
        {
            // in family (only children) ^.^
        }

        private void BasePrivateMethod()
        {
            // only in class
            //EmployeeProtectedMethod(); not available
        }

        public Base()
        {
            Console.WriteLine("Base Constructor");
        }
    }
}
