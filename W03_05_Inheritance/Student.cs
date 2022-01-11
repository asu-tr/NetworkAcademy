using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_05_Inheritance
{
    public class Student:Base
    {
        public int Grade { get; set; }
        public string Department { get; set; }

        public Student()
        {
            Console.WriteLine("Student construtor.");
        }
    }
}
