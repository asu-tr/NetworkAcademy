using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_02_Static
{
    class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student();

            s1.Test1();
            Student.Test2();

            s1.Name = "Harry";
            s1.Age = 55;

            Student s2 = new Student() { Name = "William", Age = 35, Email = "willy88"};

            Console.WriteLine(Student.StudentCount);



            // Unavailable: Helper h1 = new Helper();
            Helper.SendEmail(s2.Email);


            Console.ReadLine();
        }
    }
}
