using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_02_Static
{
    public class Student
    {
        private string _name;
        private int _age;
        private string _email;
        private string _domain = "company.com";

        public static int StudentCount = 0;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        // "prop" then "tab + tab"
        public string Email
        {
            get { return _email; }
            set { _email = value+"@"+_domain; }
        }

        public Student()
        {
            StudentCount++;
        }
        // works once and before public (standard) one when the first object is created.
        static Student()
        {
            Console.WriteLine("Static Constructor.");
        }

        public void Test1()
        {
            Test2();
            _name = "name";
        }

        public static void Test2()
        {
            // Test1 unavailable
            // _name unavailable
        }
    }
}
