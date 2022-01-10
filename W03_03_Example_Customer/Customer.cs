using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_03_Example_Customer
{
    public class Customer
    {
        static List<Customer> CustomerList = new List<Customer>();

        public string Name{ get; set; }

        private string _username;
        public string Username
        {
            get {  return _username; }
            set
            {
                if (CheckUsernameExists(value))
                {
                    _username = string.Empty;
                }

                else
                    _username = value;
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                if (CheckEmailExists(value, CustomerList))
                {
                    _email = string.Empty;
                }

                else
                    _email = value;
            }
        }

        public string Password { get; set; }

        public bool CheckUsernameExists(string username)
        {
            foreach (Customer customer in CustomerList)
            {
                if (customer.Username == username)
                    return true;
            }
            return false;
        }
        
        public static bool CheckEmailExists(string email, List<Customer> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Email == email)
                {
                    return true;
                }
            }
            return false;
        }
        public static void AddUser(Customer customer)
        {
            if (customer != null && !string.IsNullOrEmpty(customer.Email) && !string.IsNullOrEmpty(customer.Username))
            {
                CustomerList.Add(customer);
            }
        }

        public static void ShowUsers()
        {
            int count = 1;
            foreach (Customer customer in CustomerList)
            {
                Console.WriteLine($"\n{count}. Customer");
                Console.WriteLine(customer.Name);
                Console.WriteLine(customer.Email);
                Console.WriteLine(customer.Username);
                count++;
            }
        }

    }
}
