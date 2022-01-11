using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_05_Inheritance
{
    public class Teacher:Employee
    {
        public string Branch { get; set; }

        public void TeacherMethod()
        {
            Console.WriteLine("Teacher Method.");
        }

        protected void TeacherProtectedMethod()
        {
            Console.WriteLine("Teacher Protected Method");
            BaseMethod();
            BaseProtectedMethod();
            // BasePrivateMethod(); not available
            EmployeeProtectedMethod();
        }
    }
}
