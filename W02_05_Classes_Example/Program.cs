using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_05_Classes_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Employee e = new Employee();
            e.EmployeeID = 1101069;
            e.Name = "Lauren";
            e.Surname = "Wills";

            e.AddToList(employees);

            Employee e2 = new Employee();
            e2.EmployeeID = 1101070;
            e2.Name = "Jorge";
            e2.Surname = "Matias";

            e2.AddToList(employees);

            employees.Add(new Employee() { EmployeeID = 1101071, Name = "Billy", Surname = "Shaw" });

            Employee.ShowList(employees);

            e2.RemoveFromList(employees);

            Employee.ShowList(employees);

            Console.ReadLine();
        }
    }
}