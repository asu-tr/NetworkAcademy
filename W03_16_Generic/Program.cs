using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_16_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Course c1 = new Course();
            c1.ID = "1";
            c1.Name = "Math";
            c1.Credit = 4;

            CourseGeneric<int, string> c2 = new CourseGeneric<int, string>();
            c2.ID = 1;
            c1.Name = "Math";
            c1.Credit = 4;

            GenericClass<Course> g1 = new GenericClass<Course>();

            List<Course> courses = g1.GetAll();
        }
    }
}
