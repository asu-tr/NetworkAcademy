using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_05_Inheritance
{
    public class Employee:Base
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DaysOff { get; set; }

        public void EmployeeMethod()
        {
            Console.WriteLine("Employee Method");
            BaseProtectedMethod();
        }

        protected void EmployeeProtectedMethod()
        {
            
        }
    }
}
