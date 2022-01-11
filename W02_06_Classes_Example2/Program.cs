using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_06_Classes_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Students

            List<Student> students = new List<Student>();

            Student s1 = new Student()
            {
                ID = "112235",
                FirstName = "Mary",
                LastName = "Johann"
            };

            s1.AddStudent(students);

            Student s2 = new Student()
            {
                ID = "142536",
                FirstName = "Ian",
                LastName = "Perry"
            };

            s2.AddStudent(students, s2);

            Student.ShowList(students);

            s1.DeleteStudent(students);

            Student.ShowList(students);

            s2.DeleteStudent(students, s2);

            Student.ShowList(students);

            // Remove all students named Mary
            students.RemoveAll(i => i.FirstName == "Mary");

            // Another way to use foreach
            students.ForEach(student => Console.WriteLine(student.ID));

            bool exist = students.Any(student => student.FirstName == "Asu");

            Student s3 = students.Find(s => s.ID == "154869");

            #endregion

            #region String

            List<string> list = new List<string>();
            list.Add("Hello");
            list.Add("this");
            list.Add("is");
            list.Add("a");
            list.Add("sentence");

            ListToSentence(list);

            #endregion

            #region Time

            // 05.01.2022 13:31:19.8708512

            // 31.12.9999 23:59:59
            Console.WriteLine(DateTime.MaxValue);
            // 1.01.0001 00:00:00
            Console.WriteLine(DateTime.MinValue);
            // 5.01.2022 13:31:19
            Console.WriteLine(DateTime.Now);
            // 2022
            Console.WriteLine(DateTime.Now.Year);
            // 1
            Console.WriteLine(DateTime.Now.Month);
            // 5
            Console.WriteLine(DateTime.Now.Day);
            // 13
            Console.WriteLine(DateTime.Now.Hour);
            // 31
            Console.WriteLine(DateTime.Now.Minute);
            // 19
            Console.WriteLine(DateTime.Now.Second);
            // 870
            Console.WriteLine(DateTime.Now.Millisecond);
            // 13:31:19.8708512
            Console.WriteLine(DateTime.Now.TimeOfDay);
            // Wednesday
            Console.WriteLine(DateTime.Now.DayOfWeek);
            // 5
            Console.WriteLine(DateTime.Now.DayOfYear);
            // 5.01.2022
            Console.WriteLine(DateTime.Now.ToShortDateString());

            TimeSpan timePassed;
            DateTime today = DateTime.Now;
            DateTime past = new DateTime(1992, 10, 20);
            timePassed = today.Subtract(past); // == timePassed = today - past
            Console.WriteLine(timePassed.ToString());

            Console.WriteLine(today.ToString("dd MMMM, yyyy"));

            #endregion

            #region Math

            int value = -25;
            int positive = Math.Abs(value);
            Console.WriteLine(positive);

            Console.WriteLine(Math.Ceiling(9.18));  // 10
            Console.WriteLine(Math.Floor(9.18));     // 9

            Console.WriteLine(Math.Round(4.185924));      // 4
            Console.WriteLine(Math.Round(4.185924, 2));  // 4,19

            Console.WriteLine(Math.Sqrt(25)); // 5

            Console.WriteLine(Math.Sign(-8)); // -1
            Console.WriteLine(Math.Sign(8)); // 1

            #endregion

            Console.ReadLine();
        }

        static void ListToSentence(List<string> strings)
        {
            Console.WriteLine(string.Join(" ", strings));
        }
    }
}