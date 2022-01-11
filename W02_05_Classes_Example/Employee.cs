using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_05_Classes_Example
{
    public class Employee
    {
        public long EmployeeID;
        public string Name;
        public string Surname;

        public void AddToList(List<Employee> list)
        {
            list.Add(this);
        }

        public void RemoveFromList(List<Employee> list)
        {
            list.Remove(this);
        }

        public static void ShowList(List<Employee> list)
        {
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.EmployeeID);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Surname + "\n");
            }
        }
    }
}
