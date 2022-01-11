using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_06_Classes_Example2
{
    public class Student
    {
        public string ID;
        public string FirstName;
        public string LastName;

        public void AddStudent(List<Student> students)
        {
            students.Add(this);
        }

        public void AddStudent(List<Student> students, Student student)
        {
            students.Add(student);
        }

        public static void ShowList(List<Student> students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.ID);
                Console.WriteLine(student.FirstName);
                Console.WriteLine(student.LastName);
            }
        }

        public void DeleteStudent(List<Student> students)
        {
            students.Remove(this);
        }

        public void DeleteStudent(List<Student> students, Student student)
        {
            students.Remove(student);
        }
    }
}