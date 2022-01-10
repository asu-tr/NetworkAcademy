using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_03_Example_Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Username = "helloworldd";
            c1.Password = "123456";
            c1.Email = "hello@world.com";
            c1.Name = "John";

            Customer.AddUser(c1);

            Customer c2 = new Customer();
            c2.Username = "helloworldd";
            c2.Password = "sdffs";
            c2.Email = "hi@gmail.com";
            c2.Name = "Jane";

            Customer.AddUser(c2);

            Customer c3 = new Customer();
            c3.Username = "helloworld";
            c3.Password = "sdffs";
            c3.Email = "hi@gmail.com";
            c3.Name = "Jane";

            Customer.AddUser(c3);

            Customer.ShowUsers();

            Console.Read();
        }
    }
}
