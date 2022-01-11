using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_05_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Base B1 = new Base();
            //T1.BaseMethod();

            Student S1 = new Student();
            //S1.BaseMethod();

            Teacher T1 = new Teacher();

            B1 = S1; // boxing
            S1 = (Student)B1; // unboxing

            B1 = T1;
            T1 = (Teacher)B1;


            Employee E1 = new Employee();
            E1.EmployeeMethod();
            T1.EmployeeMethod();
            //E1.TeacherMethod(); not available
            T1.TeacherMethod();

            //T1.BaseProtectedMethod(); not available

            Console.ReadLine();
        }
    }
}
